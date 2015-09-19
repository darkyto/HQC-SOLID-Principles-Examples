namespace HQC_Solid_and_other_Principles.InterfaceSegregation.Identity.Contracts
{
    using System;

    public interface IUser
    {
        string Email { get; }

        string PasswordHash { get; }
    }
}
