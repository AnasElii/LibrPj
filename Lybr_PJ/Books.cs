using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace x_prj_biblio
{
    class Books
    {
        private static string _id;
        private string title;
        private string book_autor;
        private string book_editor;
        private string isbn;               
        private int page_number;
        private int quantity;
        private string category;
        private static string _image_id;
        private DateTime date_created;
        private SqlCommand cmd;
        private byte[] imgData;
        private int zon;

        Connexion c ;
        private Zon z;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Writer
        {
            get { return book_autor; }
            set { book_autor = value; }
        }

        public string Publisher
        {
            get { return book_editor; }
            set { book_editor = value; }
        }                

        public int Puge_number
        {
            get { return page_number; }
            set { page_number = value; }
        }

        public int Quantity
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

        public int ZON
        {
            get { return zon; }
            set { zon = value; }
        }

        public byte[] Imag
        {
            get { return imgData; }
            set { imgData = value; }
        }

        public Books()
        {
          
        }
        public Books(string isbn, string book_editor, string title, string puge_number, int quantity, DateTime date_created, string category)
        {
            this.isbn = isbn;
            this.book_editor = book_editor;
            this.title = title;            
            this.quantity = quantity;
            this.date_created = date_created;
            this.category = category;
        }

        int autorId()
        {
            c = new Connexion();

            int i = int.Parse(c.executer_valeur(string.Format(@"SELECT aut_id FROM Autor WHERE autor_name = '{0}'", book_autor)));
            
            return i;
        }

        int PublisherId()
        {
            c = new Connexion();

            int i = int.Parse(c.executer_valeur(string.Format(@"SELECT [EDITOR_id] FROM editor WHERE [EDITOR_name] = '{0}'", book_editor)));
             
            return i;
        }

        int CategoryID()
        {
            c = new Connexion();

            int i = int.Parse(c.executer_valeur(string.Format(@"Select [id] from [dbo].[Category] WHERE [nom] = '{0}'", category)));

            return i;
        }

        int ZonID()
        {
            c = new Connexion();

            int i = int.Parse(c.executer_valeur(string.Format(@"SELECT [id] FROM [dbo].[Zon] WHERE [nom] =  '{0}'", zon)));

            return i;
        }

        public void Add()
        {
            c = new Connexion();

            int a_ID = autorId();
            int p_ID = PublisherId();
            int c_ID = CategoryID();
            int z_ID = ZonID();

            c.Con.Open();

            cmd = new SqlCommand("dbo.I_Book", c.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id_editor", SqlDbType.Int);
            cmd.Parameters.Add("@aut_id", SqlDbType.Int);
            cmd.Parameters.Add("@zon_id", SqlDbType.Int);
            cmd.Parameters.Add("@book_isbn", SqlDbType.VarChar,50);
            cmd.Parameters.Add("@title", SqlDbType.VarChar,50);
            cmd.Parameters.Add("@page_number", SqlDbType.Int);
            cmd.Parameters.Add("@date_added", SqlDbType.Date);
            cmd.Parameters.Add("@date_created", SqlDbType.Date);
            cmd.Parameters.Add("@quantity", SqlDbType.Int);
            cmd.Parameters.Add("@category", SqlDbType.Int);
            cmd.Parameters.Add("@image", SqlDbType.VarBinary);

            cmd.Parameters["@aut_id"].Value = a_ID;
            cmd.Parameters["@id_editor"].Value = p_ID;            
            cmd.Parameters["@zon_id"].Value = z_ID;
            cmd.Parameters["@book_isbn"].Value = isbn;
            cmd.Parameters["@title"].Value = title;
            cmd.Parameters["@page_number"].Value = page_number;
            cmd.Parameters["@date_created"].Value = date_created;
            cmd.Parameters["@date_added"].Value = DateTime.Now;
            cmd.Parameters["@quantity"].Value = quantity;
            cmd.Parameters["@category"].Value = c_ID;
            cmd.Parameters["@image"].Value = imgData;

            cmd.ExecuteNonQuery();
            c.Con.Close();
        }

        public void Update()
        {

        }

        public void Delete()
        {
            c = new Connexion();
            

            c.Con.Open();

            cmd = new SqlCommand("[dbo].[D_BOOK]", c.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@book_id", SqlDbType.Int);
            cmd.Parameters["@book_id"].Value = int.Parse(_id);

            cmd.ExecuteNonQuery();
            c.Con.Close();

            _id = null;
        }

    }
}
