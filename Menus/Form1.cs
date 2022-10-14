using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();//Cierra tu app
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa fue creado por Diana Ponce","Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            label1.ForeColor = Color.Red;
            rojoToolStripMenuItem.Checked = true;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            label1.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }

        private void borrarColor()
        {
            rojoToolStripMenuItem.Checked = false;
            azulToolStripMenuItem.Checked = false;
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicSansToolStripMenuItem.Checked = false;
            label1.Font = new Font("Times New Roman", 14, label1.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = true;
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicSansToolStripMenuItem.Checked = true;
            label1.Font = new Font("Comic Sans Ms", 20, label1.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = false;
        }
    }
}
