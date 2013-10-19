using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConvertPDFToText
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
            textBox1.Select(0, 0);
        }
        
        private void help_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
