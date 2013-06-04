using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication4
{


    public partial class Form1 : Form
    {
        int herocounter = 0;
        void Choose2(string[,] mass1, string[,] mass2)
        {
            string[,] bothhero = new string[255, 255];
            int counter = 0, viewcounter = 0;
            int counter1 = mass1.Length;
            int counter2 = mass2.Length;
            for (int i = 0; i < counter1; i++)
            {
                for (int f = 0; f < counter2; f++)
                {
                    if (mass1[0, i] == mass2[0, f])
                    {
                        bothhero[0, counter] = mass1[0, i];
                        bothhero[1, counter] = mass1[1, i];
                        counter++;
                    }

                }
            }
            switch (counter)
            {
                case 1:
                    {
                        label1.Text = bothhero[0, 0];
                        pictureBox1.Load(bothhero[1, 0]);
                        if (label4.Text != mass1[0, 1])
                        {
                            label5.Text = mass1[0, 1];
                            pictureBox2.Load(mass1[1, 1]);
                        }
                        if (label4.Text != mass1[0, 2])
                        {
                            label6.Text = mass2[0, 2];
                            pictureBox2.Load(mass2[1, 2]);
                        }
                        if (label4.Text != mass1[0,3])
                        {
                            label7.Text = mass1[0, 3];
                            pictureBox2.Load(mass1[1, 3]);
                        }

                        if (label2.Text == "")
                        {
                            if (label1.Text != mass1[0, 1] && label3.Text != mass1[0, 1] && label4.Text != mass1[0, 1])
                            {
                                label2.Text = mass1[0, 1];
                                pictureBox2.Load(mass1[1, 1]);
                            }
                        }
                        break;

                    }
                case 2:
                    {
                        label1.Text = bothhero[0, 0];
                        pictureBox1.Load(bothhero[1, 0]);
                        label2.Text = bothhero[0, 1];
                        pictureBox1.Load(bothhero[1, 1]);
                        if (label1.Text != mass1[0, 1] && label2.Text != mass1[0, 1])
                        {
                            label2.Text = mass1[0, 1];
                            pictureBox2.Load(mass1[1, 1]);
                        }
                        break;
                    }
            }
        }

       

        public Form1()
        {
            InitializeComponent();
        }
        string[,] amun_ra = new string[,] { { "Ellonia", "Forsaken Archer", "Deadwood", "Sir Benzington","Devourer"},
            { "http://heroesofnewerth.com/images/heroes/219/icon_128.jpg", "http://heroesofnewerth.com/images/heroes/121/icon_128.jpg", "http://heroesofnewerth.com/images/heroes/123/icon_128.jpg","http://heroesofnewerth.com/images/heroes/234/icon_128.jpg","http://heroesofnewerth.com/images/heroes/6/icon_128.jpg"} };
        string[] war_beast = new string[] { "Silueth", "SomeAnother", "Empath", "Corrupted Desciple" };
        string[,] Hero;
 
        void Choose1(string[,] mass1)
        {
            if(herocounter < 1) {

            if (mass1.Length == 6 || mass1.Length <6)
            {
                label4.Text = mass1[0, 0];
                pictureBox1.Load(mass1[1, 0]);
                label5.Text = mass1[0, 1];
                pictureBox2.Load(mass1[1, 1]);
                label6.Text = mass1[0, 2];
                pictureBox3.Load(mass1[1, 2]);
                herocounter = 3;
                
            }

            if (mass1.Length == 8 || mass1.Length > 6)
            {
                label4.Text = mass1[0, 0];
                pictureBox1.Load(mass1[1, 0]);
                label5.Text = mass1[0, 1];
                pictureBox2.Load(mass1[1, 1]);
                label6.Text = mass1[0, 2];
                pictureBox3.Load(mass1[1, 2]);
                label7.Text = mass1[0, 3];
                pictureBox5.Load(mass1[1, 3]);
                herocounter = 4;
         

             }

            }
            else {
                switch ((mass1.Length/2) - herocounter) 
                {
                    case 0:
                        herocounter = 0; break;
                    case 1:
                        {
                            label5.Text ="";
                            label6.Text = "";
                            label7.Text = "";
                            pictureBox2.Load("empty_legion.jpg");
                            pictureBox3.Load("empty_legion.jpg");
                            pictureBox5.Load("empty_legion.jpg");
                            label4.Text = mass1[0, herocounter];
                            pictureBox1.Load(mass1[1, herocounter]);
                            herocounter++;
                            if (mass1.Length - herocounter == 0) { herocounter = 0; };
                            break;
                            
                        }
                    case 2:
                        {
                            label4.Text = mass1[0, herocounter];
                            label5.Text = mass1[0, herocounter+1]; 
                            herocounter +=2;
                            if (mass1.Length - herocounter == 0) { herocounter = 0; };
                            break;
                        }
                    case 3:
                        {
                            label4.Text = mass1[0, herocounter];
                            label5.Text = mass1[0, herocounter + 1];
                            label6.Text = mass1[0, herocounter + 2];
                            herocounter +=3;
                            if (mass1.Length - herocounter == 0) { herocounter = 0; };
                            break;
                        }
                    case 4:
                        {
                            label4.Text = mass1[0, herocounter];
                            label5.Text = mass1[0, herocounter + 1];
                            label6.Text = mass1[0, herocounter + 2];
                            label7.Text = mass1[0, herocounter + 2];
                            herocounter +=4;
                            if (mass1.Length - herocounter == 0) { herocounter = 0; };
                            break;
                        }
                
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                       if (comboBox1.Text == "Amun-Ra")
            {
                Hero = amun_ra;
                Choose1(amun_ra);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "1 Игрок")
            {

                
                comboBox1.Visible = true;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
            
            }
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
             
            
        }

        private void comboBox2_StyleChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Choose1(Hero);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



    }
}
