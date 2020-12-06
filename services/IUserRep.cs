using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace services
{
    public interface IUserRep
    {
        IEnumerable<user> GetAllUser();

    }
}
