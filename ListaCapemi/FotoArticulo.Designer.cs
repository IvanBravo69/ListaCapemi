namespace ListaCapemi
{
    partial class FotoArticulo
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
            this.dgFotoArt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgFotoArt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFotoArt
            // 
            this.dgFotoArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFotoArt.Location = new System.Drawing.Point(12, 32);
            this.dgFotoArt.Name = "dgFotoArt";
            this.dgFotoArt.Size = new System.Drawing.Size(351, 206);
            this.dgFotoArt.TabIndex = 0;
            this.dgFotoArt.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgFotoArt_CellFormatting);
            // 
            // FotoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 267);
            this.Controls.Add(this.dgFotoArt);
            this.Name = "FotoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FotoArticulo";
            this.Load += new System.EventHandler(this.FotoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFotoArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFotoArt;
    }
}