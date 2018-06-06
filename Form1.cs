using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Color crntColor=Color.White;
        private int X=41, Y=41, size=12, v=0,v1=0,v2=0,v3=0,m=0,red=0;
        
        private PictureBox[,] labParts;

        public Form1()
        {
            InitializeComponent();
            NewLabirint();
        }

        private void NewLabirint()
        {
            labParts=new PictureBox[X,Y];

            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    labParts[i, j] = new PictureBox();

                    int xPos = (i * size) + 220;
                    int yPos = (j * size) + 150;
                    labParts[i, j].SetBounds(xPos, yPos, size, size);

                    if ((i == 0 && j == 0) || (i == 19 && j == 19) || (i == 19 && j == 40) || (i == 0 && j == 21) || (i == 21 && j == 0) || (i == 40 && j == 19) || (i == 21 && j == 21) || (i == X - 1 && j == Y - 1))
                    labParts[i, j].BackColor = Color.LightGreen;
                    else if (i == 20 || j == 20)
                    {
                        labParts[i, j].BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        labParts[i, j].BackColor = Color.White;

                        EventHandler clickEvent = new EventHandler(PictureBox_Click);
                        labParts[i, j].Click += clickEvent;
                    }
                    /*2*/
                    if ((i == 21 && (j == 4 || j == 5 || j == 7 || j == 8 || j == 9 || j == 15)) ||
                        (i == 22 && (j == 2 || j == 5 || j == 7 || j == 9 || j == 10 || j == 12 || j == 13 || j == 14 || j == 15 || j == 17 || j == 18 || j == 19)) ||
                        (i == 23 && (j == 1 || j == 2 || j == 3 || j == 14 || j == 17 || j == 19)) ||
                        (i == 24 && (j == 1 || j == 6 || j == 7 || j == 9 || j == 11 || j == 13 || j == 14 || j == 16 || j == 17 || j == 19)) ||
                        (i == 25 && (j == 1 || j == 3 || j == 4 || j == 7 || j == 9 || j == 11 || j == 13 || j == 17 || j == 19)) ||
                        (i == 26 && (j == 1 || j == 3 || j == 4 || j == 5 || j == 9 || j == 11 || j == 13 || j == 15 || j == 16 || j == 17 || j == 19)) ||
                        (i == 27 && (j == 0 || j == 7 || j == 8 || j == 9 || j == 11 || j == 13 || j == 15 || j == 17 || j == 19)) ||
                        (i == 28 && (j == 0 || j == 1 || j == 2 || j == 3 || j == 4 || j == 6 || j == 7 || j == 11 || j == 13 || j == 15 || j == 17 || j == 19)) ||
                        (i == 29 && (j == 0 || j == 1 || j == 2 || j == 3 || j == 9 || j == 10 || j == 11 || j == 13 || j == 19)) ||
                        (i == 30 && (j == 1 || j == 5 || j == 6 || j == 7 || j == 9 || j == 17 || j == 18 || j == 19)) ||
                        (i == 31 && (j == 1 || j == 4 || j == 5 || j == 7 || j == 9 || j == 10 || j == 11 || j == 14 || j == 15 || j == 19)) ||
                        (i == 32 && (j == 3 || j == 4 || j == 7 || j == 9 || j == 13 || j == 15 || j == 16)) ||
                        (i == 33 && (j == 2 || j == 3 || j == 6 || j == 7 || j == 8 || j == 9 || j == 11 || j == 16 || j == 17 || j == 18)) ||
                        (i == 34 && (j == 1 || j == 2 || j == 5 || j == 6 || j == 11 || j == 12 || j == 13 || j == 14)) ||
                        (i == 35 && (j == 4 || j == 5 || j == 6 || j == 9 || j == 14 || j == 15 || j == 17 || j == 18)) ||
                        (i == 36 && (j == 2 || j == 3 || j == 4 || j == 7 || j == 8 || j == 9 || j == 11 || j == 17)) ||
                        (i == 37 && (j == 0 || j == 1 || j == 2 || j == 6 || j == 7 || j == 8 || j == 9 || j == 11 || j == 13 || j == 14 || j == 15 || j == 17)) ||
                        (i == 38 && (j == 0 || j == 4 || j == 5 || j == 6 || j == 7 || j == 8 || j == 9 || j == 11 || j == 13 || j == 15 || j == 17 || j == 18)) ||
                        (i == 39 && (j == 0 || j == 2 || j == 4 || j == 5 || j == 6 || j == 7 || j == 8 || j == 9 || j == 11 || j == 15 || j == 17)) ||
                        (i == 40 && (j == 0 || j == 11 || j == 12 || j == 13 || j == 14 || j == 15 || j == 17)))
                        labParts[i, j].BackColor = Color.Black;
                    /*3*/
                    if ((i==0&&(j==23 ||j==35||j==39||j==41))||
                        (i==1&&(j==23 ||j==35||j==39||j==41))||
                        (i==2&&(j==21 ||j==23||j==25||j==26  ||j ==27 ||j ==28 ||j==29  ||j==30  ||j==31  ||j ==32 || j ==33 ||j==35  || j ==37 ||j==39))||
                        (i==3&&(j==21 ||j==23||j==25||j==33  ||j ==35 ||j ==37 ||j==39))||
                        (i==4&&(j==21 ||j==23||j==25||j==27  ||j ==28 ||j ==29 ||j==30  ||j==31  ||j==33  ||j ==35 || j ==37 ||j==39))||
                        (i==5&&(j==21 ||j==23||j==25||j==27  ||j ==31 ||j ==33 ||j==35  ||j==37  ||j==39))||
                        (i==6&&(j==21 ||j==23||j==25||j==27  ||j ==29 ||j ==31 ||j==33  ||j==35  ||j==37  ||j==39))||
                        (i==7&&(j==21 ||j==23||j==25||j==27  ||j ==28 ||j ==29 ||j==31  ||j==33  ||j==35  ||j ==37 ||j ==39))||
                        (i==8&&(j==21 ||j==23||j==25||j==31  ||j ==33 ||j ==35 ||j==37  ||j==39))||
                        (i==9&&(j==21 ||j==23||j==25||j==26  ||j ==27 ||j ==28 ||j==29  ||j==30  ||j==31  ||j ==33 || j ==35 ||j ==37 ||j ==39))||
                        (i==10&&(j==21||j==35||j==37||j==39))||
                        (i==11&&(j==24||j==25||j==26||j==27  ||j ==28 ||j ==29 ||j==30  ||j==31  ||j==32  ||j ==33 || j ==35 ||j ==37 ||j ==39))||
                        (i==12&&(j==22||j==32||j==35||j==37  ||j==39))||
                        (i==13&&(j==22||j==24||j==25||j==26  ||j ==27 ||j ==28 ||j==29  ||j==30  ||j==32  ||j ==34 || j ==35 ||j ==37 ||j ==39))||
                        (i==14&&(j==22||j==25||j==30||j==32  ||j ==34 ||j ==37 ||j==39))||
                        (i==15&&(j==22||j==24||j==26||j==27  ||j ==28 ||j ==30 ||j==32  ||j==34  ||j==36  ||j ==37 ||j ==39))||
                        (i==16&&(j==22||j==24||j==25||j==26  ||j ==27 ||j ==28 ||j==30  ||j==32  ||j==34  ||j ==36 ||j ==39))||
                        (i==17&&(j==22||j==30||j==32||j==34  ||j ==36 ||j==38))||
                        (i==18&&(j==22||j==23||j==24||j==25  ||j ==26 ||j ==27 ||j==28  ||j==29  ||j==30  ||j ==32 || j ==34 ||j ==36 ||j ==38))||
                        (i==19&&(j==31||j==36)))
                     labParts[i, j].BackColor = Color.Black;
                    /*4*/
                    if( (i==21&&(j==24 ||j==25   || j ==30 || j ==31 || j ==33 || j ==34 || j ==35 || j ==36 || j ==37 || j ==38 || j ==39 || j ==40))||
                        (i==22&&(j==21 || j ==22 || j ==24 || j ==25 || j ==27 || j ==28 || j ==30 || j ==31 || j ==33 || j ==34 || j ==35 || j ==36 || j ==37 || j ==38 || j ==40))||
                        (i==23&&(j==21 || j ==22 || j ==27 || j ==28 || j ==37 || j ==38 || j ==40))||
                        (i==24&&(j==25 || j ==26 || j ==30 || j ==31 || j ==32 || j ==33 || j ==34 || j ==36 || j ==37 || j ==38 || j ==40))||
                        (i==25&&(j==22 || j ==23 || j ==25 || j ==26 || j ==30 || j ==31 || j ==32 || j ==33 || j ==34 || j ==36 || j ==37 || j ==38 || j ==40))||
                        (i==26&&(j==22 || j ==23 || j ==27 || j ==28 || j ==30 || j ==31 || j ==32 || j ==33 || j ==34 || j ==36 || j ==37 || j ==38 || j ==40))||
                        (i==27&&(j==24 || j ==25 || j ==27 || j ==28 || j ==30 || j ==31 || j ==32 || j ==33 || j ==34 || j ==36 || j ==37 || j ==38 || j ==40))||
                        (i==28&&(j==21 || j ==22 || j ==24 || j ==25 || j ==30 || j ==31 || j ==32 || j ==3 || j ==34 || j ==36 || j ==37 || j ==38 || j ==40))||
                        (i==29&&(j==21 || j ==22 || j ==23 || j ==27 || j ==28 || j ==33 || j ==34 || j ==40))||
                        (i==30&&(j==23 || j ==25 || j ==27 || j ==28 || j ==30 || j ==31 || j ==34 || j ==39 || j ==40))||
                        (i==31&&(j==21 || j ==25 || j ==27 || j ==30 || j ==31 || j ==35 || j ==36 || j ==38 || j ==39 || j ==40))||
                        (i==32&&(j==21 || j ==23 || j ==24 || j ==27 || j ==30 || j ==32 || j ==31 || j ==33 || j ==35 || j ==36 || j ==38 || j ==39))||
                        (i==33&&(j==21 || j ==23 || j ==24 || j ==26 || j ==30 || j ==31 || j ==32 || j ==33 || j ==35 || j ==36 || j ==39))||
                        (i==34&&(j==21 || j ==22 || j ==26 || j ==31 || j ==32 || j ==35 || j ==36 || j ==37 || j ==39))||
                        (i==35&&(j==21 || j ==22 || j ==24 || j ==25 || j ==29 || j ==35 || j ==36 || j ==37 || j ==39))||
                        (i==36&&(j==22 || j ==24 || j ==25 || j ==29 || j ==30 || j ==31 || j ==32 || j ==33 || j ==37))||
                        (i==37&&(j==23 || j ==29 || j ==30 || j ==31 || j ==32 || j ==33 || j ==34 || j ==36 || j ==37 || j ==38 || j ==39))||
                        (i==38&&(j==22 || j ==23 || j ==25 || j ==26 || j ==36 || j ==37 || j ==38 || j ==39))||
                        (i==39&&(j==25 || j ==26 || j ==28 || j ==29 || j ==30 || j ==31 || j ==32 || j ==33 || j ==34 || j ==36 || j ==37 || j ==38 || j ==39))||
                        (i==40&&(j==22 || j ==23 || j ==24 || j ==36 || j ==37 || j ==38 || j ==39)))
                    labParts[i, j].BackColor = Color.Black;



                    this.Controls.Add(labParts[i, j]);

                   
                }
            }
           
           
        }

        



        private void Wall_Click(object sender, EventArgs e)
        {
            crntColor = Color.Black;
        }
        private void Erase_Click(object sender, EventArgs e)
        {
            crntColor = Color.White;
        }
        private void Go_Click(object sender, EventArgs e)
        {
            crntColor = Color.Red;
            

        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = crntColor;
            
            if (((PictureBox)sender).BackColor == Color.Red)
            {
                red++;
            }
        }
        


        private void Search_Click(object sender, EventArgs e)
        {
         
            bool[,] alreadySearched = new bool[X, Y];

         
            if (!Search(0, 0, alreadySearched))
                MessageBox.Show("Вихід знайти неможливо!");
            for (int i = 0; i < 20; i++)
            {

                for (int j = 0; j < 20; j++)
                {
                    if (labParts[i, j].BackColor == Color.Blue)
                        v++;
                    TextBox1.Text = Convert.ToString(v);
                 
                    
                }
            }
            if (!Search(21, 0, alreadySearched))
                MessageBox.Show("Вихід знайти неможливо!");
            for (int i = 21; i < 41; i++)
            {

                for (int j = 0; j < 20; j++)
                {
                    if (labParts[i, j].BackColor == Color.Blue)
                        v1++;
                    TextBox2.Text = Convert.ToString(v1);

                }
            }
            if (!Search(0, 21, alreadySearched))
                MessageBox.Show("Вихід знайти неможливо!");
            for (int i = 0; i < 20; i++)
            {

                for (int j = 21; j < 41; j++)
                {
                    if (labParts[i, j].BackColor == Color.Blue)
                        v2++;
                    TextBox3.Text = Convert.ToString(v2);

                }
            }
            if (!Search(21, 21, alreadySearched))
                MessageBox.Show("Вихід знайти неможливо!");
            for (int i = 21; i < 41; i++)
            {

                for (int j = 21; j < 41; j++)
                {
                    if (labParts[i, j].BackColor == Color.Blue)
                        v3++;
                    TextBox4.Text = Convert.ToString(v3);

                }
            }
            for (int i = 0; i < 41; i++)
            {

                for (int j = 0; j < 41; j++)
                {
                    if (labParts[i, j].BackColor == Color.Red)
                        m++;

                }
            }
            if (red > 0)
            {
                if (m==0) {
                    MessageBox.Show("Лабіринт : Чудово!Відмітки які ви залишили співпали з шляхами які віднайшла програма."); }
                else if (m != 0)
                {
                    MessageBox.Show("Ваші відмітки  не співпали з шляхами які віднайшла програма");
                }
            }
            

        }

        

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Convert.ToString(v);
        }

       

        private void TextBox2_TextCharged(object sender, EventArgs e)
        {
            TextBox2.Text = Convert.ToString(v1);
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Convert.ToString(v2);
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox4.Text = Convert.ToString(v3);
        }



        private void Clean_Click(object sender, EventArgs e)
        {
          
            for (int i = 0; i < 41; i++)
            {
                for (int j = 0; j < 41; j++)
                {if (labParts[i, j].BackColor != Color.Black||labParts[i, j].BackColor == Color.Red)
                    {
                        if (labParts[i, j].BackColor == Color.Blue)
                            v++;
                        v1++;
                        v2++;
                        v3++;
                        
                        TextBox1.Text = Convert.ToString(v = 0);
                        TextBox2.Text = Convert.ToString(v1 = 0);
                        TextBox3.Text = Convert.ToString(v2 = 0);
                        TextBox4.Text = Convert.ToString(v3 = 0);
                        m = 0;
                        red = 0;
                        labParts[i, j].BackColor = Color.White;


                    }
                }
            }

            
            labParts[0, 0].BackColor = Color.LightGreen;
            labParts[X - 1, Y - 1].BackColor = Color.LightGreen;
            labParts[21, 0].BackColor = Color.LightGreen;
            labParts[40, 19].BackColor = Color.LightGreen;
            labParts[21, 21].BackColor = Color.LightGreen;
            labParts[0, 21].BackColor = Color.LightGreen;
            labParts[19, 19].BackColor = Color.LightGreen;
            labParts[19, 40].BackColor = Color.LightGreen;
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    if(i==20||j==20)
                    labParts[i, j].BackColor = Color.ForestGreen;
                    
                }
            } 
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool Search(int xPos2, int yPos2, bool[,] used)
        {
            bool rightWay = false;

            bool nextToVerify = true;
           
            
            if (xPos2 >= X || xPos2 < 0 || yPos2 >= Y || yPos2 < 0 ||yPos2==20||xPos2==20)
                nextToVerify = false;
            else
            {
                
                if (labParts[xPos2, yPos2].BackColor == Color.LightGreen && (xPos2 != 0 && yPos2 != 0 && xPos2!=21&&yPos2!=0&&xPos2!=0&&yPos2!=21&&xPos2!=21&&yPos2!=21))
                {
                    rightWay = true;
                    nextToVerify = false;
                }
              


                if (labParts[xPos2, yPos2].BackColor == Color.Black|| labParts[xPos2, yPos2].BackColor == Color.LightGray)
                    nextToVerify = false;

              

                if (used[xPos2, yPos2])
                    nextToVerify = false;
            }

            
            if (nextToVerify)
            {

                used[xPos2, yPos2] = true;


                rightWay = rightWay || Search(xPos2 + 1, yPos2, used);

                rightWay = rightWay || Search(xPos2, yPos2 + 1, used);

                rightWay = rightWay || Search(xPos2 - 1, yPos2, used);

                rightWay = rightWay || Search(xPos2, yPos2 - 1, used);
            }

         
            if (rightWay)
            
                labParts[xPos2, yPos2].BackColor = Color.Blue;
            

            return rightWay;
            
            
                
            

        }

        
    }
}
    

