﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthHostel.Models
{
    public class Animal // таблица с животными
    {
        [Key]
        public int ID { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int ClientID { get; set; }
    }
}