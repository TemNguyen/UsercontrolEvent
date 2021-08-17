using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler Button1_Click;
        public event EventHandler TextBox1_TextChanged;
        public event EventHandler ComboBox1_SelectedIndexChanged;

        public string textBox1_Text
        {
            get
            {
                return textBox1.Text;
            }
            private set
            { }
        }
        public string comboBox1_SelectedItem
        {
            get
            {
                return ((CBBItems)comboBox1.SelectedItem).Name;
            }
            private set { }
        }
        public UserControl1()
        {
            InitializeComponent();
            SetCBB();
        }
        void SetCBB()
        {
            comboBox1.Items.AddRange(new CBBItems[]
            {
                new CBBItems {Name = "HaNoi"},
                new CBBItems {Name = "Hue"},
                new CBBItems {Name = "SaiGon"},
            });
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Button1_Click != null)
                Button1_Click.Invoke(this, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox1_TextChanged?.Invoke(this, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox1_SelectedIndexChanged?.Invoke(this, e);
        }
    }
}
