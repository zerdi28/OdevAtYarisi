using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int birinciAtaUzaklık, ikinciAtaUzaklık, ücüncüAtaUzaklık;
        private void btnYarisiStart_Click(object sender, EventArgs e)
        {

            //1) formun sağ tarafına bitiş çizgisi eklenecek ve 1. bitiren at mb iler kullanıcıya bildirecek. yarışma bittiğinde tüm atlar duracak.
            //2) Yarışı sıfırla butonu eklenecek ve tıklandığında sistem en başa dönecek.
            //3) sol üste köşeden label olacak ve o labelda anlık olarak hangi at önde bilgisi verilecek. örn( 1. Kulvardaki ŞahBatur önde götürüyor gibi)
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }

        }

        private void btnYarisiYenidenBaşlat_Click(object sender, EventArgs e)
        {
            pc1.Left = birinciAtaUzaklık;
            pc2.Left = ikinciAtaUzaklık;
            pc3.Left = ücüncüAtaUzaklık;

            btnYarisiYenidenBaşlat.Text = string.Empty;

            btnYarisiStart.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciAtGenislik = pc1.Width;
            int ikinciAtGenislik = pc2.Width;
            int ücüncüAtGenislik = pc3.Width;

            int bitisNoktasi = pcFinish.Left;

            pc1.Left += rnd.Next(1, 20);
            pc2.Left += rnd.Next(1, 20);
            pc3.Left += rnd.Next(1, 20);


            if (pc1.Left > pc2.Left + 1 && pc1.Left > pc3.Left + 1)
            {
                lbGüncelSiralama.Text = "ŞahBatur yarışı önde götürüyor...";
            }
            else if (pc2.Left > pc1.Left + 1 && pc2.Left > pc3.Left + 1)
            {
                lbGüncelSiralama.Text = "BoldPilot efsane olduğunu hatırladı ve öne geçti...";
            }
            else if (pc3.Left > pc1.Left + 1 && pc3.Left >pc2.Left + 1)
            {
                lbGüncelSiralama.Text = "BirBeyinOğlu dış kulvardan gelerek liderliği alıyor...";
            }

            if (birinciAtGenislik + pc1.Left >= bitisNoktasi )
            {
                timer1.Stop();
                MessageBox.Show("Winner ŞahBatur!!!");
            }
            else if (ikinciAtGenislik + pc2.Left >= bitisNoktasi)
            {
                timer1.Stop();
                MessageBox.Show("Winner BoldPilot!!!");
            }
            else if (ücüncüAtGenislik + pc3.Left >= bitisNoktasi)
            {
                timer1.Stop();
                MessageBox.Show("Winner BirBeyinOğlu");
            }

            btnYarisiStart.Enabled = false;

            btnYarisiYenidenBaşlat.Enabled = true;
        
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciAtaUzaklık = pc1.Left;
            ikinciAtaUzaklık = pc2.Left;
            ücüncüAtaUzaklık = pc3.Left;
        }
    }
}
