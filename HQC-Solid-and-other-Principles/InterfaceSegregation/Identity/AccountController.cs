namespace HQC_Solid_and_other_Principles.InterfaceSegregation.Identity
{
    using System;
    using HQC_Solid_and_other_Principles.InterfaceSegregation.Identity.Contracts;

    public class AccountController
    {
        private IAccountManager manager;

        public AccountController(IAccountManager manager)
        {
            this.manager = manager;
        }

        public void ChangePassword(string oldPass, string newPass)
        {
            this.manager.ChangePassword(oldPass, newPass);
        }
    }
}
