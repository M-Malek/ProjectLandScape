using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectLandScape.Properties;

namespace ProjectLandScape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStripLoader() 
        {
            ObjectToolStripMenuItem.Text = en_EN.Default.menuStripObject;
            toolsToolStripMenuItem.Text = en_EN.Default.menuStripTools;
            financeToolStripMenuItem.Text = en_EN.Default.menuStripFinance;
            helpToolStripMenuItem.Text = en_EN.Default.menuStripHelp;
            generatorProjektówToolStripMenuItem.Text = en_EN.Default.menuStripGenerator;
        }

        private void greetingsLoader()
        {
            StartWindow startWindow = new StartWindow();
            int window_height = (int)(Size.Height * 0.5) - (int)(startWindow.Height * 0.5);
            int window_width = (int)(Size.Width * 0.5) - (int)(startWindow.Width * 0.5);
            startWindow.Location = new Point(window_width, window_height);
            startWindow.Parent = this;

            

            menuStrip1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStripLoader();
            greetingsLoader();
            
        }

    }
}
