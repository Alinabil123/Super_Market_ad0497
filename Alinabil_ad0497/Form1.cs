using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alinabil_ad0497
{
    public partial class Form1 : Form
    {
        private List<user> users = new List<user>();
        public Form1()
        {
            InitializeComponent();

            user use1 = new user("ali","111");
            users.Add(use1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            foreach(user user in users)
            {
               if (username == user.username && password == user.password)
                {
                    Form1 frm = new Form1();
                    frm.Show();
                }
            }
        }
    }
}
