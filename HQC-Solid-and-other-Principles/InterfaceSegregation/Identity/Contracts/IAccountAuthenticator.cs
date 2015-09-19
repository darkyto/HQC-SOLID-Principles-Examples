namespace HQC_Solid_and_other_Principles.InterfaceSegregation.Identity.Contracts
{
    using System;

    public interface IAccountAuthenticator
    {
        void Register(string username, string password);

        void Login(string username, string password);
    }
}
