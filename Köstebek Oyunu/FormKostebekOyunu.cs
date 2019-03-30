using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Köstebek_Oyunu
{
    public partial class frmKostebekOyunu : Form
    {
        public frmKostebekOyunu()
        {
            InitializeComponent();
        }
        int puan = 0;
        Random random = new Random();

        private void frmKostebekOyunu_Load(object sender, EventArgs e)
        {
            tmrKontrol.Start();
            for (int i = 1; i < 85; i++)
            {
                Button button = new Button();
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
                button.Width = 50;
                button.Height = 50;
                button.Text = i.ToString();
                flpOyunEkranı.Controls.Add(button);
            }
        }

        private void tmrKontrol_Tick(object sender, EventArgs e)
        {
            int rastgele = random.Next(1, 85);

            foreach (Button button in flpOyunEkranı.Controls)
            {
                //Button button = button as Button;
                if (button.Text == rastgele.ToString())
                {
                    //top.ImageLocation = Application.StartupPath + @"\..\..\Resources\top.png";
                    //button.BackgroundImage = Image.FromFile("foto0.png");
                    button.BackColor = Color.Red;

                    button.Click += Button_Click;
                }
                else
                {
                    button.BackColor = Color.White;
                }

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.Red)
            {
                puan++;
                button.BackColor = Color.Green;
            }

            //if (button.BackgroundImage == Image.FromFile("foto0.png"))
            //{
            //    puan++;
            //   button.BackgroundImage = Image.FromFile("foto22.png");
            //}
            if (button.BackColor == Color.White)
            {
                puan--;
            }


            this.Text = puan.ToString();
        }
    }
}
