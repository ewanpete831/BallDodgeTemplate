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

        public static int score, lives;

        Size screenSize;

        List<Ball> seekerBalls = new List<Ball>();
        List<Powerup> powerups = new List<Powerup>();
        int PowerupCount = 0;

        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }

        public void InitializeGame()
        {
            int x = randGen.Next(40, gsWidth - 40);
            int y = randGen.Next(40, gsHeight - 40);

            screenSize = new Size(ClientSize.Width, ClientSize.Height);

            chaseBall.x = x;
            chaseBall.y = y;

            for (int i = 0; i < Form1.difficulty; i++)
            {
                NewSeeker();
            }

            score = 0;
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
            chaseBall.Move(screenSize);

            foreach (Ball newBall in seekerBalls)
            {
                newBall.Move(screenSize);
            }

            SendPlayerMove();

            if(chaseBall.Collison(p1) == true)
            {
                score++;
                NewSeeker();
            }

            foreach(Ball b in seekerBalls)
            {
                if (b.Collison(p1) == true)
                {
                    lives--;
                    if (lives == 0)
                    {
                        gameTimer.Enabled = false;
                        Form1.ChangeScreen(this, new GameOverScreen());
                    }
                }
            }

            SpawnPowerup();

            foreach(Powerup p in powerups)
            {
                p.move();
            }

            foreach(Powerup p in powerups)
            {
                if(p.Collison(p1) == true)
                {
                    if(p.id == 1)
                    {
                        score += 3;
                    }
                    else
                    {
                        lives++;
                    }
                }
            }

            for (int i = 0; i < powerups.Count; i++)
            {
                if(powerups[i].Collison(p1) == true)
                {
                    powerups.RemoveAt(i);
                    break;
                }
                if (powerups[i].y > ClientSize.Height)
                {
                    powerups.RemoveAt(i);
                    break;
                }
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Green, chaseBall.x, chaseBall.y, chaseBall.size, chaseBall.size);
            e.Graphics.FillRectangle(Brushes.Black, p1.x, p1.y, p1.width, p1.height);

            scoreLabel.Text = $"Score: {score}";
            livesLabel.Text = $"Lives: {lives}";

            foreach (Ball newBall in seekerBalls)
            {
                e.Graphics.FillEllipse(Brushes.Maroon, newBall.x, newBall.y, newBall.size, newBall.size);
            }

            foreach (Powerup p in powerups)
            {
                if(p.id == 1)
                {
                    e.Graphics.FillEllipse(Brushes.Gold, p.x, p.y, p.size, p.size);
                }
                else
                {
                    e.Graphics.DrawImage(Properties.Resources.hearticon, p.x, p.y);
                }
            }
        }

        private void SendPlayerMove()
        {
            if(aKeyDown == true)
            {
                p1.Move("left", screenSize);
            }
            if(wKeyDown == true)
            {
                p1.Move("up", screenSize);
            }
            if (sKeyDown == true)
            {
                p1.Move("down", screenSize);
            }
            if (dKeyDown == true)
            {
                p1.Move("right", screenSize);
            }
        }

        private void NewSeeker()
        {
            int x = randGen.Next(40, gsWidth - 40);
            int y = randGen.Next(40, gsHeight - 40);
            int randXSpeed = randGen.Next(2, 9);
            int randYSpeed = randGen.Next(2, 9);
            seekerBalls.Add(new Ball(x, y, randXSpeed, randYSpeed));
        }

        private void SpawnPowerup()
        {
            PowerupCount++;
            if (PowerupCount > Form1.powerupTimer)
            {
                int randX = randGen.Next(40, ClientSize.Width - 40);
                int randID = randGen.Next(1, 3);
                powerups.Add(new Powerup(randID, randX, 0));
                PowerupCount = 0;
            }
        }

    }
}
