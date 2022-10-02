namespace ListaCapemi.Forms.Listas
{
    partial class ListaBusqueda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaBusqueda));
            this.dgArticulosBusqueda = new System.Windows.Forms.DataGridView();
            this.dgArticuloBusqueda2 = new System.Windows.Forms.DataGridView();
            this.pbusqueda = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulosBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticuloBusqueda2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgArticulosBusqueda
            // 
            this.dgArticulosBusqueda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgArticulosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArticulosBusqueda.Location = new System.Drawing.Point(1, 120);
            this.dgArticulosBusqueda.Name = "dgArticulosBusqueda";
            this.dgArticulosBusqueda.Size = new System.Drawing.Size(845, 297);
            this.dgArticulosBusqueda.TabIndex = 0;
            // 
            // dgArticuloBusqueda2
            // 
            this.dgArticuloBusqueda2.BackgroundColor = System.Drawing.Color.White;
            this.dgArticuloBusqueda2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArticuloBusqueda2.Location = new System.Drawing.Point(1, 408);
            this.dgArticuloBusqueda2.Name = "dgArticuloBusqueda2";
            this.dgArticuloBusqueda2.Size = new System.Drawing.Size(620, 182);
            this.dgArticuloBusqueda2.TabIndex = 1;
            // 
            // pbusqueda
            // 
            this.pbusqueda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbusqueda.Location = new System.Drawing.Point(627, 408);
            this.pbusqueda.Name = "pbusqueda";
            this.pbusqueda.Size = new System.Drawing.Size(219, 182);
            this.pbusqueda.TabIndex = 2;
            this.pbusqueda.TabStop = false;
            // 
            // ListaBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(847, 591);
            this.Controls.Add(this.pbusqueda);
            this.Controls.Add(this.dgArticuloBusqueda2);
            this.Controls.Add(this.dgArticulosBusqueda);
            this.Name = "ListaBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaBusqueda";
            this.Load += new System.EventHandler(this.ListaBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulosBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticuloBusqueda2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgArticulosBusqueda;
        private System.Windows.Forms.DataGridView dgArticuloBusqueda2;
        private System.Windows.Forms.PictureBox pbusqueda;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}