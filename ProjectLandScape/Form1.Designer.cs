namespace ProjectLandScape
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajNowyObiektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyObiektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znajdźObiektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utwórzOSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narzędziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokalizacjaObiektuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNowyObiektToolStripMenuItem,
            this.narzędziaToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.pomocToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajNowyObiektToolStripMenuItem
            // 
            this.dodajNowyObiektToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyObiektToolStripMenuItem,
            this.znajdźObiektToolStripMenuItem,
            this.utwórzOSDToolStripMenuItem});
            this.dodajNowyObiektToolStripMenuItem.Name = "dodajNowyObiektToolStripMenuItem";
            this.dodajNowyObiektToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.dodajNowyObiektToolStripMenuItem.Text = "Obiekt";
            // 
            // nowyObiektToolStripMenuItem
            // 
            this.nowyObiektToolStripMenuItem.Name = "nowyObiektToolStripMenuItem";
            this.nowyObiektToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.nowyObiektToolStripMenuItem.Text = "Nowy obiekt";
            // 
            // znajdźObiektToolStripMenuItem
            // 
            this.znajdźObiektToolStripMenuItem.Name = "znajdźObiektToolStripMenuItem";
            this.znajdźObiektToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.znajdźObiektToolStripMenuItem.Text = "Znajdź obiekt";
            // 
            // utwórzOSDToolStripMenuItem
            // 
            this.utwórzOSDToolStripMenuItem.Name = "utwórzOSDToolStripMenuItem";
            this.utwórzOSDToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.utwórzOSDToolStripMenuItem.Text = "Utwórz OSD";
            // 
            // narzędziaToolStripMenuItem
            // 
            this.narzędziaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lokalizacjaObiektuToolStripMenuItem,
            this.zarzToolStripMenuItem});
            this.narzędziaToolStripMenuItem.Name = "narzędziaToolStripMenuItem";
            this.narzędziaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narzędziaToolStripMenuItem.Text = "Narzędzia";
            // 
            // lokalizacjaObiektuToolStripMenuItem
            // 
            this.lokalizacjaObiektuToolStripMenuItem.Name = "lokalizacjaObiektuToolStripMenuItem";
            this.lokalizacjaObiektuToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.lokalizacjaObiektuToolStripMenuItem.Text = "Lokalizacja obiektu";
            // 
            // zarzToolStripMenuItem
            // 
            this.zarzToolStripMenuItem.Name = "zarzToolStripMenuItem";
            this.zarzToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.zarzToolStripMenuItem.Text = "Zarzadzanie terem";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.pomocToolStripMenuItem.Text = "Finanse";
            // 
            // pomocToolStripMenuItem1
            // 
            this.pomocToolStripMenuItem1.Name = "pomocToolStripMenuItem1";
            this.pomocToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem1.Text = "Pomoc";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Project LandScape - 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajNowyObiektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyObiektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem znajdźObiektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utwórzOSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narzędziaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokalizacjaObiektuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

