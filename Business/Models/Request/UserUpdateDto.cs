﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request
{
    public class UserUpdateDto
    {
        public string Email { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string SurName { get; set; } = default!;
        public string Adress { get; set; } = default!;

        public string Gsm { get; set; } = default!;
    }
}
