namespace DesignPattern.Memento
{
    public partial class Book
    {
        public class Memento
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Isbn { get; set; }
            public DateTime LastEdited { get; set; }
            public Memento(string title,string author, string ısbn,DateTime lastedited)
            {
                Title = title;
                Author = author;
                Isbn = ısbn;
                LastEdited = lastedited;
            }


        }
    }
}
