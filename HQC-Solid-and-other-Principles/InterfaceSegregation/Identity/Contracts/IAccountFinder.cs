namespace HQC_Solid_and_other_Principles.InterfaceSegregation.Identity.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface IAccountFinder
    {
        IEnumerable<IUser> GetAllUsersOnline();

        IEnumerable<IUser> GetAllUsers();

        IUser GetUserByName(string name);
    }
}
