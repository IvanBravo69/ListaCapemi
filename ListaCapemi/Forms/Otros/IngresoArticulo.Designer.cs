namespace ListaCapemi
{
    partial class frmIngresoArticulo
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLargoE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiamI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiamE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLargoI = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pbIngresoArticulo = new System.Windows.Forms.PictureBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.dtgIngreso = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngresoArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Location = new System.Drawing.Point(107, 389);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 44);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CODIGO :";
            // 
            // txtCod
            // 
            this.txtCod.AccessibleDescription = "";
            this.txtCod.AccessibleName = "";
            this.txtCod.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.txtCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.ForeColor = System.Drawing.Color.Black;
            this.txtCod.Location = new System.Drawing.Point(107, 71);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(107, 20);
            this.txtCod.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Location = new System.Drawing.Point(107, 104);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(107, 20);
            this.txtDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESCRIPCION :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LANZAMIENTO :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CATEGORIA :";
            // 
            // txtOem
            // 
            this.txtOem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOem.Location = new System.Drawing.Point(107, 138);
            this.txtOem.Name = "txtOem";
            this.txtOem.Size = new System.Drawing.Size(107, 20);
            this.txtOem.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "OEM :";
            // 
            // txtLargoE
            // 
            this.txtLargoE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLargoE.Location = new System.Drawing.Point(390, 148);
            this.txtLargoE.Name = "txtLargoE";
            this.txtLargoE.Size = new System.Drawing.Size(97, 20);
            this.txtLargoE.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "LARGO EXT :";
            // 
            // txtDiamI
            // 
            this.txtDiamI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiamI.Location = new System.Drawing.Point(390, 107);
            this.txtDiamI.Name = "txtDiamI";
            this.txtDiamI.Size = new System.Drawing.Size(97, 20);
            this.txtDiamI.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "DIAMENTRO INT :";
            // 
            // txtDiamE
            // 
            this.txtDiamE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiamE.Location = new System.Drawing.Point(390, 66);
            this.txtDiamE.Name = "txtDiamE";
            this.txtDiamE.Size = new System.Drawing.Size(97, 20);
            this.txtDiamE.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "DIAMETRO EX :";
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.Location = new System.Drawing.Point(107, 277);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(107, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "MODELO :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "MARCA :";
            // 
            // txtAño
            // 
            this.txtAño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAño.Location = new System.Drawing.Point(107, 311);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(107, 20);
            this.txtAño.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "AÑO :";
            // 
            // txtLargoI
            // 
            this.txtLargoI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLargoI.Location = new System.Drawing.Point(390, 189);
            this.txtLargoI.Name = "txtLargoI";
            this.txtLargoI.Size = new System.Drawing.Size(97, 20);
            this.txtLargoI.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "LARGO INT :";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Location = new System.Drawing.Point(107, 345);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(107, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "PRECIO :";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(334, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "FOTO :";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(390, 230);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 14;
            // 
            // btnFoto
            // 
            this.btnFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFoto.Location = new System.Drawing.Point(390, 271);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(97, 22);
            this.btnFoto.TabIndex = 15;
            this.btnFoto.Text = "Buscar Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pbIngresoArticulo
            // 
            this.pbIngresoArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbIngresoArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.pbIngresoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIngresoArticulo.Location = new System.Drawing.Point(337, 311);
            this.pbIngresoArticulo.Name = "pbIngresoArticulo";
            this.pbIngresoArticulo.Size = new System.Drawing.Size(150, 122);
            this.pbIngresoArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIngresoArticulo.TabIndex = 31;
            this.pbIngresoArticulo.TabStop = false;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(107, 172);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(107, 21);
            this.cboCategoria.TabIndex = 4;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // cboGrupo
            // 
            this.cboGrupo.BackColor = System.Drawing.Color.White;
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(107, 207);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(107, 21);
            this.cboGrupo.TabIndex = 5;
            this.cboGrupo.SelectedIndexChanged += new System.EventHandler(this.cboGrupo_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "GRUPO :";
            // 
            // cboMarca
            // 
            this.cboMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(107, 242);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(107, 21);
            this.cboMarca.TabIndex = 6;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarMarca.Location = new System.Drawing.Point(220, 241);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(22, 24);
            this.btnAgregarMarca.TabIndex = 39;
            this.btnAgregarMarca.Text = "+";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // dtgIngreso
            // 
            this.dtgIngreso.AllowUserToResizeRows = false;
            this.dtgIngreso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgIngreso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgIngreso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgIngreso.EnableHeadersVisualStyles = false;
            this.dtgIngreso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgIngreso.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgIngreso.Location = new System.Drawing.Point(13, 448);
            this.dtgIngreso.Name = "dtgIngreso";
            this.dtgIngreso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIngreso.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgIngreso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgIngreso.Size = new System.Drawing.Size(524, 135);
            this.dtgIngreso.TabIndex = 40;
            // 
            // frmIngresoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 595);
            this.Controls.Add(this.dtgIngreso);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.cboGrupo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.pbIngresoArticulo);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLargoI);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLargoE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiamI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiamE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmIngresoArticulo";
            this.Text = "Ingreso Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.pbIngresoArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLargoE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiamI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiamE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLargoI;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pbIngresoArticulo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private MetroFramework.Controls.MetroGrid dtgIngreso;
    }
}