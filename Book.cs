using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApASPNetCoreDemo1.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int Bid { get; set; }
        [Display(Name ="Book Title")]
        [Required]
        public string BTitle { get; set; }
        
        public string Category { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Display(Name ="Author Name")]
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string Publisher { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Release Date")]
        public DateTime Releasedate { get; set; }
    }
}
