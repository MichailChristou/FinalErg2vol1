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
using System.Data.OleDb;
using System.Media;

namespace FinalErg2
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            //using ABSOLUTE PATH to connect with db
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Mike\source\repos\FinalErg2\FinalErg2\bin\Debug\db\Database1.mdb;User Id=admin;Password=;";

        }

        // Declaring total,bet and credit
        public static double credits = 100;
        public static double total = 0;
        public static int bet = 0;
        public static int lines = 3;
        public static int icons = 3;


        public int[] p = { 1, 1, 1, 1, 1, 1 };

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'database1DataSet.Πίνακας1' table. You can move, or remove it, as needed.
            this.πίνακας1TableAdapter.Fill(this.database1DataSet.Πίνακας1);
            pictureBox1.Image = Image.FromFile("icon1.png");
            pictureBox2.Image = Image.FromFile("icon2.png");
            pictureBox3.Image = Image.FromFile("icon3.png");
            pictureBox4.Image = Image.FromFile("icon4.png");
            pictureBox5.Image = Image.FromFile("icon5.png");
            pictureBox6.Image = Image.FromFile("icon6.png");
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        //Genarator for random numbers
        public static class RandomGenerator
        {
            private static Random random;

            private static void Init()
            {
                if (random == null) random = new Random();
            }
            public static int Random(int min, int max)
            {
                Init();
                return random.Next(min, max);
            }
        }

        //button(-) for bet
        private void button7_Click(object sender, EventArgs e)
        {
            if (bet > 0) 
            {
                bet = bet - 1;
                label3.Text = "Bet= " + bet.ToString();
            }
        }

        //button(+) for bet
        private void button6_Click(object sender, EventArgs e)
        {
            if (bet < credits)
            {
                bet = bet + 1;
                label3.Text = "Bet= " + bet.ToString();
            }
        }

        //button(-) for icons
        private void button5_Click(object sender, EventArgs e)
        {
            if (icons > 1)
            { 
                icons = icons - 1;
                label4.Text = "Icons= " + icons.ToString();
            }
        }

        //button(+) for icons
        private void button4_Click(object sender, EventArgs e)
        {
            if (icons < 6)
            {
                icons = icons + 1;
                label4.Text = "Icons= " + icons.ToString();
            }
        }

        //button(-) for lines
        private void button3_Click(object sender, EventArgs e)
        {
            if (lines > 1)
            { 
                lines = lines - 1;
                if (lines == 5)
                { pictureBox6.Visible = false; }
                if (lines == 4)
                { pictureBox5.Visible = false; }
                if (lines == 3)
                { pictureBox4.Visible = false; }
                if (lines == 2)
                { pictureBox3.Visible = false; }
                if (lines == 1)
                { pictureBox2.Visible = false; }
                label5.Text = "Lines= " + lines.ToString();
            }
        }

        //button(+) for lines
        private void button2_Click(object sender, EventArgs e)
        {
            if (lines < 6)
            {
                lines = lines + 1;
                if (lines == 6)
                { pictureBox6.Visible = true; }
                if (lines == 5)
                { pictureBox5.Visible = true; }
                if (lines == 4)
                { pictureBox4.Visible = true; }
                if (lines == 3)
                { pictureBox3.Visible = true; }
                if (lines == 2)
                { pictureBox2.Visible = true; }
                label5.Text = "Lines= " + lines.ToString();
            }
        }

        //button for function spin
        private void button1_Click(object sender, EventArgs e)
        {
            //checking if bet value is correct
            if (credits >= bet)
            {
                credits = credits - bet;
                //rewriting label 2
                label2.Text = "Magic Coins: " + credits.ToString();


                //using ABSOLUTE PATH to play sound effect
                SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Mike\source\repos\FinalErg2\FinalErg2\bin\Debug\soundeffect.wav");
                soundPlayer.Play();

                
                wait(1700);

                for (var i = 0; i < lines; i++)
                {
                    p[i] = RandomGenerator.Random(1, icons);
                }

                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = Image.FromFile("icon" + p[0].ToString() + ".png");

                if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
                pictureBox2.Image = Image.FromFile("icon" + p[1].ToString() + ".png");

                if (pictureBox3.Image != null) pictureBox3.Image.Dispose();
                pictureBox3.Image = Image.FromFile("icon" + p[2].ToString() + ".png");

                if (pictureBox4.Image != null) pictureBox4.Image.Dispose();
                pictureBox4.Image = Image.FromFile("icon" + p[3].ToString() + ".png");

                if (pictureBox5.Image != null) pictureBox5.Image.Dispose();
                pictureBox5.Image = Image.FromFile("icon" + p[4].ToString() + ".png");

                if (pictureBox6.Image != null) pictureBox6.Image.Dispose();
                pictureBox6.Image = Image.FromFile("icon" + p[5].ToString() + ".png");


                total = 0;

                double multipleicons = icons * 0.4;

                //Multiple if to analyze and calculate values of credit,total and win
                if (lines == 1)
                {
                    total = total + 0;
                }
                if (lines == 2)
                {
                    if (p[0]==p[1])
                    {
                        total = total + (bet * 1 * multipleicons);
                    }
                }
                if (lines == 3)
                {
                    if (p[0] == p[1] || p[1]==p[2])
                    {
                        total = total + (bet * 0.5 * multipleicons);
                    }

                    if (p[0] == p[1] && p[1] == p[2])
                    {
                        total = total + (bet * 2 * multipleicons);
                    }
                }
                if (lines == 4)
                {
                    if (p[0] == p[1] || p[1] == p[2] || p[2] == p[3])
                    {
                        total = total + (bet * 0.5 * multipleicons);
                    }

                    if ((p[0] == p[1] && p[1] == p[2]) || (p[1] == p[2] && p[2] == p[3]))
                    {
                        total = total + (bet * 0.8 * multipleicons);
                    }

                    if (p[0] == p[1] && p[1] == p[2] && p[2] == p[3])
                    {
                        total = total + (bet * 3 * multipleicons);
                    }
                }
                if (lines == 5)
                {
                    if (p[0] == p[1] || p[1] == p[2] || p[2] == p[3] || p[3] == p[4])
                    {
                        total = total + (bet * 0.4 * multipleicons);
                    }

                    if ((p[0] == p[1] && p[1] == p[2]) || (p[1] == p[2] && p[2] == p[3]) || (p[2] == p[3] && p[3] == p[4]))
                    {
                        total = total + (bet * 0.8 * multipleicons);
                    }

                    if ((p[0] == p[1] && p[1] == p[2] && p[2] == p[3]) || (p[1] == p[2] && p[2] == p[3] && p[3] == p[4]))
                    {
                        total = total + (bet * 1.5 * multipleicons);
                    }

                    if (p[0] == p[1] && p[1] == p[2] && p[2] == p[3] && p[3] == p[4])
                    {
                        total = total + (bet * 4 * multipleicons);
                    }
                }
                if (lines == 6)
                {
                    if (p[0] == p[1] || p[1] == p[2] || p[2] == p[3] || p[3] == p[4])
                    {
                        total = total + (bet * 0.3 * multipleicons);
                    }

                    if ((p[0] == p[1] && p[1] == p[2]) || (p[1] == p[2] && p[2] == p[3]) || (p[2] == p[3] && p[3] == p[4]))
                    {
                        total = total + (bet * 0.8 * multipleicons);
                    }

                    if ((p[0] == p[1] && p[1] == p[2] && p[2] == p[3]) || (p[1] == p[2] && p[2] == p[3] && p[3] == p[4]))
                    {
                        total = total + (bet * 1.5 * multipleicons);
                    }

                    if ((p[0] == p[1] && p[1] == p[2] && p[2] == p[3] && p[3] == p[4]) || (p[1] == p[2] && p[2] == p[3] && p[3] == p[4] && p[4] == p[5]))
                    {
                        total = total + (bet * 4 * multipleicons);
                    }

                    if (p[0] == p[1] && p[1] == p[2] && p[2] == p[3] && p[3] == p[4] && p[4] == p[5])
                    {
                        total = total + (bet * 10 * multipleicons);
                    }
                }

                credits = credits + total;
                
                //rewriting label 2 and 6
                label6.Text = "Win: " + total.ToString();
                label2.Text = "Magic Coins: " + credits.ToString();


                try
                {
                    //opening connection with db
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into Πίνακας1(Bet,Win,Total,Icons,Lines) values('" + bet + "','" + total + "','" + credits + "','" + icons + "','" + lines + "')";

                    //closing connection with db
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
                

            }
        }

        //buuton which create form2 and display the db
        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        //MessageBox with information about the game 
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  pragmata   ");
        }

        private void πίνακας1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.πίνακας1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

    }
}
