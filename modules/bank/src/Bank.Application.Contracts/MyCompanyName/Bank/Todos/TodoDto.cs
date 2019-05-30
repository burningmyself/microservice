using System;
using Volo.Abp.Application.Dtos;

namespace Bank.Todos
{
    public class TodoDto : EntityDto<Guid>
    {
        public string Text { get; set; }
    }
}