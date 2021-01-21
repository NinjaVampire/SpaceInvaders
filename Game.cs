using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceAIDS
{
    public partial class Game : Form
    {
        int health = 3;
        int enemyDamage = 1;
        int score, enemySpeed, buffSpeed, asteroidSpeed, bulletSpeed;
        int playerSpeed = 5;
        Random rnd = new Random();
        bool goLeft, goRight, shooting;
        System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Properties.Resources.music);
        System.Media.SoundPlayer gameOverSound = new System.Media.SoundPlayer(Properties.Resources.gameOver);

        public Game()
        {
            InitializeComponent();
            base.DoubleBuffered = true;
            Reset();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                goLeft = true;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                goRight = true;
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                goLeft = false;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                goRight = false;
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                pB_Bullet.Top = pB_Player.Top - 42;
                pB_Bullet.Left = pB_Player.Left + (pB_Player.Width / 2);
            }
        }



        private void gameOver()
        {
            //gameOver_sound.Play();
            timer_Game.Stop();
            label_Score.Text += Environment.NewLine + "Game Over!" + Environment.NewLine + $@"Score: {score}";
        }

        private void LoseHealth()
        {
                if (health == 3)
                {
                    health -= enemyDamage;
                    pB_Health1.Image = Properties.Resources.emptyHeart;
                    this.enemyDamage = 0;
                }
                else if (health == 2)
                {
                    health -= enemyDamage;
                    pB_Health2.Image = Properties.Resources.emptyHeart;
                    this.enemyDamage = 0;
                }
                else if (health == 1)
                {
                    health -= enemyDamage;
                    pB_Health3.Image = Properties.Resources.emptyHeart;
                    this.enemyDamage = 0;
                }
                else if (health == 0)
                {
                    gameOver();
                }
        }

        private void DeSpawnEnemy()
        {
            if (pB_Bullet.Bounds.IntersectsWith(pB_Enemy1.Bounds))
            {
                score++;

                pB_Enemy1.Top = -450;
                pB_Enemy1.Left = rnd.Next(20, 510);

                shooting = false;
            }
            if (pB_Bullet.Bounds.IntersectsWith(pB_Enemy2.Bounds))
            {
                score++;

                pB_Enemy2.Top = -720;
                pB_Enemy2.Left = rnd.Next(20, 510);

                shooting = false;
            }
            if (pB_Bullet.Bounds.IntersectsWith(pB_Enemy3.Bounds))
            {
                score++;

                pB_Enemy3.Top = -630;
                pB_Enemy3.Left = rnd.Next(20, 510);

                shooting = false;
            }
            if (pB_Bullet.Bounds.IntersectsWith(pB_Asteroid1.Bounds))
            {
                pB_Asteroid1.Top = -450;
                pB_Asteroid1.Left = rnd.Next(20, 510);

                shooting = false;
            }
            if (pB_Bullet.Bounds.IntersectsWith(pB_Asteroid2.Bounds))
            {
                pB_Asteroid2.Top = -720;
                pB_Asteroid2.Left = rnd.Next(20, 510);

                shooting = false;
            }
            if (pB_Bullet.Bounds.IntersectsWith(pB_Asteroid3.Bounds))
            {
                pB_Asteroid3.Top = -630;
                pB_Asteroid3.Left = rnd.Next(20, 510);

                shooting = false;
            }
        }

        private void timer_Game_Tick(object sender, EventArgs e)
        {
            label_Score.Text = $@"Score: {score}";

            //Движението започва тук
            pB_Enemy1.Top += enemySpeed;
            pB_Enemy2.Top += enemySpeed;
            pB_Enemy3.Top += enemySpeed;
            pB_Asteroid1.Top += asteroidSpeed;
            pB_Asteroid2.Top += asteroidSpeed;
            pB_Asteroid3.Top += asteroidSpeed;
            pB_Buff.Top += buffSpeed;


            if (pB_Enemy1.Top > 569)
            {
                LoseHealth();
            }
            else if (pB_Enemy2.Top > 569)
            {
                LoseHealth();
            }
            else if (pB_Enemy3.Top > 569)
            {
                LoseHealth();
            }

            if (goLeft == true && pB_Player.Left > 0)
            {
                pB_Player.Left -= playerSpeed;
            }
            if (goRight == true && pB_Player.Left < 510)
            {
                pB_Player.Left += playerSpeed;
            }
            //Движението свършва тук

            //Проверка на boundary-тата започва тук
            if (pB_Player.Bounds.IntersectsWith(pB_Buff.Bounds))
            {
                pB_Bullet.Image = Properties.Resources.bullet2;
            }
            if (pB_Player.Bounds.IntersectsWith(pB_Enemy1.Bounds) || pB_Player.Bounds.IntersectsWith(pB_Enemy2.Bounds) || pB_Player.Bounds.IntersectsWith(pB_Enemy3.Bounds))
            {
                LoseHealth();
            }
            else if (pB_Player.Bounds.IntersectsWith(pB_Asteroid1.Bounds) || pB_Player.Bounds.IntersectsWith(pB_Asteroid2.Bounds) || pB_Player.Bounds.IntersectsWith(pB_Asteroid3.Bounds))
            {
                LoseHealth();
            }

            if (shooting == true)
            {
                bulletSpeed = 30;
                pB_Bullet.Top -= bulletSpeed;
            }
            else
            {
                pB_Bullet.Left = -300;
                bulletSpeed = 0;
            }

            if (pB_Bullet.Bounds.IntersectsWith(pB_Enemy1.Bounds))
            {
                DeSpawnEnemy();
            }
            if (pB_Bullet.Bounds.IntersectsWith(pB_Enemy2.Bounds))
            {
                DeSpawnEnemy();
            }
            if (pB_Bullet.Bounds.IntersectsWith(pB_Enemy3.Bounds))
            {
                DeSpawnEnemy();
            }
            if (pB_Bullet.Bounds.IntersectsWith(pB_Asteroid1.Bounds))
            {
                DeSpawnEnemy();
            }
            if (pB_Bullet.Bounds.IntersectsWith(pB_Asteroid2.Bounds))
            {
                DeSpawnEnemy();
            }
            if (pB_Bullet.Bounds.IntersectsWith(pB_Asteroid3.Bounds))
            {
                DeSpawnEnemy();
            }

            if (pB_Bullet.Top < -30)
            {
                shooting = false;
            }

            if (score == 10)
            {
                enemySpeed = 10;
            }
        }

        private void Reset()
        {
            timer_Game.Start();
            enemySpeed = 6;
            asteroidSpeed = 1;
            buffSpeed = 7;
            score = 0;
            bulletSpeed = 0;
            pB_Bullet.Left = -300;
            shooting = false;

            pB_Enemy1.Left = rnd.Next(20, 580);
            pB_Enemy2.Left = rnd.Next(20, 580);
            pB_Enemy3.Left = rnd.Next(20, 580);
            pB_Asteroid1.Left = rnd.Next(20, 580);
            pB_Asteroid2.Left = rnd.Next(20, 580);
            pB_Asteroid3.Left = rnd.Next(20, 580);

            pB_Enemy1.Top = rnd.Next(0, 200) * -1;
            pB_Enemy2.Top = rnd.Next(0, 500) * -1;
            pB_Enemy3.Top = rnd.Next(0, 900) * -1;
            pB_Asteroid1.Top = rnd.Next(0, 690) * -1;
            pB_Asteroid2.Top = rnd.Next(0, 420) * -1;
            pB_Asteroid3.Top = rnd.Next(0, 835) * -1;
        }
    }
}
