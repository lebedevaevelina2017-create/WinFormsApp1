using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        // Массив цен на услуги
        private decimal[] prices = { 5000, 3000, 1500, 10000 };

        public Form3()
        {
            InitializeComponent();
        }

        // 1. Загрузка формы
        private void Form3_Load(object sender, EventArgs e)
        {
            // Проверка
            if (checkedListBox1.Items.Count == 0)
            {
                checkedListBox1.Items.Add("Копка могилы (5000)");
                checkedListBox1.Items.Add("Услуги катафалка (3000)");
                checkedListBox1.Items.Add("Траурный венок (1500)");
                checkedListBox1.Items.Add("Организация похорон (10000)");
            }
        }

        // 2. Подсчет суммы 
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            decimal sum = 0;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                bool isChecked = checkedListBox1.GetItemChecked(i);
                
                if (i == e.Index) isChecked = (e.NewValue == CheckState.Checked);

                if (isChecked) sum += prices[i];
            }

            
            label2.Text = $"Итого: {sum} руб.";
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Заполните ФИО заказчика и усопшего!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string selectedServices = "";
            decimal totalSum = 0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    selectedServices += checkedListBox1.Items[i].ToString() + "; ";
                    totalSum += prices[i];
                }
            }

            
            if (string.IsNullOrWhiteSpace(selectedServices))
            {
                MessageBox.Show("Выберите хотя бы одну услугу!", "Внимание");
                return;
            }

            
            bool success = DatabaseHelper.SaveOrder(
                textBox1.Text,   // Заказчик
                textBox2.Text,   // Телефон
                textBox3.Text,   // Услуга/Усопший
                selectedServices,// Выбранные услуги
                totalSum         // Сумма
            );

            if (success)
            {
                MessageBox.Show("Заказ успешно сохранен в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
