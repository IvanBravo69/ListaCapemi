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
            this.btnVolverLiv = new System.Windows.Forms.Button();
            this.pbPesado = new System.Windows.Forms.PictureBox();
            this.dgArticulosPesado2 = new System.Windows.Forms.DataGridView();
            this.txtAtrasPes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulosPesado)).BeginInit();
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
            this.dgArticulosPesado.Location = new System.Drawing.Point(12, 108);
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
            this.dgArticulosPesado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgArticulosPesado.Size = new System.Drawing.Size(824, 299);
            this.dgArticulosPesado.TabIndex = 4;
            this.dgArticulosPesado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgArticulosPesado_CellContentClick);
            this.dgArticulosPesado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgArticulosPesado_KeyDown);
            this.dgArticulosPesado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgArticulosPesado_KeyUp);
            // 
            // btnVolverLiv
            // 
            this.btnVolverLiv.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverLiv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolverLiv.BackgroundImage")));
            this.btnVolverLiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverLiv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVolverLiv.FlatAppearance.BorderSize = 0;
            this.btnVolverLiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolverLiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolverLiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverLiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverLiv.Location = new System.Drawing.Point(742, 36);
            this.btnVolverLiv.Name = "btnVolverLiv";
            this.btnVolverLiv.Size = new System.Drawing.Size(52, 37);
            this.btnVolverLiv.TabIndex = 9;
            this.btnVolverLiv.UseVisualStyleBackColor = false;
            this.btnVolverLiv.Click += new System.EventHandler(this.btnVolverLiv_Click);
            this.btnVolverLiv.MouseLeave += new System.EventHandler(this.btnVolverLiv_MouseLeave);
            this.btnVolverLiv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnVolverLiv_MouseMove);
            // 
            // pbPesado
            // 
            this.pbPesado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPesado.Location = new System.Drawing.Point(627, 434);
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
            this.dgArticulosPesado2.Location = new System.Drawing.Point(12, 433);
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
            // txtAtrasPes
            // 
            this.txtAtrasPes.AutoSize = true;
            this.txtAtrasPes.BackColor = System.Drawing.Color.Transparent;
            this.txtAtrasPes.ForeColor = System.Drawing.Color.White;
            this.txtAtrasPes.Location = new System.Drawing.Point(742, 82);
            this.txtAtrasPes.Name = "txtAtrasPes";
            this.txtAtrasPes.Size = new System.Drawing.Size(49, 13);
            this.txtAtrasPes.TabIndex = 13;
            this.txtAtrasPes.Text = "..............";
            // 
            // frmListaPesados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(848, 625);
            this.Controls.Add(this.txtAtrasPes);
            this.Controls.Add(this.pbPesado);
            this.Controls.Add(this.dgArticulosPesado2);
            this.Controls.Add(this.btnVolverLiv);
            this.Controls.Add(this.dgArticulosPesado);
            this.Name = "frmListaPesados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaPesados";
            this.Load += new System.EventHandler(this.ListaPesados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulosPesado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulosPesado2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgArticulosPesado;
        private System.Windows.Forms.Button btnVolverLiv;
        private System.Windows.Forms.PictureBox pbPesado;
        private System.Windows.Forms.DataGridView dgArticulosPesado2;
        private System.Windows.Forms.Label txtAtrasPes;
    }
}