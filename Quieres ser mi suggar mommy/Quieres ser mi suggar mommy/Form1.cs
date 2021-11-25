using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quieres_ser_mi_suggar_mommy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            panel2.Hide();
            btnSI.TabStop = false;
            btnNO.TabStop = false;
        }
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - btnNO.Width);
            int y = r.Next(0, this.Height - btnNO.Height);
            btnNO.Location = new Point(x, y);
        }

        private void btnNO_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (btnNO.Location == btnSI.Location || btnNO.Location == label1.Location)
            {
                MoverBoton();
            }
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
