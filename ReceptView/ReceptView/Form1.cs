using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WriteToFile w = new WriteToFile();
            w.Write();
        }
    }
}
