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
            this.ObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyObiektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znajdźObiektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utwórzOSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokalizacjaObiektuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatorProjektówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ObjectToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.financeToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.generatorProjektówToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ObjectToolStripMenuItem
            // 
            this.ObjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyObiektToolStripMenuItem,
            this.znajdźObiektToolStripMenuItem,
            this.utwórzOSDToolStripMenuItem});
            this.ObjectToolStripMenuItem.Name = "ObjectToolStripMenuItem";
            this.ObjectToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ObjectToolStripMenuItem.Text = "Obiekt";
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
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lokalizacjaObiektuToolStripMenuItem,
            this.zarzToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.toolsToolStripMenuItem.Text = "Narzędzia";
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
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.financeToolStripMenuItem.Text = "Finanse";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "Pomoc";
            // 
            // generatorProjektówToolStripMenuItem
            // 
            this.generatorProjektówToolStripMenuItem.Name = "generatorProjektówToolStripMenuItem";
            this.generatorProjektówToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.generatorProjektówToolStripMenuItem.Text = "Generator projektów";
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
        private System.Windows.Forms.ToolStripMenuItem ObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyObiektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem znajdźObiektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utwórzOSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokalizacjaObiektuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generatorProjektówToolStripMenuItem;
    }
}

