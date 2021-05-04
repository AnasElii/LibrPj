using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_prj_biblio
{
    class Books
    {
        private static string _id;
        private string title;
        private string book_autor;
        private string book_editor;
        private string isbn;               
        private string puge_number;
        private int quantity;
        private string category;
        private static string _image_id;
        private DateTime date_created;

        private Zon z;

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Book_editor
        {
            get { return book_editor; }
            set { book_editor = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Puge_number
        {
            get { return puge_number; }
            set { puge_number = value; }
        }

        public int Book_quan
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public DateTime Add_time
        {
            get { return date_created; }
            set { date_created = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public Books()
        {

        }
        public Books(string isbn, string book_editor, string title, string puge_number, int quantity, DateTime date_created, string category)
        {
            this.isbn = isbn;
            this.book_editor = book_editor;
            this.title = title;
            this.puge_number = puge_number;
            this.quantity = quantity;
            this.date_created = date_created;
            this.category = category;
        }

        public void Ajout()
        {

        }

        public void Modefi()
        {

        }

        public void Supprem()
        {

        }

    }
}
