namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(194, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 16);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 67);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Insira o seu CNPJ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 104);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Insira sua senha";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(194, 122);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(205, 16);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.AccessibleName = "btnAbrirFormSecundaria";
            button1.Location = new Point(582, 306);
            button1.Name = "button1";
            button1.Size = new Size(99, 65);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(516, 327);
            button2.Name = "button2";
            button2.Size = new Size(60, 44);
            button2.TabIndex = 5;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fundo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(693, 401);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Tela de login - Stockar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;

        
    }
}