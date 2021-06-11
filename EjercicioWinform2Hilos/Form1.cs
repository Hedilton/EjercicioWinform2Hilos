using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EjercicioWinform2Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread x = new Thread(metodo1);
            Thread y = new Thread(metodo2);
            x.Start();y.Start();

        }
        private void metodo1()
        {
            for(int i=1;i<=10;i++)
            {
                picture.BackColor = Color.Red;
                Thread.Sleep(500);
                picture.BackColor = Color.Green;
                Thread.Sleep(200);
                picture.BackColor = Color.Blue;
                Thread.Sleep(300);
                picture.BackColor = Color.Black;
                Thread.Sleep(100);

            }
        }
        private void metodo2()
        {
            for (int i = 1; i <= 10; i++)
            {
                picture2.BackColor = Color.Yellow;
                Thread.Sleep(300);
                picture2.BackColor = Color.BlueViolet;
                Thread.Sleep(100);
                picture2.BackColor = Color.DeepSkyBlue;
                Thread.Sleep(200);
                picture2.BackColor = Color.LightSalmon;
                Thread.Sleep(150);

            }
        }
    }
}
