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
        int viewcounter = 0;
        int herocounter = 0;
        int counter = 0;
        bool selected1 = false;
        bool selected2 = false;
        string[,] Hero1;
        string[,] Hero2;
        void Choose2(string[,] mass1, string[,] mass2)
        {
            string[,] bothhero = new string[255, 255];
            string[,] usedheroes = new string[255, 255];
            int counter1 = mass1.Length;
            int counter2 = mass2.Length;
            if (viewcounter < 1)
            {
                for (int i = 0; i < counter1 / 2; i++)
                {
                    for (int f = 0; f < counter2 / 2; f++)
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
                    case 0:
                        {
                            label4.Text = mass1[0, 0];
                            pictureBox1.Load(mass1[1, 0]);
                            label5.Text = mass1[0, 1];
                            pictureBox2.Load(mass1[1, 1]);
                            label6.Text = mass2[0, 2];
                            pictureBox3.Load(mass2[1, 2]);
                            label7.Text = mass2[0, 3];
                            pictureBox3.Load(mass2[1, 3]);
                            viewcounter = 2;
                            counter = 0;
                            break;
                        }
                    case 1:
                        {
                            label4.Text = bothhero[0, 0];
                            pictureBox1.Load(bothhero[1, 0]);
                            viewcounter = 1;
                            counter = 0;
                            break;

                        }
                    case 2:
                        {
                            label4.Text = bothhero[0, 0];
                            pictureBox1.Load(bothhero[1, 0]);
                            label5.Text = bothhero[0, 1];
                            pictureBox2.Load(bothhero[1, 1]);
                            viewcounter = 1;
                            counter = 0;
                            break;

                        }
                    case 3:
                        {
                            label4.Text = bothhero[0, 0];
                            pictureBox1.Load(bothhero[1, 0]);
                            label5.Text = bothhero[0, 1];
                            pictureBox2.Load(bothhero[1, 1]);
                            label6.Text = bothhero[0, 2];
                            pictureBox3.Load(bothhero[1, 2]);
                            viewcounter = 1;
                            counter = 0;
                            break;

                        }
                    case 4:
                        {
                            label4.Text = bothhero[0, 0];
                            pictureBox1.Load(bothhero[1, 0]);
                            label5.Text = bothhero[0, 1];
                            pictureBox2.Load(bothhero[1, 1]);
                            label6.Text = bothhero[0, 2];
                            pictureBox3.Load(bothhero[1, 2]);
                            label7.Text = bothhero[0, 3];
                            pictureBox3.Load(bothhero[1, 3]);
                            viewcounter = 1;
                            counter = 0;
                            break;
                        }
                }

            }
            else
            {
                if (viewcounter == 1)
                {
                    switch (herocounter)
                    {
                        case 0:
                            {
                                label4.Text = mass1[0, 0];
                                pictureBox1.Load(mass1[1, 0]);
                                label5.Text = mass1[0, 1];
                                pictureBox2.Load(mass1[1, 1]);
                                if (label4.Text != mass2[0, 2] && label5.Text != mass2[0, 2])
                                {
                                    label6.Text = mass2[0, 2];
                                    pictureBox3.Load(mass2[1, 2]);
                                }
                                else
                                {
                                    Random random = new Random();
                                    int randomNumber = random.Next(0, (counter2 / 2));
                                    label6.Text = mass2[0, randomNumber];
                                    pictureBox3.Load(mass2[1, randomNumber]);
                                }
                                if (label4.Text != mass2[0, 3] && label5.Text != mass2[0, 3])
                                {
                                    label7.Text = mass2[0, 3];
                                    pictureBox5.Load(mass2[1, 3]);
                                }
                                else
                                {
                                    Random random = new Random();
                                    int randomNumber = random.Next(0, (counter2/2));
                                    label7.Text = mass2[0, randomNumber];
                                    pictureBox5.Load(mass2[1, randomNumber]);
                                }
                                label7.Text = mass2[0, 3];
                                pictureBox5.Load(mass2[1, 3]);
                                herocounter = 1;
                                break;
                            }
                        case 1:
                            {
                                label4.Text = mass2[0, 0];
                                pictureBox1.Load(mass2[1, 0]);
                                label5.Text = mass2[0, 1];
                                pictureBox2.Load(mass2[1, 1]);
                                label6.Text = mass1[0, 2];
                                pictureBox3.Load(mass1[1, 2]);
                                label7.Text = mass1[0, 3];
                                pictureBox5.Load(mass1[1, 3]);
                                herocounter = 0;
                                viewcounter = 0;
                                break;
                            }
                    }
                }
                else
                {
                    if (viewcounter == 2)
                    {
                        switch (herocounter)
                        {
                            case 0:
                                {
                                    label4.Text = mass1[0, 0];
                                    pictureBox1.Load(mass1[1, 0]);
                                    label5.Text = mass1[0, 1];
                                    pictureBox2.Load(mass1[1, 1]);
                                    if (label4.Text != mass2[0, 2] && label5.Text != mass2[0, 2])
                                    {
                                        label6.Text = mass2[0, 2];
                                        pictureBox3.Load(mass2[1, 2]);
                                    }
                                    else
                                    {
                                        Random random = new Random();
                                        int randomNumber = random.Next(0, counter2/2);
                                        label6.Text = mass2[0, randomNumber];
                                        pictureBox3.Load(mass2[1, randomNumber]);
                                    }
                                    if (label4.Text != mass2[0, 3] && label5.Text != mass2[0, 3])
                                    {
                                        label7.Text = mass2[0, 3];
                                        pictureBox5.Load(mass2[1, 3]);
                                    }
                                    else
                                    {
                                        Random random = new Random();
                                        int randomNumber = random.Next(0, counter2/2);
                                        label7.Text = mass2[0, randomNumber];
                                        pictureBox5.Load(mass2[1, randomNumber]);
                                    }
                                    
                                    break;
                                }
                        }
                    }
                }
            }
        }

       

        public Form1()
        {
            InitializeComponent();
        }
        string[,] amun_ra = new string[,] { { "Ellonia", "Forsaken Archer", "Deadwood", "Sir Benzington","Devourer"},
            { "http://heroesofnewerth.com/images/heroes/219/icon_128.jpg", "http://heroesofnewerth.com/images/heroes/121/icon_128.jpg", "http://heroesofnewerth.com/images/heroes/123/icon_128.jpg","http://heroesofnewerth.com/images/heroes/234/icon_128.jpg","http://heroesofnewerth.com/images/heroes/6/icon_128.jpg"} };
        string[,] war_beast = new string[,] { { "Silueth", "Devourer", "Ellonia", "Empath", "Corrupted Desciple" },
            { "http://heroesofnewerth.com/images/heroes/185/icon_128.jpg", "http://heroesofnewerth.com/images/heroes/6/icon_128.jpg", "http://heroesofnewerth.com/images/heroes/219/icon_128.jpg", "http://heroesofnewerth.com/images/heroes/168/icon_128.jpg", "http://heroesofnewerth.com/images/heroes/114/icon_128.jpg" } };
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
                Choose2(amun_ra, war_beast);
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
            comboBox1.Visible = false;
            button1.Visible = false;
            label2.Visible = false;
            comboBox3.Visible = false;
            label1.Visible = false;
            button2.Visible = false;
            if (comboBox2.SelectedItem == "1 игрок")
            {

                comboBox1.Visible = true;
                button1.Visible = true;
                label2.Visible = true;

            }

                if (comboBox2.SelectedItem == "2 игрока")
                {
                    comboBox1.Visible = true;
                    label2.Visible = true;
                    comboBox3.Visible = true;
                    label1.Visible = true;
                    button2.Visible = true;
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

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
              
        }

        private void button2_Click(object sender, EventArgs e)
        {

            switch (comboBox1.Text)
            {
                case "Amun-Ra":
                    {
                        Hero1 = amun_ra;
                        selected1 = true;
                        break;
                    }
                default: selected1 = false; break;
            }

            switch (comboBox3.Text)
            {
                case "War Beast":
                    {
                        Hero2 = war_beast;
                        selected2 = true;
                        break;
                    }
                default: selected2 = false; break;
            }
            
            if (selected1 == true && selected2 == true)
            {
                Choose2(Hero1, Hero2);
                selected1 = selected2 = false;
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
