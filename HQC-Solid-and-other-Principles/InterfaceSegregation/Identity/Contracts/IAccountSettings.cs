namespace HQC_Solid_and_other_Principles.InterfaceSegregation.Identity.Contracts
{
    using System;

    public interface IAccountSettings
    {
        bool RequireUniqueEmail { get; set; }

        int MinPasswordLength { get; set; }

        int MaxPasswordLength { get; set; }
    }
}
