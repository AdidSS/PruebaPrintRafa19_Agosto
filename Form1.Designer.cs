namespace PruebaPrintRafa19_Agosto
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
            button1 = new Button();
            Población = new Label();
            Corte = new Label();
            Iteraciones = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(241, 246);
            button1.Name = "button1";
            button1.Size = new Size(239, 29);
            button1.TabIndex = 0;
            button1.Text = "Correr Algoritmo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Población
            // 
            Población.AutoSize = true;
            Población.Location = new Point(248, 62);
            Población.Name = "Población";
            Población.Size = new Size(74, 20);
            Población.TabIndex = 1;
            Población.Text = "Población";
            // 
            // Corte
            // 
            Corte.AutoSize = true;
            Corte.Location = new Point(248, 115);
            Corte.Name = "Corte";
            Corte.Size = new Size(45, 20);
            Corte.TabIndex = 2;
            Corte.Text = "Corte";
            Corte.Click += label1_Click;
            // 
            // Iteraciones
            // 
            Iteraciones.AutoSize = true;
            Iteraciones.Location = new Point(241, 171);
            Iteraciones.Name = "Iteraciones";
            Iteraciones.Size = new Size(81, 20);
            Iteraciones.TabIndex = 3;
            Iteraciones.Text = "Iteraciones";
            Iteraciones.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(355, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(355, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(355, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Iteraciones);
            Controls.Add(Corte);
            Controls.Add(Población);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Población;
        private Label Corte;
        private Label Iteraciones;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
