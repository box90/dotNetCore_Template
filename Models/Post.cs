using System.ComponentModel.DataAnnotations;

namespace dotNetCore_Template.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}