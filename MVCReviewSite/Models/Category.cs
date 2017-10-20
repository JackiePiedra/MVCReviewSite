﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string PlaceCategory { get; set; }
    }
}