﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Volo.Abp.Auditing;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.Uow;

namespace Volo.Abp.AuditLogging
{
    public class AuditingStore : IAuditingStore, ITransientDependency
    {
        public ILogger<AuditingStore> Logger { get; set; }

        private readonly IAuditLogRepository _auditLogRepository;
        private readonly IGuidGenerator _guidGenerator;
        private readonly IUnitOfWorkManager _unitOfWorkManager;
        private readonly AbpAuditingOptions Options;

        public AuditingStore(
            IAuditLogRepository auditLogRepository,
            IGuidGenerator guidGenerator,
            IUnitOfWorkManager unitOfWorkManager,
            IOptions<AbpAuditingOptions> options)
        {
            _auditLogRepository = auditLogRepository;
            _guidGenerator = guidGenerator;
            _unitOfWorkManager = unitOfWorkManager;
            Options = options.Value;

            Logger = NullLogger<AuditingStore>.Instance;
        }

        private async Task SaveLogAsync(AuditLogInfo auditInfo)
        {
            using (var uow = _unitOfWorkManager.Begin(requiresNew: true))
            {
                var auditLog = new AuditLog(_guidGenerator, auditInfo);
                await _auditLogRepository.InsertAsync(auditLog);
                await uow.SaveChangesAsync();
            }
        }
        public async Task SaveAsync(AuditLogInfo auditInfo)
        {
            if (!Options.IsEnabled)
            {
                await SaveLogAsync(auditInfo);
                return;
            }

            try
            {
                await SaveLogAsync(auditInfo);
            }
            catch (Exception ex)
            {
                Logger.LogException(ex, LogLevel.Error);
            }
        }
    }
}
