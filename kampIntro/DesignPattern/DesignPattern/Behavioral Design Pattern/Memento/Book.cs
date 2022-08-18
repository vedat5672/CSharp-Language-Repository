using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    public partial class Book
    {
        private string _title;
        private string _author;
        private string _ısbn;
        private DateTime _lastEdited;

        public string GetTitle()
        {
            return _title;
            
        }

        public void SetTitle(string value)
        {
            _title = value;
            SetLastEdited();
        }

        public string GetAuthor()
        {
            return _author;
        }

        public void SetAuthor(string value)
        {
            _author = value;
            SetLastEdited();
        }

        public string GetIsbn()
        {
            return _ısbn;
        }

        public void SetIsbn(string value)
        {
            _ısbn = value;
            SetLastEdited();
        }

        private void SetLastEdited()
        {
            _lastEdited = DateTime.UtcNow;
        }
        public Memento CreateUndo()
        {
            return new Memento(_title,_author,_ısbn,_lastEdited);
        }
        public void RestoreFromUndo(Memento memento)
        {
            _title=memento.Title;
            _author=memento.Author;
            _ısbn=memento.Isbn;
            _lastEdited=memento.LastEdited;
        }
        public void ShowBook()
        {
            Console.WriteLine("{0},{1},{2} edited {3}",_ısbn,_title,_author,_lastEdited);
        }
    }
}
