using Bank.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Bank
{
    public class BankPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(BankPermissions.GroupName, L("Permission:Bank"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BankResource>(name);
        }
    }
}