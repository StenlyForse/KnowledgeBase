using System.ComponentModel;

namespace MainApp.Models
{
    public class Article
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Priority { get; set; }

    }

}
