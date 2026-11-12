namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(105, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 416);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Меню";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.ForeColor = SystemColors.ControlDarkDark;
            button3.Location = new Point(163, 340);
            button3.Name = "button3";
            button3.Size = new Size(171, 52);
            button3.TabIndex = 2;
            button3.Text = "Помощь";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(246, 123);
            button2.Name = "button2";
            button2.Size = new Size(239, 102);
            button2.TabIndex = 1;
            button2.Text = "Предыдущие заказы";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(23, 123);
            button1.Name = "button1";
            button1.Size = new Size(192, 102);
            button1.TabIndex = 0;
            button1.Text = "Создать заказ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = SystemColors.ControlDarkDark;
            button4.Location = new Point(602, 538);
            button4.Name = "button4";
            button4.Size = new Size(106, 39);
            button4.TabIndex = 1;
            button4.Text = "Выйти";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(187, 33);
            label1.Name = "label1";
            label1.Size = new Size(362, 49);
            label1.TabIndex = 2;
            label1.Text = "Добро пожаловать!";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(720, 584);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Label label1;
    }
}