using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;

namespace MvcCRM.Models
{
    public class UserSurnameViewModel
    {
        public List<User> users;
        public SelectList surnames;
        public string userSurname { get; set; }
    }
}
