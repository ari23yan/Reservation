﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Domain.Entities.Account
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }


        public string Mobile { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        //public string? ProfileImage { get; set; }

    }
}
