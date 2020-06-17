using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace TheWall.Models
{
    public class Message
    {
        [Key]
        public int MessageId{get; set;}


        [Required(ErrorMessage="You didn't enter a message!")]
        [MinLength(5, ErrorMessage="Your post must be at least 5 characters")]
        public string Post{get; set;}


        [Required]
        public int UserId{get; set;}


        public User Poster {get; set;}


        public List<Comment> ConnectedComments {get; set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}