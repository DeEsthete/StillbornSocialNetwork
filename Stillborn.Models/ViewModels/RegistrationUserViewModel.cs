using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Models.ViewModels
{
    public class RegistrationUserViewModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
        public bool Gender { get; set; }
    }
}
