namespace HQC_Solid_and_other_Principles.InterfaceSegregation.Identity
{
    using HQC_Solid_and_other_Principles.InterfaceSegregation.Identity.Contracts;

    public class AccountManager : IAccountManager
    {
        public void ChangePassword(string oldPass, string newPass)
        {
            // change password
        }
    }
}
