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
    public partial class StartWindow : UserControl
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void StartWindow_Load(object sender, EventArgs e)
        {
            listBoxNews.Items.Add(en_EN.Default.listBoxNews);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            UserRegister userRegister = new UserRegister();
            userRegister.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User user = new User("", "", tbLoginEmail.Text, tbLoginPassword.Text, 0);
            user.logInUser();
        }
    }
}
