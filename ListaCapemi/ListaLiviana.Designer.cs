namespace ListaCapemi
{
    partial class frmListaLiviana
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
            System.Windows.Forms.Button btnVolverLiv;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaLiviana));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgArticulos = new System.Windows.Forms.DataGridView();
            this.dgArticulos2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbA = new System.Windows.Forms.PictureBox();
            this.lblBoton = new System.Windows.Forms.Label();
            btnVolverLiv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverLiv
            // 
            btnVolverLiv.BackColor = System.Drawing.Color.Transparent;
            btnVolverLiv.FlatAppearance.BorderSize = 0;
            btnVolverLiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            btnVolverLiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            btnVolverLiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVolverLiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnVolverLiv.ForeColor = System.Drawing.Color.Transparent;
            btnVolverLiv.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverLiv.Image")));
            btnVolverLiv.Location = new System.Drawing.Point(739, 44);
            btnVolverLiv.Name = "btnVolverLiv";
            btnVolverLiv.Size = new System.Drawing.Size(61, 58);
            btnVolverLiv.TabIndex = 2;
            btnVolverLiv.UseVisualStyleBackColor = false;
            btnVolverLiv.Click += new System.EventHandler(this.btnVolverLiv_Click);
            btnVolverLiv.MouseLeave += new System.EventHandler(this.btnVolverLiv_MouseLeave);
            btnVolverLiv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnVolverLiv_MouseMove);
            // 
            // dgArticulos
            // 
            this.dgArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgArticulos.ColumnHeadersHeight = 20;
            this.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgArticulos.EnableHeadersVisualStyles = false;
            this.dgArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgArticulos.Location = new System.Drawing.Point(13, 129);
            this.dgArticulos.Name = "dgArticulos";
            this.dgArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgArticulos.RowHeadersVisible = false;
            this.dgArticulos.RowHeadersWidth = 30;
            this.dgArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgArticulos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgArticulos.RowTemplate.Height = 20;
            this.dgArticulos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgArticulos.ShowCellErrors = false;
            this.dgArticulos.Size = new System.Drawing.Size(824, 299);
            this.dgArticulos.TabIndex = 3;
            this.dgArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgArticulos_CellContentClick);
            this.dgArticulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgArticulos_KeyDown);
            this.dgArticulos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgArticulos_KeyUp);
            // 
            // dgArticulos2
            // 
            this.dgArticulos2.BackgroundColor = System.Drawing.Color.White;
            this.dgArticulos2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgArticulos2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgArticulos2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgArticulos2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgArticulos2.ColumnHeadersHeight = 20;
            this.dgArticulos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgArticulos2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgArticulos2.EnableHeadersVisualStyles = false;
            this.dgArticulos2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgArticulos2.Location = new System.Drawing.Point(13, 434);
            this.dgArticulos2.Name = "dgArticulos2";
            this.dgArticulos2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgArticulos2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgArticulos2.RowHeadersVisible = false;
            this.dgArticulos2.RowHeadersWidth = 100;
            this.dgArticulos2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgArticulos2.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgArticulos2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgArticulos2.RowTemplate.Height = 70;
            this.dgArticulos2.RowTemplate.ReadOnly = true;
            this.dgArticulos2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgArticulos2.Size = new System.Drawing.Size(609, 174);
            this.dgArticulos2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 7;
            // 
            // pbA
            // 
            this.pbA.BackColor = System.Drawing.Color.Transparent;
            this.pbA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbA.Location = new System.Drawing.Point(628, 434);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(209, 174);
            this.pbA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbA.TabIndex = 8;
            this.pbA.TabStop = false;
            // 
            // lblBoton
            // 
            this.lblBoton.AutoSize = true;
            this.lblBoton.BackColor = System.Drawing.Color.Transparent;
            this.lblBoton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBoton.Location = new System.Drawing.Point(756, 102);
            this.lblBoton.Name = "lblBoton";
            this.lblBoton.Size = new System.Drawing.Size(40, 13);
            this.lblBoton.TabIndex = 9;
            this.lblBoton.Text = "...........";
            // 
            // frmListaLiviana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ListaCapemi.Properties.Resources.Fondo2;
            this.ClientSize = new System.Drawing.Size(849, 617);
            this.Controls.Add(this.lblBoton);
            this.Controls.Add(this.pbA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgArticulos2);
            this.Controls.Add(this.dgArticulos);
            this.Controls.Add(btnVolverLiv);
            this.Name = "frmListaLiviana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaLiviana";
            this.Load += new System.EventHandler(this.ListaLiviana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
       
        private System.Windows.Forms.DataGridView dgArticulos;
        private System.Windows.Forms.DataGridView dgArticulos2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbA;
        private System.Windows.Forms.Label lblBoton;
    }
}