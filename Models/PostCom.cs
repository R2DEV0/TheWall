using System.Collections.Generic;

namespace TheWall.Models
{
    public class PostCom
    {
        public List<Message> AllMessages{get; set;}

        public List<Comment> AllComments{get; set;}

        public List<User> AllUsers{get; set;}

        public User UserForm{get; set;}

        public Message MessageForm{get; set;}

        public Comment CommentForm{get; set;}
    }
}