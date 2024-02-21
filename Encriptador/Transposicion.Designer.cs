namespace Encriptador
{
    partial class Transposicion
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
            tbEncriptado = new TextBox();
            tbLlave = new TextBox();
            tbTextoPlano = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // tbEncriptado
            // 
            tbEncriptado.Location = new Point(290, 143);
            tbEncriptado.Name = "tbEncriptado";
            tbEncriptado.Size = new Size(323, 23);
            tbEncriptado.TabIndex = 0;
            // 
            // tbLlave
            // 
            tbLlave.Location = new Point(290, 98);
            tbLlave.Name = "tbLlave";
            tbLlave.Size = new Size(100, 23);
            tbLlave.TabIndex = 0;
            // 
            // tbTextoPlano
            // 
            tbTextoPlano.Location = new Point(290, 54);
            tbTextoPlano.Name = "tbTextoPlano";
            tbTextoPlano.Size = new Size(323, 23);
            tbTextoPlano.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 62);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Texto plano";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 106);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Llave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 151);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 1;
            label3.Text = "Texto encriptado";
            // 
            // button1
            // 
            button1.Location = new Point(619, 54);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Encriptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(619, 147);
            button2.Name = "button2";
            button2.Size = new Size(90, 23);
            button2.TabIndex = 2;
            button2.Text = "Desencriptar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Transposicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbTextoPlano);
            Controls.Add(tbLlave);
            Controls.Add(tbEncriptado);
            Name = "Transposicion";
            Text = "Transposicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEncriptado;
        private TextBox tbLlave;
        private TextBox tbTextoPlano;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}