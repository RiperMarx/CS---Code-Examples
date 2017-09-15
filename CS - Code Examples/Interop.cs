using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CS___Code_Examples
{
    public partial class Interop : Form
    {
        public Interop()
        {
            InitializeComponent();
        }

        private void Interop_Load(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
        }
    }
}
