namespace ListaCapemi.Forms.Otros
{
    partial class Marcas
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.btnGrabarMarca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarcaIns = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "EDICION DE MARCAS";
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(12, 54);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.Size = new System.Drawing.Size(216, 154);
            this.dgvMarca.TabIndex = 42;
            // 
            // btnGrabarMarca
            // 
            this.btnGrabarMarca.Location = new System.Drawing.Point(245, 157);
            this.btnGrabarMarca.Name = "btnGrabarMarca";
            this.btnGrabarMarca.Size = new System.Drawing.Size(93, 51);
            this.btnGrabarMarca.TabIndex = 39;
            this.btnGrabarMarca.Text = "Grabar";
            this.btnGrabarMarca.UseVisualStyleBackColor = true;
            this.btnGrabarMarca.Click += new System.EventHandler(this.btnGrabarMarca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "MARCA";
            // 
            // txtMarcaIns
            // 
            this.txtMarcaIns.Location = new System.Drawing.Point(245, 70);
            this.txtMarcaIns.Name = "txtMarcaIns";
            this.txtMarcaIns.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaIns.TabIndex = 47;
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 220);
            this.Controls.Add(this.txtMarcaIns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.btnGrabarMarca);
            this.Name = "Marcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Button btnGrabarMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarcaIns;
    }
}