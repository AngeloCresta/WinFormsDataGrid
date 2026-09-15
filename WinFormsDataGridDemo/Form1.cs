using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
