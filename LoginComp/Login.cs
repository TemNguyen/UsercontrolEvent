using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginComp
{
    public partial class Login : UserControl
    {
        public event EventHandler btnLoginClick;
        public event EventHandler btnExitClick;
        public event EventHandler tbUsernameChange;
        public event EventHandler comboBox1SelectedIndexChange;
        public string username
        {
            get
            {
                return tbUsername.Text;
            }
            set
            {
                tbUsername.Text = value;
            }
        }
        public string password
        {
            get
            {
                return tbPassword.Text;
            }
            set
            {
                tbPassword.Text = value;
            }
        }
        public List<object> comboBox
        {
            get
            {
                List<object> list = new List<object>();
                foreach(var item in comboBox1.Items)
                {
                    list.Add(item);
                }
                return list;
            }
            set
            {
                comboBox = value;
            }
        }
        public string tb1
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = comboBox1.SelectedItem.ToString();
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLoginClick?.Invoke(this, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExitClick?.Invoke(this, e);
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            tbUsernameChange?.Invoke(this, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1SelectedIndexChange?.Invoke(this, e);
        }
    }
}
