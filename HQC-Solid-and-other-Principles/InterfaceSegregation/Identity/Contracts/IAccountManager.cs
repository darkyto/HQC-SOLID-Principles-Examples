namespace HQC_Solid_and_other_Principles.InterfaceSegregation.Identity.Contracts
{
    using System;

    public interface IAccountManager
    {
        void ChangePassword(string oldPassword, string newPassword);
    }
}
