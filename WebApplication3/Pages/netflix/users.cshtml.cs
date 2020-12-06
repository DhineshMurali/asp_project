using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using services;

namespace WebApplication3.Pages.netflix
{
    
   
        public class usersModel : PageModel
        {
            private readonly IUserRep userRep;
            public IEnumerable<user> users { get; set; }
            public usersModel(IUserRep userRep)
            {
                this.userRep = userRep;
            }
            public void OnGet()
            {
                users = userRep.GetAllUser();
            }
        }
       
    
}