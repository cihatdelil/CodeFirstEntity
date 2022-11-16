using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AuthorContext authorContext = new AuthorContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in authorContext.customers
                                        select new
                                        {
                                            x.Id,
                                            x.CustomerName,
                                            x.CustomerIdentityNumber,
                                            x.Number,
                                            x.Adress


                                        }).ToList();

      
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer=new Customer();
            customer.CustomerName = textBox2.Text;
            customer.CustomerIdentityNumber = textBox3.Text;
            customer.Number = textBox4.Text;    
            customer.Adress = textBox5.Text;
            authorContext.customers.Add(customer);
            authorContext.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            var ekle = authorContext.customers.Find(id);
            ekle.CustomerName = textBox2.Text;
            ekle.CustomerIdentityNumber = textBox3.Text;
            ekle.Adress = textBox4.Text; 
            ekle.Number = textBox5.Text;
            authorContext.SaveChanges();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            var ekle = authorContext.customers.Find(id);
            authorContext.customers.Remove(ekle);
            authorContext.SaveChanges();
        }
    }
    }

