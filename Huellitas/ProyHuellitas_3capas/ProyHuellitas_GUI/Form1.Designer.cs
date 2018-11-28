namespace ProyHuellitas_GUI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoVeterinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoVeterinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoClienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoClienteToolStripMenuItem
            // 
            this.mantenimientoClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoVeterinariaToolStripMenuItem,
            this.mantenimientoVeterinarioToolStripMenuItem,
            this.mantenimientoClienteToolStripMenuItem1});
            this.mantenimientoClienteToolStripMenuItem.Name = "mantenimientoClienteToolStripMenuItem";
            this.mantenimientoClienteToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.mantenimientoClienteToolStripMenuItem.Text = "Ver";
            this.mantenimientoClienteToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoClienteToolStripMenuItem_Click);
            // 
            // mantenimientoVeterinariaToolStripMenuItem
            // 
            this.mantenimientoVeterinariaToolStripMenuItem.Name = "mantenimientoVeterinariaToolStripMenuItem";
            this.mantenimientoVeterinariaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.mantenimientoVeterinariaToolStripMenuItem.Text = "Mantenimiento Veterinaria";
            this.mantenimientoVeterinariaToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoVeterinariaToolStripMenuItem_Click);
            // 
            // mantenimientoVeterinarioToolStripMenuItem
            // 
            this.mantenimientoVeterinarioToolStripMenuItem.Name = "mantenimientoVeterinarioToolStripMenuItem";
            this.mantenimientoVeterinarioToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.mantenimientoVeterinarioToolStripMenuItem.Text = "Mantenimiento Veterinario";
            this.mantenimientoVeterinarioToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoVeterinarioToolStripMenuItem_Click);
            // 
            // mantenimientoClienteToolStripMenuItem1
            // 
            this.mantenimientoClienteToolStripMenuItem1.Name = "mantenimientoClienteToolStripMenuItem1";
            this.mantenimientoClienteToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.mantenimientoClienteToolStripMenuItem1.Text = "Mantenimiento Cliente";
            this.mantenimientoClienteToolStripMenuItem1.Click += new System.EventHandler(this.mantenimientoClienteToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoVeterinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoVeterinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClienteToolStripMenuItem1;
    }
}

