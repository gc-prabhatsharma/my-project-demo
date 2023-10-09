using C1.Win.C1Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDemoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var cnt = new C1TextBox() { Width = 100, Height = 30, Text="Custom" };
            this.Controls.Add(cnt);
        }
    }
}
