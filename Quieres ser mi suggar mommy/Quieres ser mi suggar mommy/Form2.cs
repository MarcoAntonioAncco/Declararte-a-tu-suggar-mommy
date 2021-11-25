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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvendida perry" + "\n" + "El programa es una simple pregunta" + "\n" +
                "Deberas contestarla presionando si o no, pensando bien" + "\n" + "Por que es algo serio.");
            MessageBox.Show("Por favor intentelo de nuevo"+"\n"+"aaaaaaaaaaaiuda. Sintax error"+"\n"+"Presione reintentar", "Alert.", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
            //-----------------------------------------------------------------------------------------
            MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
            DialogResult dr = MessageBox.Show("OJO!" + "\n" + "El programa presenta una dinamica muy particular con la intension de que gane el programador" + "\n" +
                "asi que se recomienda pensar antes de dar comenzar al programa" + "\n" + "............" + "\n" + "¿Estas lista?", "gaaaaa", botones, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)

                MessageBox.Show("Presiona Comenzar chiquita y preparate UwU");

            else if (dr == DialogResult.No)
                MessageBox.Show("Aunque NO quieras tendras que presionar comenzar"+"\n"+"Esta diseñado para que no puedas cerrar el programa."+"\n"+
                    "\n"+ "⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️", "Advertencia ⚠️");
                
            
            else MessageBox.Show("aaaa, No te importo? :,v"+"\n"+"Dale comenzar ");
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            Form1 form1=new Form1();
            form1.Show();
        }
    }
}
