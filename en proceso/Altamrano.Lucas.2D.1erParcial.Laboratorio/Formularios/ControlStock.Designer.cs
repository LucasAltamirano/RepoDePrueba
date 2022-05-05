
namespace Formularios
{
    partial class ControlStock
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
            this.lstBoxListaProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBoxListaProductos
            // 
            this.lstBoxListaProductos.FormattingEnabled = true;
            this.lstBoxListaProductos.ItemHeight = 15;
            this.lstBoxListaProductos.Location = new System.Drawing.Point(125, 78);
            this.lstBoxListaProductos.Name = "lstBoxListaProductos";
            this.lstBoxListaProductos.Size = new System.Drawing.Size(120, 94);
            this.lstBoxListaProductos.TabIndex = 0;
            // 
            // ControlStock
            // 
            this.ClientSize = new System.Drawing.Size(407, 261);
            this.Controls.Add(this.lstBoxListaProductos);
            this.Name = "ControlStock";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.ControlStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.ListBox lstBoxListaProductos;
       // private System.Windows.Forms.Label lblListaProductos;
        private System.Windows.Forms.ListBox lstBoxListaProductos;
    }
}