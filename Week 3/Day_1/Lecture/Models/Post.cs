using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lecture.Models
{
    public class Post
    {
        [Key]
        public int PostId {get;set;}
        [Required(ErrorMessage="Field is required")]
        [DataType(DataType.Text)]
        [MaxLength(200, ErrorMessage="No more than 200 characters")]
        [Display(Name="Enter your post here:")]
        public string Content {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public User UserPosted {get;set;}
        public List<Vote> Votes {get;set;}
    }
}