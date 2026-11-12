using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       
        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DatabaseHelper.GetOrders();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        
        }
    }
}
