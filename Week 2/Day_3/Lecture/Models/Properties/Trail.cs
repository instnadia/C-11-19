using System.ComponentModel.DataAnnotations;
using System;

namespace Lecture.Models
{
    public class Trail
    {
        [Key]
        public int TrailId {get;set;}
        [Required]
        [Display(Name="Trail name:")]
        public string Name {get;set;}
        [Required]
        [MaxLength(100)]
        public string Description {get;set;}
        [Required]
        [Display(Name="Length:")]
        public int length {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdateddAt {get;set;} = DateTime.Now;
    }
}