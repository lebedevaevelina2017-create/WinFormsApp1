namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(226, 9);
            label1.Name = "label1";
            label1.Size = new Size(314, 50);
            label1.TabIndex = 0;
            label1.Text = "Создание заказа";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(619, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "ФИО заказчика";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(618, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "Телефон";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(64, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(618, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "ФИО усопшего";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(64, 270);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(193, 148);
            checkedListBox1.TabIndex = 4;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(372, 270);
            label2.Name = "label2";
            label2.Size = new Size(169, 32);
            label2.TabIndex = 5;
            label2.Text = "Итого: 0 руб.";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(64, 445);
            button1.Name = "button1";
            button1.Size = new Size(193, 51);
            button1.TabIndex = 6;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(607, 588);
            button2.Name = "button2";
            button2.Size = new Size(109, 44);
            button2.TabIndex = 7;
            button2.Text = "Выйти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(728, 644);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}