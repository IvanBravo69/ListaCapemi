namespace ListaCapemi
{
    partial class frmLanzamientos
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
            System.Windows.Forms.Button btnVolverLanza;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLanzamientos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtLanza = new System.Windows.Forms.DataGridView();
            this.dtLanza1 = new System.Windows.Forms.DataGridView();
            this.pbLanza = new System.Windows.Forms.PictureBox();
            this.txtVolver = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegis = new System.Windows.Forms.Label();
            btnVolverLanza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtLanza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLanza1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanza)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverLanza
            // 
            btnVolverLanza.BackColor = System.Drawing.Color.Transparent;
            btnVolverLanza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolverLanza.BackgroundImage")));
            btnVolverLanza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnVolverLanza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnVolverLanza.FlatAppearance.BorderSize = 0;
            btnVolverLanza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnVolverLanza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnVolverLanza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVolverLanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnVolverLanza.ForeColor = System.Drawing.Color.Transparent;
            btnVolverLanza.Location = new System.Drawing.Point(723, 35);
            btnVolverLanza.Name = "btnVolverLanza";
            btnVolverLanza.Size = new System.Drawing.Size(61, 34);
            btnVolverLanza.TabIndex = 3;
            btnVolverLanza.UseVisualStyleBackColor = false;
            btnVolverLanza.Click += new System.EventHandler(this.btnVolverLanza_Click);
            btnVolverLanza.MouseLeave += new System.EventHandler(this.btnVolverLanza_MouseLeave);
            btnVolverLanza.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnVolverLanza_MouseMove);
            // 
            // dtLanza
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtLanza.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtLanza.BackgroundColor = System.Drawing.Color.White;
            this.dtLanza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtLanza.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtLanza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtLanza.ColumnHeadersHeight = 20;
            this.dtLanza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtLanza.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtLanza.EnableHeadersVisualStyles = false;
            this.dtLanza.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtLanza.Location = new System.Drawing.Point(5, 109);
            this.dtLanza.MultiSelect = false;
            this.dtLanza.Name = "dtLanza";
            this.dtLanza.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtLanza.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtLanza.RowHeadersVisible = false;
            this.dtLanza.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.dtLanza.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtLanza.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtLanza.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLanza.RowTemplate.Height = 20;
            this.dtLanza.RowTemplate.ReadOnly = true;
            this.dtLanza.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtLanza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLanza.Size = new System.Drawing.Size(809, 323);
            this.dtLanza.TabIndex = 0;
            this.dtLanza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLanza_CellContentClick);
            this.dtLanza.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtLanza_KeyDown);
            this.dtLanza.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtLanza_KeyUp);
            // 
            // dtLanza1
            // 
            this.dtLanza1.BackgroundColor = System.Drawing.Color.White;
            this.dtLanza1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtLanza1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtLanza1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtLanza1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtLanza1.ColumnHeadersHeight = 20;
            this.dtLanza1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtLanza1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtLanza1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtLanza1.Location = new System.Drawing.Point(5, 457);
            this.dtLanza1.Name = "dtLanza1";
            this.dtLanza1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtLanza1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtLanza1.RowHeadersVisible = false;
            this.dtLanza1.RowHeadersWidth = 100;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLanza1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtLanza1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtLanza1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLanza1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtLanza1.RowTemplate.Height = 70;
            this.dtLanza1.RowTemplate.ReadOnly = true;
            this.dtLanza1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtLanza1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtLanza1.Size = new System.Drawing.Size(583, 175);
            this.dtLanza1.TabIndex = 1;
            // 
            // pbLanza
            // 
            this.pbLanza.BackColor = System.Drawing.Color.Transparent;
            this.pbLanza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLanza.Location = new System.Drawing.Point(594, 457);
            this.pbLanza.Name = "pbLanza";
            this.pbLanza.Size = new System.Drawing.Size(220, 175);
            this.pbLanza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLanza.TabIndex = 2;
            this.pbLanza.TabStop = false;
            // 
            // txtVolver
            // 
            this.txtVolver.AutoSize = true;
            this.txtVolver.BackColor = System.Drawing.Color.Transparent;
            this.txtVolver.ForeColor = System.Drawing.Color.White;
            this.txtVolver.Location = new System.Drawing.Point(736, 72);
            this.txtVolver.Name = "txtVolver";
            this.txtVolver.Size = new System.Drawing.Size(46, 13);
            this.txtVolver.TabIndex = 11;
            this.txtVolver.Text = ".............";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(672, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "registros encontrados ";
            // 
            // txtRegis
            // 
            this.txtRegis.AutoSize = true;
            this.txtRegis.BackColor = System.Drawing.Color.White;
            this.txtRegis.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegis.Location = new System.Drawing.Point(656, 435);
            this.txtRegis.Name = "txtRegis";
            this.txtRegis.Size = new System.Drawing.Size(14, 16);
            this.txtRegis.TabIndex = 13;
            this.txtRegis.Text = "..";
            // 
            // frmLanzamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 644);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegis);
            this.Controls.Add(this.txtVolver);
            this.Controls.Add(btnVolverLanza);
            this.Controls.Add(this.pbLanza);
            this.Controls.Add(this.dtLanza1);
            this.Controls.Add(this.dtLanza);
            this.Name = "frmLanzamientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lanzamientos";
            this.Load += new System.EventHandler(this.Lanzamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLanza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLanza1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtLanza;
        private System.Windows.Forms.DataGridView dtLanza1;
        private System.Windows.Forms.PictureBox pbLanza;
        private System.Windows.Forms.Label txtVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtRegis;
    }
}