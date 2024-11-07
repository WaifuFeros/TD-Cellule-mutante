using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TD_Cellule_mutante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnl_cell_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.pnl_cell.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Black);
            g.FillEllipse(myBrush, 120, 130, 20, 20);
            myBrush.Dispose();
            g.Dispose();
        }

        private void btn_simulation_Click(object sender, EventArgs e)
        {
            
        }
    }
}
