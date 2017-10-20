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

        [Required, Display(Name="Where'd you go?")]
        public string Location { get; set; }
        [Required, Display(Name ="Give us a short blurb..")]
        public string Title { get; set; }
        [Required, Display(Name ="What'd you think?")]
        public string CustomerReview { get; set; }
        [Display(Name ="When'd you go?")]
        public DateTime VisitDate { get; set; }
        [Required, Display(Name ="Do you recommend?")]
        public bool Recommend { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}