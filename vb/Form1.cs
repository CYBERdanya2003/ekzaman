using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vb
{
    public partial class Form1 : Form
    {
        int opn_count;
        int[] pairs;
        PictureBox[] array_pics;
        int[] opened;
        int[] throne;
        public Form1()
        {
            opn_count = 0;
            InitializeComponent();
            pairs = new int[8];
            throne = new int[16];
            opened = new int[2];
            array_pics = new PictureBox[16];
            array_pics[0] = pictureBox1;
            array_pics[1] = pictureBox2;
            array_pics[2] = pictureBox3;
            array_pics[3] = pictureBox4;
            array_pics[4] = pictureBox5;
            array_pics[5] = pictureBox6;
            array_pics[6] = pictureBox7;
            array_pics[7] = pictureBox8;
            array_pics[8] = pictureBox9;
            array_pics[9] = pictureBox10;
            array_pics[10] = pictureBox11;
            array_pics[11] = pictureBox12;
            array_pics[12] = pictureBox13;
            array_pics[13] = pictureBox14;
            array_pics[14] = pictureBox15;
            array_pics[15] = pictureBox16;

        }
        public void bokc()
        {
            pictureBox1.BackgroundImage = imageList1.Images[9];
            pictureBox2.BackgroundImage = imageList1.Images[9];
            pictureBox3.BackgroundImage = imageList1.Images[9];
            pictureBox4.BackgroundImage = imageList1.Images[9];
            pictureBox5.BackgroundImage = imageList1.Images[9];
            pictureBox6.BackgroundImage = imageList1.Images[9];
            pictureBox7.BackgroundImage = imageList1.Images[9];
            pictureBox8.BackgroundImage = imageList1.Images[9];
            pictureBox9.BackgroundImage = imageList1.Images[9];
            pictureBox10.BackgroundImage = imageList1.Images[9];
            pictureBox11.BackgroundImage = imageList1.Images[9];
            pictureBox12.BackgroundImage = imageList1.Images[9];
            pictureBox13.BackgroundImage = imageList1.Images[9];
            pictureBox14.BackgroundImage = imageList1.Images[9];
            pictureBox15.BackgroundImage = imageList1.Images[9];
            pictureBox16.BackgroundImage = imageList1.Images[9];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            bokc();

            // 1 
            pictureBox1.Top = 0;
            pictureBox1.Left = 0;
            pictureBox1.Width = panel1.Width / 4;
            pictureBox1.Height = panel1.Height / 4;

            pictureBox2.Top = 0;
            pictureBox2.Left = panel1.Width / 4;
            pictureBox2.Width = panel1.Width / 4;
            pictureBox2.Height = panel1.Height / 4;

            pictureBox3.Top = 0;
            pictureBox3.Left = panel1.Width / 2;
            pictureBox3.Width = panel1.Width / 4;
            pictureBox3.Height = panel1.Height / 4;

            pictureBox4.Top = 0;
            pictureBox4.Left = panel1.Width * 3 / 4;
            pictureBox4.Width = panel1.Width / 4;
            pictureBox4.Height = panel1.Height / 4;

            // 2 
            pictureBox5.Top = panel1.Height / 4;
            pictureBox5.Left = 0;
            pictureBox5.Width = panel1.Width / 4;
            pictureBox5.Height = panel1.Height / 4;

            pictureBox6.Top = panel1.Height / 4;
            pictureBox6.Left = panel1.Width / 4;
            pictureBox6.Width = panel1.Width / 4;
            pictureBox6.Height = panel1.Height / 4;

            pictureBox7.Top = panel1.Height / 4;
            pictureBox7.Left = panel1.Width / 2;
            pictureBox7.Width = panel1.Width / 4;
            pictureBox7.Height = panel1.Height / 4;

            pictureBox8.Top = panel1.Height / 4;
            pictureBox8.Left = panel1.Width * 3 / 4;
            pictureBox8.Width = panel1.Width / 4;
            pictureBox8.Height = panel1.Height / 4;

            // 3 
            pictureBox9.Top = panel1.Height / 2;
            pictureBox9.Left = 0;
            pictureBox9.Width = panel1.Width / 4;
            pictureBox9.Height = panel1.Height / 4;

            pictureBox10.Top = panel1.Height / 2;
            pictureBox10.Left = panel1.Width / 4;
            pictureBox10.Width = panel1.Width / 4;
            pictureBox10.Height = panel1.Height / 4;

            pictureBox11.Top = panel1.Height / 2;
            pictureBox11.Left = panel1.Width / 2;
            pictureBox11.Width = panel1.Width / 4;
            pictureBox11.Height = panel1.Height / 4;

            pictureBox12.Top = panel1.Height / 2;
            pictureBox12.Left = panel1.Width * 3 / 4;
            pictureBox12.Width = panel1.Width / 4;
            pictureBox12.Height = panel1.Height / 4;

            // 4
            pictureBox13.Top = panel1.Height * 3 / 4;
            pictureBox13.Left = 0;
            pictureBox13.Width = panel1.Width / 4;
            pictureBox13.Height = panel1.Height / 4;


            pictureBox14.Top = panel1.Height * 3 / 4;
            pictureBox14.Left = panel1.Width / 4;
            pictureBox14.Width = panel1.Width / 4;
            pictureBox14.Height = panel1.Height / 4;

            pictureBox15.Top = panel1.Height * 3 / 4;
            pictureBox15.Left = panel1.Width / 2;
            pictureBox15.Width = panel1.Width / 4;
            pictureBox15.Height = panel1.Height / 4;

            pictureBox16.Top = panel1.Height * 3 / 4;
            pictureBox16.Left = panel1.Width * 3 / 4;
            pictureBox16.Width = panel1.Width / 4;
            pictureBox16.Height = panel1.Height / 4;

            button1_Click(null,null);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opn_count = 0;
            Random R;
            R = new Random();
            for (int i = 0; i < 8; i++)
            {
                pairs[i] = R.Next(6);
            }

            for (int i = 0; i < 16; i++)
            {
                array_pics[i].Visible = true;
                throne[i] = -1;
            }
            int used = 0;
            while(used != 8)
            {
                int n1 = R.Next(16);
                int n2 = R.Next(16);
                if (n1 == n2) continue;
                if (throne[n1] == -1 && throne[n2] == -1)
                {
                    
                    throne[n1] = throne[n2] = pairs[used];
                    used++;
                }
            }
            bokc();
          
           
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int index = Convert.ToInt32(p.Tag);
            if(opn_count == 1)
            {
                if (opened[0] == index) return; 
            }
            if(opn_count == 2)
            {

                bokc();
                opn_count = 0;
            }
            opened[opn_count] = index;
            opn_count++;
            if(opn_count == 2)
            {
                if (throne[opened[0]] == throne[opened[1]])
                {
                    array_pics[opened[0]].Visible = false;
                    array_pics[opened[1]].Visible = false;
                    opn_count = 0;
                    bokc();

                }
            }    
            p.BackgroundImage = imageList1.Images[throne[index]];

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

