using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string login = textBox1.Text;
            string password = textBox2.Text;

           
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            bool isValid = DatabaseHelper.CheckLogin(login, password);

            if (isValid)
            {
                
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide(); 
            }
            else
            {
                
                MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear(); 
            }
        }
    }
}