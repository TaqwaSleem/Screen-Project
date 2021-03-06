﻿using ScreenProject.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Models
{
    public class Employee: IBaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DOB { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }

    }
}
