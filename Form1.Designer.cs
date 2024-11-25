namespace WinFormsTabla
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
            panel1 = new Panel();
            richTextBoxResultados = new RichTextBox();
            botonVer = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            labelTitulo = new Label();
            labelNombre = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AccessibleName = "panel1";
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(labelNombre);
            panel1.Controls.Add(richTextBoxResultados);
            panel1.Controls.Add(botonVer);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelTitulo);
            panel1.Location = new Point(-1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 447);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Location = new Point(311, 192);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(171, 215);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            richTextBoxResultados.TextChanged += richTextBoxResultados_TextChanged;
            // 
            // botonVer
            // 
            botonVer.Location = new Point(330, 131);
            botonVer.Name = "botonVer";
            botonVer.Size = new Size(152, 23);
            botonVer.TabIndex = 3;
            botonVer.Text = "Cambiar tabla";
            botonVer.UseVisualStyleBackColor = true;
            botonVer.Click += botonVer_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 66);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 1;
            label1.Text = "¿Cual tabla de multiplicar quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(346, 31);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(125, 14);
            labelTitulo.TabIndex = 0;
            labelTitulo.Tag = "dgfg";
            labelTitulo.Text = "Tabla de Multiplicar";
            labelTitulo.Click += label1_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(228, 160);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(371, 29);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Luis Antonio García Gómez";
            labelNombre.Click += labelNombre_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTitulo;
        private Label label1;
        private RichTextBox richTextBoxResultados;
        private Button botonVer;
        private TextBox textBox1;
        private Label labelNombre;
    }
}
