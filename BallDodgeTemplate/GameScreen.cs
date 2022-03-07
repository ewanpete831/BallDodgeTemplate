using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallDodgeTemplate
{
    public partial class GameScreen : UserControl
    {
        public static int gsWidth = 600;
        public static int gsHeight = 600;

        bool aKeyDown = false;
        bool wKeyDown = false;
        bool sKeyDown = false;
        bool dKeyDown = false;

        Player p1 = new Player((gsWidth / 2) - 25, (gsHeight / 2) - 5, 5, 5);
        Ball chaseBall = new Ball(0, 0, 5, 5);
        Random randGen = new Random();

        List<Ball> seekerBalls = new List<Ball>();

        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }

        public void InitializeGame()
        {
            int x = randGen.Next(40, gsWidth - 40);
            int y = randGen.Next(40, gsHeight - 40);

            chaseBall.x = x;
            chaseBall.y = y;

            for (int i = 0; i < Form1.difficulty; i++)
            {
                int randXSpeed = randGen.Next(3, 8);
                int randYSpeed = randGen.Next(3, 8);
                seekerBalls.Add(new Ball(randGen.Next(40, gsWidth - 40), (randGen.Next(40, gsHeight - 40)), randXSpeed, randYSpeed));
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aKeyDown = true;
                    break;

                case Keys.W:
                    wKeyDown = true;
                    break;

                case Keys.S:
                    sKeyDown = true;
                    break;

                case Keys.D:
                    dKeyDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aKeyDown = false;
                    break;

                case Keys.W:
                    wKeyDown = false;
                    break;

                case Keys.S:
                    sKeyDown = false;
                    break;

                case Keys.D:
                    dKeyDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            chaseBall.Move();

            foreach (Ball newBall in seekerBalls)
            {
                newBall.Move();
            }

            SendPlayerMove();

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Green, chaseBall.x, chaseBall.y, chaseBall.size, chaseBall.size);
            e.Graphics.FillRectangle(Brushes.Black, p1.x, p1.y, p1.width, p1.height);

            foreach (Ball newBall in seekerBalls)
            {
                e.Graphics.FillEllipse(Brushes.Red, newBall.x, newBall.y, newBall.size, newBall.size);
            }
        }

        private void SendPlayerMove()
        {
            if(aKeyDown == true)
            {
                p1.Move("left");
            }
            if(wKeyDown == true)
            {
                p1.Move("up");
            }
            if (sKeyDown == true)
            {
                p1.Move("down");
            }
            if (dKeyDown == true)
            {
                p1.Move("right");
            }
        }
    }
}
