using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        [Required, Display(Name="Location")]
        public string Location { get; set; }
        [Required, Display(Name ="Title")]
        public string Title { get; set; }
        [Required, Display(Name ="Review")]
        public string CustomerReview { get; set; }
        [Display(Name ="Visit Date")]
        public DateTime VisitDate { get; set; }
        [Required, Display(Name ="Recommend?")]
        public bool Recommend { get; set; }

        [ForeignKey("Category")] 
        [Display(Name ="Type of Joint")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}