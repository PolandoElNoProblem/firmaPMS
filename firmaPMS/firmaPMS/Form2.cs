using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firmaPMS
{
    public partial class boczny : Form
    {
        public string nazwa = "";

        public boczny()
        {
            InitializeComponent();
        }

        private void form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = nazwa;
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            nazwa=textBox1.Text;
        }
    }
}
