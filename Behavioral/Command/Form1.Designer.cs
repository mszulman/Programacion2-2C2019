namespace Command
{
    partial class Form1
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
            this.richTextBox1 = new Command.EditorRichTextBox();
            this.btNegrita = new Command.EditorButton();
            this.btItalica = new Command.EditorButton();
            this.btSubrayado = new Command.EditorButton();
            this.btAumentarTamanio = new Command.EditorButton();
            this.btReducirTamanio = new Command.EditorButton();
            this.btDeshacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(126, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(561, 263);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Hola Manola";
            // 
            // btNegrita
            // 
            this.btNegrita.Location = new System.Drawing.Point(12, 12);
            this.btNegrita.Name = "btNegrita";
            this.btNegrita.Size = new System.Drawing.Size(75, 23);
            this.btNegrita.TabIndex = 1;
            this.btNegrita.Text = "N";
            this.btNegrita.UseVisualStyleBackColor = true;
            this.btNegrita.Click += new System.EventHandler(this.btNegrita_Click);
            // 
            // btItalica
            // 
            this.btItalica.Location = new System.Drawing.Point(93, 12);
            this.btItalica.Name = "btItalica";
            this.btItalica.Size = new System.Drawing.Size(75, 23);
            this.btItalica.TabIndex = 1;
            this.btItalica.Text = "I";
            this.btItalica.UseVisualStyleBackColor = true;
            this.btItalica.Click += new System.EventHandler(this.btItalica_Click);
            // 
            // btSubrayado
            // 
            this.btSubrayado.Location = new System.Drawing.Point(174, 12);
            this.btSubrayado.Name = "btSubrayado";
            this.btSubrayado.Size = new System.Drawing.Size(75, 23);
            this.btSubrayado.TabIndex = 1;
            this.btSubrayado.Text = "S";
            this.btSubrayado.UseVisualStyleBackColor = true;
            this.btSubrayado.Click += new System.EventHandler(this.btSubrayado_Click);
            // 
            // btAumentarTamanio
            // 
            this.btAumentarTamanio.Location = new System.Drawing.Point(255, 12);
            this.btAumentarTamanio.Name = "btAumentarTamanio";
            this.btAumentarTamanio.Size = new System.Drawing.Size(75, 23);
            this.btAumentarTamanio.TabIndex = 1;
            this.btAumentarTamanio.Text = "+";
            this.btAumentarTamanio.UseVisualStyleBackColor = true;
            this.btAumentarTamanio.Click += new System.EventHandler(this.btAumentarTamanio_Click);
            // 
            // btReducirTamanio
            // 
            this.btReducirTamanio.Location = new System.Drawing.Point(336, 12);
            this.btReducirTamanio.Name = "btReducirTamanio";
            this.btReducirTamanio.Size = new System.Drawing.Size(75, 23);
            this.btReducirTamanio.TabIndex = 1;
            this.btReducirTamanio.Text = "-";
            this.btReducirTamanio.UseVisualStyleBackColor = true;
            this.btReducirTamanio.Click += new System.EventHandler(this.btReducirTamanio_Click);
            // 
            // btDeshacer
            // 
            this.btDeshacer.Location = new System.Drawing.Point(605, 12);
            this.btDeshacer.Name = "btDeshacer";
            this.btDeshacer.Size = new System.Drawing.Size(82, 23);
            this.btDeshacer.TabIndex = 2;
            this.btDeshacer.Text = "Deshacer";
            this.btDeshacer.UseVisualStyleBackColor = true;
            this.btDeshacer.Click += new System.EventHandler(this.btDeshacer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDeshacer);
            this.Controls.Add(this.btReducirTamanio);
            this.Controls.Add(this.btAumentarTamanio);
            this.Controls.Add(this.btSubrayado);
            this.Controls.Add(this.btItalica);
            this.Controls.Add(this.btNegrita);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        EditorRichTextBox richTextBox1;
        EditorButton btNegrita;
        private EditorButton btItalica;
        private EditorButton btSubrayado;
        private EditorButton btAumentarTamanio;
        private EditorButton btReducirTamanio;
        private System.Windows.Forms.Button btDeshacer;
    }
}

