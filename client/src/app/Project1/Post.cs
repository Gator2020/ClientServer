using System;
using System.Collection;
using System.Linq;
using System.Threading;
namespace Domain
{
    public class Post
    {
        public Guid Id{get; set;}
        public string Title{get; set;}
        public string Body{get; set;}
        public DateTime Date{get; set;}
        

    }
}