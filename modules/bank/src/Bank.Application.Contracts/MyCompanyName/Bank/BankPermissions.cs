using Volo.Abp.Reflection;

namespace Bank
{
    public class BankPermissions
    {
        public const string GroupName = "Bank";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(BankPermissions));
        }
    }
}