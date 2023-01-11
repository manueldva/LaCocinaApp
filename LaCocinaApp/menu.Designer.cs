namespace LaCocinaApp
{
    partial class menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdclientes = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cmdclientes
            // 
            this.cmdclientes.Location = new System.Drawing.Point(-1, 1);
            this.cmdclientes.Name = "cmdclientes";
            this.cmdclientes.Size = new System.Drawing.Size(88, 59);
            this.cmdclientes.TabIndex = 0;
            this.cmdclientes.Text = "Gestion Clientes";
            this.cmdclientes.UseVisualStyleBackColor = true;
            this.cmdclientes.Click += new System.EventHandler(this.cmdclientes_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(93, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(705, 426);
            this.panelContenedor.TabIndex = 1;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.cmdclientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button cmdclientes;
        private Panel panelContenedor;
    }
}