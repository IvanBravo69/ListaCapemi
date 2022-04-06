namespace ListaCapemi
{
    partial class frmListaPesados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaPesados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgArticulosPesado = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVolverLiv = new System.Windows.Forms.Button();
            this.pbPesado = new System.Windows.Forms.PictureBox();
            this.dgArticulosPesado2 = new System.Windows.Forms.DataGridView();
            this.txtPesado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulosPesado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulosPesado2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgArticulosPesado
            // 
            this.dgArticulosPesado.BackgroundColor = System.Drawing.Color.White;
            this.dgArticulosPesado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgArticulosPesado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgArticulosPesado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgArticulosPesado.ColumnHeadersHeight = 20;
            this.dgArticulosPesado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgArticulosPesado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgArticulosPesado.EnableHeadersVisualStyles = false;
            this.dgArticulosPesado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgArticulosPesado.Location = new System.Drawing.Point(12, 125);
            this.dgArticulosPesado.Name = "dgArticulosPesado";
            this.dgArticulosPesado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgArticulosPesado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgArticulosPesado.RowHeadersVisible = false;
            this.dgArticulosPesado.RowHeadersWidth = 30;
            this.dgArticulosPesado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgArticulosPesado.RowTemplate.Height = 20;
            this.dgArticulosPesado.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgArticulosPesado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgArticulosPesado.Size = new System.Drawing.Size(824, 299);
            this.dgArticulosPesado.TabIndex = 4;
            this.dgArticulosPesado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgArticulosPesado_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnVolverLiv
            // 
            this.btnVolverLiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverLiv.Location = new System.Drawing.Point(693, 32);
            this.btnVolverLiv.Name = "btnVolverLiv";
            this.btnVolverLiv.Size = new System.Drawing.Size(131, 58);
            this.btnVolverLiv.TabIndex = 9;
            this.btnVolverLiv.Text = "Atras";
            this.btnVolverLiv.UseVisualStyleBackColor = true;
            this.btnVolverLiv.Click += new System.EventHandler(this.btnVolverLiv_Click);
            // 
            // pbPesado
            // 
            this.pbPesado.Location = new System.Drawing.Point(627, 439);
            this.pbPesado.Name = "pbPesado";
            this.pbPesado.Size = new System.Drawing.Size(209, 174);
            this.pbPesado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPesado.TabIndex = 11;
            this.pbPesado.TabStop = false;
            // 
            // dgArticulosPesado2
            // 
            this.dgArticulosPesado2.BackgroundColor = System.Drawing.Color.White;
            this.dgArticulosPesado2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgArticulosPesado2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgArticulosPesado2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgArticulosPesado2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgArticulosPesado2.ColumnHeadersHeight = 20;
            this.dgArticulosPesado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgArticulosPesado2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgArticulosPesado2.EnableHeadersVisualStyles = false;
            this.dgArticulosPesado2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgArticulosPesado2.Location = new System.Drawing.Point(12, 439);
            this.dgArticulosPesado2.Name = "dgArticulosPesado2";
            this.dgArticulosPesado2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgArticulosPesado2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgArticulosPesado2.RowHeadersVisible = false;
            this.dgArticulosPesado2.RowHeadersWidth = 100;
            this.dgArticulosPesado2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgArticulosPesado2.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgArticulosPesado2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgArticulosPesado2.RowTemplate.Height = 70;
            this.dgArticulosPesado2.RowTemplate.ReadOnly = true;
            this.dgArticulosPesado2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgArticulosPesado2.Size = new System.Drawing.Size(609, 174);
            this.dgArticulosPesado2.TabIndex = 10;
            // 
            // txtPesado
            // 
            this.txtPesado.Location = new System.Drawing.Point(264, 47);
            this.txtPesado.Name = "txtPesado";
            this.txtPesado.Size = new System.Drawing.Size(100, 20);
            this.txtPesado.TabIndex = 12;
            // 
            // frmListaPesados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 625);
            this.Controls.Add(this.txtPesado);
            this.Controls.Add(this.pbPesado);
            this.Controls.Add(this.dgArticulosPesado2);
            this.Controls.Add(this.btnVolverLiv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgArticulosPesado);
            this.Name = "frmListaPesados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaPesados";
            this.Load += new System.EventHandler(this.ListaPesados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulosPesado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulosPesado2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgArticulosPesado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVolverLiv;
        private System.Windows.Forms.PictureBox pbPesado;
        private System.Windows.Forms.DataGridView dgArticulosPesado2;
        private System.Windows.Forms.TextBox txtPesado;
    }
}