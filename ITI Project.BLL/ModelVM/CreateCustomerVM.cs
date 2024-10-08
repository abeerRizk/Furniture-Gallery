﻿using ITI_Project.DAL.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Project.BLL.ModelVM
{
    public class CreateCustomerVM
    {

        [Required]
        public string Name { get; set; }

      
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Range(10,100) ]
        public int? Age { get; set; }
        public bool? IsDeleted { get; set; }

        [Required]
        public string? Phone_Number { get; set; }
        [Required]
        public string? Location { get; set; }

        public string userId { get; set; }


    }
}
