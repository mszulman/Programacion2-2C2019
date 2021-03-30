namespace Observer
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
            this.btTomadorDePulso = new System.Windows.Forms.Button();
            this.btTemperatura = new System.Windows.Forms.Button();
            this.btPeso = new System.Windows.Forms.Button();
            this.lvCardiologo = new System.Windows.Forms.ListView();
            this.lvNutricionista = new System.Windows.Forms.ListView();
            this.lvTraumatologo = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btTomadorDePulso
            // 
            this.btTomadorDePulso.Location = new System.Drawing.Point(129, 12);
            this.btTomadorDePulso.Name = "btTomadorDePulso";
            this.btTomadorDePulso.Size = new System.Drawing.Size(100, 100);
            this.btTomadorDePulso.TabIndex = 0;
            this.btTomadorDePulso.Text = "Pulso";
            this.btTomadorDePulso.UseVisualStyleBackColor = true;
            this.btTomadorDePulso.Click += new System.EventHandler(this.BtTomadorDePulso_Click);
            this.btTomadorDePulso.Click += new System.EventHandler(this.PruebaDeMetodo);
            // 
            // btTemperatura
            // 
            this.btTemperatura.Location = new System.Drawing.Point(129, 174);
            this.btTemperatura.Name = "btTemperatura";
            this.btTemperatura.Size = new System.Drawing.Size(100, 100);
            this.btTemperatura.TabIndex = 0;
            this.btTemperatura.Text = "Temperatura";
            this.btTemperatura.UseVisualStyleBackColor = true;
            this.btTemperatura.Click += new System.EventHandler(this.BtTemperatura_Click);
            // 
            // btPeso
            // 
            this.btPeso.Location = new System.Drawing.Point(129, 338);
            this.btPeso.Name = "btPeso";
            this.btPeso.Size = new System.Drawing.Size(100, 100);
            this.btPeso.TabIndex = 0;
            this.btPeso.Text = "Peso";
            this.btPeso.UseVisualStyleBackColor = true;
            this.btPeso.Click += new System.EventHandler(this.BtPeso_Click);
            // 
            // lvCardiologo
            // 
            this.lvCardiologo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lvCardiologo.Location = new System.Drawing.Point(490, 12);
            this.lvCardiologo.Name = "lvCardiologo";
            this.lvCardiologo.Size = new System.Drawing.Size(641, 97);
            this.lvCardiologo.TabIndex = 1;
            this.lvCardiologo.UseCompatibleStateImageBehavior = false;
            this.lvCardiologo.View = System.Windows.Forms.View.Details;
            // 
            // lvNutricionista
            // 
            this.lvNutricionista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvNutricionista.Location = new System.Drawing.Point(490, 174);
            this.lvNutricionista.Name = "lvNutricionista";
            this.lvNutricionista.Size = new System.Drawing.Size(641, 97);
            this.lvNutricionista.TabIndex = 1;
            this.lvNutricionista.UseCompatibleStateImageBehavior = false;
            this.lvNutricionista.View = System.Windows.Forms.View.Details;
            // 
            // lvTraumatologo
            // 
            this.lvTraumatologo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvTraumatologo.Location = new System.Drawing.Point(490, 341);
            this.lvTraumatologo.Name = "lvTraumatologo";
            this.lvTraumatologo.Size = new System.Drawing.Size(641, 97);
            this.lvTraumatologo.TabIndex = 1;
            this.lvTraumatologo.UseCompatibleStateImageBehavior = false;
            this.lvTraumatologo.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cardiologo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nutricionista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Traumatologo";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 626;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 618;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 617;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvTraumatologo);
            this.Controls.Add(this.lvNutricionista);
            this.Controls.Add(this.lvCardiologo);
            this.Controls.Add(this.btPeso);
            this.Controls.Add(this.btTemperatura);
            this.Controls.Add(this.btTomadorDePulso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTomadorDePulso;
        private System.Windows.Forms.Button btTemperatura;
        private System.Windows.Forms.Button btPeso;
        private System.Windows.Forms.ListView lvCardiologo;
        private System.Windows.Forms.ListView lvNutricionista;
        private System.Windows.Forms.ListView lvTraumatologo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

