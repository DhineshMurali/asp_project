using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace services
{
    public class mockuserRep : IUserRep
    {
        private List<user> _userList;
        public mockuserRep()
        {
            _userList = new List<user>()
            {
                new user(){ ID = 1,username = "Dhinesh14", mail = "dhineshmurali1961@gmail.com", Series= series.action,Photopath ="mypic.jpg"},
                 new user(){ ID = 2,username = "Abhinand01", mail = "abhinandpremand@gmail.com", Series= series.love},
            };
        }
        public IEnumerable<user> GetAllUser()
        {
            return _userList;

        }
    }
}
