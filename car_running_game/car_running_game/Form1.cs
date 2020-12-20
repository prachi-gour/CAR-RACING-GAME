using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_running_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
        }
        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500) { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500) { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500) { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500) { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

        }
        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            
            if (enemycar2.Top >= 500)
            {
                x = r.Next(0, 100);
                enemycar2.Location = new Point(x, 0);
            }
            else { enemycar2.Top += speed; }
            if (enemycar3.Top >= 500)
            {
                x = r.Next(50, 120);
                enemycar3.Location = new Point(x, 0);
            }
            else { enemycar3.Top += speed; }

            if (enemycar4.Top >= 500)
            {
                x = r.Next(90, 190);
                enemycar4.Location = new Point(x, 0);
            }
            else { enemycar4.Top += speed; }

           
        }
        int collectedcoins = 0;

        void coins(int speed)
        {

            if (coin1.Top >= 500)
            {
                x = r.Next(0, 100);
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 100);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(0, 100);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = r.Next(0, 100);
                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }
        }

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                label2.Text = "Coins =" + collectedcoins.ToString();
                x = r.Next(0, 100);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                label2.Text = "Coins =" + collectedcoins.ToString();
                x = r.Next(0, 100);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                label2.Text = "Coins =" + collectedcoins.ToString();
                x = r.Next(0, 100);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                label2.Text = "Coins =" + collectedcoins.ToString();
                x = r.Next(0, 100);
                coin4.Location = new Point(x, 0);
            }
        }



            int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                { car.Left += -8; }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 295)
                { car.Left += 8; }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                { gamespeed--; }
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        void gameover()
        {
            if(car.Bounds.IntersectsWith(enemycar2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemycar3.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemycar4.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
           
        }
    }
}
