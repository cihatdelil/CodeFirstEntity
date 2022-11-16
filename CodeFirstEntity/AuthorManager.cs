using CodeFirstEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CodeFirstEntity
{
    public partial class AuthorManager : Form, Interface1<Author>
    {
        public AuthorManager()
        {
            InitializeComponent();
        }
        AuthorContext authorContext = new AuthorContext();


        private void AuthorManager_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = All();
        }

        public List<Author> All()
        {


            return authorContext.authors.ToList();
        }

        public void Add(Author entity)
        {


            authorContext.authors.Add(entity);
            authorContext.SaveChanges();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Author a = new Author();
            a.AuthorName = textBox2.Text;
            a.IdentityNumber = textBox3.Text;
            a.BirthDay = Convert.ToDateTime(maskedTextBox1.Text);
            Add(a);
            All();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            var ekle = authorContext.authors.Find(id);
            ekle.AuthorName = textBox2.Text;
            ekle.IdentityNumber = textBox3.Text;
            ekle.BirthDay = Convert.ToDateTime(maskedTextBox1.Text);
            authorContext.SaveChanges();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            var ekle = authorContext.authors.Find(id);
            authorContext.authors.Remove(ekle);
            authorContext.SaveChanges();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

        }
    }
}
//dataGridView1.DataSource = authorContext.authors.Select(x => new
//{
//    x.Id,
//    x.IdentityNumber,
//    x.AuthorName,
//    x.BirthDay
//}).ToList();