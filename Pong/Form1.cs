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

namespace Pong
{
    public partial class Form1 : Form
    {
        int cima = -5, esquerda = -5,
        PointsLeft = 0,
        PointsRight = 0,
        movePong = 7,
        vitese = -5;
        bool LeftScored = true,
            //Detecter Clees Down
            sKeyIsDown = false, 
            zKeyIsDown = false, 
            upKeyIsDown = false, 
            downKeyIsDown = false,
            gameStarted = false;

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void OptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void changerVitese()
        {
            restartGame("aa");
            if (gameStarted == true)
            {
                cima = vitese;
                esquerda = vitese;
            }
        }

        private void LentToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            vitese = -2;        
            
        }

        private void RapideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitese = -5;
        }

        private void MoyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitese = -4;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //movePong = 7;     
            cima = -vitese;
            esquerda = -vitese;
            
            Score.Visible = false;
            btnStart.Visible = false;

            gameStarted = true;

            ActiveForm.Focus();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {            
            Score.Text = "Cfai PONG";
            Score.Visible = true;
            //movePong = 0;
            cima = 0;
            esquerda = 0;


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MiddleBar.Left = ActiveForm.Width / 2;
            MiddleBar.Height = ActiveForm.Height - menuStrip1.Height;
            
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Z:
                    zKeyIsDown = false;                    
                    break;

                case Keys.S:
                    sKeyIsDown = false;
                    break;

                case Keys.Up:
                    upKeyIsDown = false;
                    break;

                case Keys.Down:
                    downKeyIsDown = false;
                    break;

            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {

                case Keys.Z:
                    zKeyIsDown = true;
                    break;

                case Keys.S:
                    sKeyIsDown = true;
                    break;

                case Keys.Up:
                    upKeyIsDown = true;
                    break;

                case Keys.Down:
                    downKeyIsDown = true;
                    break;

            }


        }

        

        private void Timer1_Tick(object sender, EventArgs e)
        {
            

            bola.Top = bola.Top - cima;
            bola.Left = bola.Left - esquerda;

            //Bouger as raquetes
            if (zKeyIsDown == true)
            pongLeft.Top = pongLeft.Top - movePong;
            else pongLeft.Top = pongLeft.Top;

            if (sKeyIsDown == true)
            pongLeft.Top = pongLeft.Top + movePong;
            else pongLeft.Top = pongLeft.Top;

            if (upKeyIsDown == true)
                pongRight.Top = pongRight.Top - movePong;
            else pongRight.Top = pongRight.Top;

            if (downKeyIsDown == true)
                pongRight.Top = pongRight.Top + movePong;
            else pongRight.Top = pongRight.Top;

            //Ne pas laisser la raquete sortir
            if (pongLeft.Bottom >= paredeBase.Top)
                pongLeft.Top = paredeBase.Top - pongLeft.Height;
            else if (pongLeft.Top <= paredeTopo.Bottom)
                pongLeft.Top = paredeTopo.Bottom;
            else if (pongRight.Bottom >= paredeBase.Top)
                pongRight.Top = paredeBase.Top - pongRight.Height;
            else if (pongRight.Top <= paredeTopo.Bottom)
                pongRight.Top = paredeTopo.Bottom;


            //Toques
            if (bola.Top <= paredeTopo.Bottom)
            {
                cima = cima * -1;
            }else if (bola.Bottom >= paredeBase.Bottom)
            {
                cima = cima * -1;
            }else if ((bola.Left <= pongLeft.Right) 
                   && (bola.Top >= pongLeft.Top)
                   && (bola.Bottom <= pongLeft.Bottom))
            {
                esquerda = esquerda * -1;
            }else if ((bola.Right >= pongRight.Left) 
                   && (bola.Top >= pongRight.Top)
                   && (bola.Bottom <= pongRight.Bottom))
            {
                esquerda = esquerda * -1;
            } if ((bola.Right >= RightWall.Left) && (bola.Right > pongRight.Left)) //"Points Left"
            {
                PointsLeft++;
                LeftScored = true;
                restartGame(PointsLeft.ToString());
            }else if ((bola.Left <= LeftWall.Right) && (bola.Left < pongLeft.Right)) //"Points Right"
            {
                PointsRight++;
                LeftScored = false;
                restartGame(PointsRight.ToString());
            }


            //Montrer points
            lPointsLeft.Text = PointsLeft.ToString();
            lPointsRight.Text = PointsRight.ToString();


            //ok - Boujer les deux au meme temps
            //Changer taille player
            //Changer Vitese (progessivement et en choisissent)
            //Changer horizontalement
            //Botao pause
            //Resize
       


            //GlobalTimer++;

        }


        void restartGame(string score)
        {
            Score.Text = "Score!";
            Score.Visible = true;
            //Score.Show();

            //Relancer la position ball
            if (LeftScored) { bola.Left = 300; esquerda = esquerda * -1; }
            else { bola.Left = 400; esquerda = esquerda * -1; }

            Thread.Sleep(1500);
            //Attendre(1);
            Score.Visible = false;            
        }


    }
}
