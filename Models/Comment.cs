using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace TheWall.Models
{
    public class Comment
    {
        [Key]
        public int CommentId{get; set;}


        [Required(ErrorMessage="You didn't enter a message!")]
        [MinLength(5, ErrorMessage="Post needs to be at least 5 characters")]
        public string Response{get; set;}


        [Required]
        public int UserId{get; set;}


        public User Poster{get; set;}


        [Required]
        public int MessageId{get; set;}


        public Message OriginalPost{get; set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}