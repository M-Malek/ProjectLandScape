using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLandScape
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string name, surname, password, re_password, email;
            name = textBoxName.Text;
            surname = textBoxSurname.Text;
            password = textBoxPassword.Text;
            re_password = textBoxPasswordCheck.Text;
            email = textBoxName.Text;

            bool license_accepted = checkBoxAccLicense.Checked;

            if (password == re_password && license_accepted)
            {
                User user = new User(name, surname, email, password, 0);
                user.registerUser();
                this.Close();
            }

        }
    }
}
