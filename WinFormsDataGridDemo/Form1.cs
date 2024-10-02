using System.Data;

namespace WinFormsDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //get datasource
            DataTable books = new DataTable();
            books.ReadXml(Application.StartupPath + @"\Data\Books.xml");

            DataTable authors = new DataTable();
            authors.ReadXml(Application.StartupPath + @"\Data\Authors.xml");

            dataGrid1.DataSource = books;


        }
    }
}
