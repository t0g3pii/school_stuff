using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frogger
{
    public partial class FrmFrogger : Form
    {
        // Deklarationen

        // Die Anzahl an Bereichen auf dem Spielfeld.
        static int anzahlBereiche = 6;

        // Variablen für Dimensionen
        // Wenn eine Variable den Wert "-1" hat, wurde sie noch nicht mit den richtigen Werten gefüllt.
        int breite = -1;
        int hoehe = -1;
        int hoeheJeBereich = -1;
        int breiteJeBereich = -1;

        // Array für alle Bereiche (Start, Bahnen, Ziel)
        Rectangle[] alleBahnen = new Rectangle[anzahlBereiche];
        Rectangle[] alleSchienen = new Rectangle[anzahlBereiche];

        // Listen für die Hindernisse auf den Bahnen
        List<Hindernis> alleHindernisse = new List<Hindernis>();

        Rectangle spieler;

        int spawnRate = 14;
        int spawnZaehler = 0;
        int leftRight = 0;
        int upDown = 0;

        int punkte = 0;
        int lives = 3;

        bool alive = true;
        bool paused = false;

        // Zufalszahlengenerator
        Random rndBahn = new Random();

        // TODO Spieler darf nicht nach unten aus dem Spielfeld laufen
        // TODO Weitere Bewegungen (links, rechts) einbauen
        // TODO Wenn Spieler im Ziel ist, soll er wieder auf Start zurückgesetzt werden und das Spiel soll schwerer werden
        // TODO Kontrollieren, ob Spieler überfahren wurde.


        public FrmFrogger()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size; // 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
        }

        private void FrmFrogger_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SimpleSoundController("start");
        }

        private void SimpleSoundController(string action)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"../../resources/background_audio.wav");
            if (action == "start") { 
                //simpleSound.PlayLooping();
            } else if (action == "pause")
            {
                simpleSound.Stop();
            } else if (action == "verloren")
            {
                //SoundPlayer looseSound = new SoundPlayer("D:/3ds/PRG/school_stuff/Frogger/Frogger/bin/Debug/winxp.wav");
                //looseSound.Play();
            }
        }

        private void FrmFrogger_Paint(object sender, PaintEventArgs e)
        {

            if(tmrGameTick.Enabled == false && !paused)
            {
                breite = this.ClientSize.Width;
                hoehe = this.ClientSize.Height;

                hoeheJeBereich = hoehe / anzahlBereiche;
                breiteJeBereich = breite / anzahlBereiche - 40;


                hoeheJeBereich = hoeheJeBereich + 2;
                breiteJeBereich = breiteJeBereich + 2;


                spieler = new Rectangle((breite / 2) - 15, hoehe - 35, 30, 30);

                for (int i = 0; i < alleBahnen.Length; i++)
                {
                    alleBahnen[i] = new Rectangle(0, i * hoeheJeBereich, breite, hoeheJeBereich);
                }

                tmrGameTick.Start();
            }

            if(tmrGameTick.Enabled == true)
            {
                tmrGameTick.Stop();
                breite = this.ClientSize.Width;
                hoehe = this.ClientSize.Height;

                hoeheJeBereich = hoehe / anzahlBereiche;
                breiteJeBereich = breite / anzahlBereiche - 40;


                hoeheJeBereich = hoeheJeBereich + 2;
                breiteJeBereich = breiteJeBereich + 2;
                for (int i = 0; i < alleBahnen.Length; i++)
                {
                    alleBahnen[i] = new Rectangle(0, i * hoeheJeBereich, breite, hoeheJeBereich);
                }
                tmrGameTick.Start();
            }



            SolidBrush brStart = new SolidBrush(Color.LightBlue);
            SolidBrush brZiel = new SolidBrush(Color.LightYellow);
            SolidBrush brBahnHell = new SolidBrush(Color.LightGray);
            SolidBrush brBahnDunkel = new SolidBrush(Color.Gray);
            
            SolidBrush brSpieler = new SolidBrush(Color.Green);
            Pen pnRand = new Pen(Color.Black, 1);

            e.Graphics.FillRectangles(brBahnHell, alleBahnen);
            e.Graphics.FillRectangle(brBahnDunkel, alleBahnen[2]);
            e.Graphics.FillRectangle(brBahnDunkel, alleBahnen[4]);

            // TODO Bahnen sollen sich in der Farbe abwechseln (brBahnHell, brBahnDunkel)

            e.Graphics.FillRectangle(brZiel, alleBahnen[0]);
            e.Graphics.FillRectangle(brStart, alleBahnen[alleBahnen.Length-1]);
            

            e.Graphics.DrawRectangles(pnRand, alleBahnen);

            GraphicsUnit units = GraphicsUnit.Pixel;
            
            // Autos zeichnen
            // https://de.cleanpng.com
            Image autoImage = Image.FromFile("auto.png");
            Rectangle autoRectangle = new Rectangle(0, 0, 745, 400);
            foreach(Hindernis aktuellesHindernis in alleHindernisse)
            {
                Rectangle rectangleHindernis = new Rectangle(aktuellesHindernis.X, aktuellesHindernis.Y, aktuellesHindernis.Width, aktuellesHindernis.Height);
                e.Graphics.DrawImage(autoImage, rectangleHindernis, autoRectangle, units);
            }

            // Frosch zeichnen
            // https://de.cleanpng.com
            Image froschImage = Image.FromFile("frosch.png");
            Rectangle rectangleImage = new Rectangle(0, 0, 550, 550);
            e.Graphics.DrawImage(froschImage, spieler, rectangleImage, units);


            if (lives > 0)
            {
                Image heartImage = Image.FromFile("heart.png");
                Image heartEmptyImage = Image.FromFile("heartEmpty.png");
                Rectangle heartRectangle = new Rectangle(0, 0, 32, 32);
                Rectangle liveOne = new Rectangle(330, 10, 32, 32);
                Rectangle liveTwo = new Rectangle(365, 10, 32, 32);
                Rectangle liveThree = new Rectangle(400, 10, 32, 32);
                if (lives == 1)
                {
                    e.Graphics.DrawImage(heartImage, liveOne, heartRectangle, units);
                    e.Graphics.DrawImage(heartEmptyImage, liveTwo, heartRectangle, units);
                    e.Graphics.DrawImage(heartEmptyImage, liveThree, heartRectangle, units);
                }
                if (lives == 2) {
                    e.Graphics.DrawImage(heartImage, liveOne, heartRectangle, units);
                    e.Graphics.DrawImage(heartImage, liveTwo, heartRectangle, units);
                    e.Graphics.DrawImage(heartEmptyImage, liveThree, heartRectangle, units);
                }
                if (lives == 3) {
                    e.Graphics.DrawImage(heartImage, liveOne, heartRectangle, units);
                    e.Graphics.DrawImage(heartImage, liveTwo, heartRectangle, units);
                    e.Graphics.DrawImage(heartImage, liveThree, heartRectangle, units);
                }
            }
            else
            {
                pnlHighscore.Enabled = true;
                pnlHighscore.Visible = true;
                lblScoreBox.Text = lblScoreBox.Text + ' ' + punkte;
                paused = true;
                tmrGameTick.Stop();
            }

        }

        private void tmrGameTick_Tick(object sender, EventArgs e)
        {
            spawnZaehler++;
            if(spawnZaehler == spawnRate)
            {
                spawnZaehler = 0;


                int zufall = rndBahn.Next(1, anzahlBereiche-1);
                int yWertDerBahn = alleBahnen[zufall].Top;

                alleHindernisse.Add(new Hindernis(breite, yWertDerBahn, 60, hoeheJeBereich, 10, Color.Red));
            }


            foreach (Hindernis aktuellesHindernis in alleHindernisse)
            {
                aktuellesHindernis.Move();
            }

            for(int i = alleHindernisse.Count -1; i >= 0; i--)
            { 
                if ((alleHindernisse[i].X + alleHindernisse[i].Width) < 0)
                {
                    alleHindernisse.RemoveAt(i);

                }
            }

            foreach(Hindernis hindernis in alleHindernisse)
            {
                if((spieler.Right > hindernis.X && spieler.Right < hindernis.X + hindernis.Width && spieler.Y > hindernis.Y && spieler.Y < hindernis.Y + hoeheJeBereich) || (spieler.Left > hindernis.X && spieler.Left < hindernis.X + hindernis.Width && spieler.Y > hindernis.Y && spieler.Y < hindernis.Y + hoeheJeBereich))
                {
                    // verloren
                    if(lives == 0) { 
                        punkte = 0;
                        upDown = 0;
                        SimpleSoundController("verloren");
                        tmrGameTick.Stop();
                    } else
                    {
                        lives = lives - 1;
                        upDown = 0;
                        SimpleSoundController("verloren");
                        tmrGameTick.Stop();
                    }
                }
            }
            // .Active == true, CanFocus == true || = Cash wenn raus aus Game
            if(this.Focused == true)
            {
                FrmFrogger.ActiveForm.Text = "Frogger - Y:  " + upDown + " - X: " + leftRight + " - Score: " + punkte + " - Leben: " + lives;
            }

            if (upDown == 5)
            {
                upDown = 0;
                spieler.Y = hoehe - 35;
                punkte = punkte + 1;
                

            }
            this.Refresh();
        }

        private void FrmFrogger_KeyDown(object sender, KeyEventArgs e)
        {
            var spielerX = spieler.X;
            var spielerY = spieler.Y;

            if (e.KeyCode == Keys.Up)
            {
                if (upDown < 5 && alive == true && paused == false) { 
                    spieler.Y = spieler.Y - hoeheJeBereich;
                    upDown = upDown + 1;
                    
                }
            }

            if(e.KeyCode == Keys.Down)
            {
                if(upDown > 0 && alive == true && paused == false) { 
                    spieler.Y = spieler.Y + hoeheJeBereich;
                    upDown = upDown - 1;
                    
                }
            }

            if(e.KeyCode == Keys.Left)
            {
                if(leftRight > -6 && alive == true && paused == false)
                {
                    spieler.X = spieler.X - breiteJeBereich;
                    leftRight = leftRight - 1;
                    
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (leftRight < 6 && alive == true && paused == false)
                {
                    spieler.X = spieler.X + breiteJeBereich;
                    leftRight = leftRight + 1;
                    
                }
            }

            if(e.KeyCode == Keys.Escape)
            {
                if (paused == false) { 
                    paused = true;
                    tmrGameTick.Stop();
                    pnlPause.Enabled = true;
                    pnlPause.Visible = true;
                    SimpleSoundController("pause");
                } else
                {
                    paused = false;
                    tmrGameTick.Start();
                    pnlPause.Enabled = false;
                    pnlPause.Visible = false;
                    SimpleSoundController("start");
                }
            }

            if(e.KeyCode == Keys.D)
            {
                MessageBox.Show("[DEBUG INFORMATIONEN]" +
                                "\nSpieler X: " + spieler.X +
                                "\nSpieler Y: " + spieler.Y +
                                "\nSpieler UpDown: " + upDown + 
                                "\nSpieler leftRight: " + leftRight + 
                                "\nAlive?: " + alive + 
                                "\nPaused?: " + paused +
                                "\nSpielerX2: " + spielerX +
                                "\nSpielerY2: " + spielerY);
            }



            this.Refresh();
        }

        private void FrmFrogger_Resize(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            paused = false;
            tmrGameTick.Start();
            pnlPause.Enabled = false;
            pnlPause.Visible = false;
        }

        private void BtnScoreSave_Click(object sender, EventArgs e)
        {
            pnlHighscore.Enabled = false;
            pnlHighscore.Visible = false;
            paused = false;
            lives = 3; 
            tmrGameTick.Start();
        }
    }
}
