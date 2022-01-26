﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        // Zufalszahlengenerator
        Random rndBahn = new Random();

        // TODO Spieler darf nicht nach unten aus dem Spielfeld laufen
        // TODO Weitere Bewegungen (links, rechts) einbauen
        // TODO Wenn Spieler im Ziel ist, soll er wieder auf Start zurückgesetzt werden und das Spiel soll schwerer werden
        // TODO Kontrollieren, ob Spieler überfahren wurde.


        public FrmFrogger()
        {
            InitializeComponent();
        }

        private void FrmFrogger_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        private void FrmFrogger_Paint(object sender, PaintEventArgs e)
        {

            if(tmrGameTick.Enabled == false)
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



            SolidBrush brStart = new SolidBrush(Color.LightBlue);
            SolidBrush brZiel = new SolidBrush(Color.LightYellow);
            SolidBrush brBahnHell = new SolidBrush(Color.LightGray);
            SolidBrush brBahnDunkel = new SolidBrush(Color.Gray);
            SolidBrush brSpieler = new SolidBrush(Color.Green);
            Pen pnRand = new Pen(Color.Black, 1);


            e.Graphics.FillRectangles(brBahnHell, alleBahnen);

            // TODO Bahnen sollen sich in der Farbe abwechseln (brBahnHell, brBahnDunkel)

            e.Graphics.FillRectangle(brZiel, alleBahnen[0]);
            e.Graphics.FillRectangle(brStart, alleBahnen[alleBahnen.Length-1]);
            

            e.Graphics.DrawRectangles(pnRand, alleBahnen);


            foreach(Hindernis aktuellesHindernis in alleHindernisse)
            {
                e.Graphics.FillRectangle(
                    aktuellesHindernis.Brush,
                    aktuellesHindernis.X,
                    aktuellesHindernis.Y,
                    aktuellesHindernis.Width,
                    aktuellesHindernis.Height);
            }


            e.Graphics.FillEllipse(brSpieler, spieler);


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

            // Kann nicht funktionieren weil X&Y von Hindernisse anders ist, Konvertierung wäre nötig
            // Spieler basiert auf Bereiche, Hindernisse auf die ClientSize für Y
            //for(int i = alleHindernisse.Count; i < 0; i++)
            //{
            //    if(alleHindernisse[i].X == spieler.X && alleHindernisse[i].Y == spieler.Y)
            //    {
            //        FrmFrogger.ActiveForm.Text = "Frogger - VERLOREN";
            //    }
            //}

            this.Refresh();
        }

        private void FrmFrogger_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                if(upDown < 5) { 
                    spieler.Y = spieler.Y - hoeheJeBereich;
                    upDown = upDown + 1;
                    FrmFrogger.ActiveForm.Text = "Frogger - X:  " + upDown + " - Y: " + leftRight;
                }
            }

            if(e.KeyCode == Keys.Down)
            {
                if(upDown > 0) { 
                    spieler.Y = spieler.Y + hoeheJeBereich;
                    upDown = upDown - 1;
                    FrmFrogger.ActiveForm.Text = "Frogger - X:  " + upDown + " - Y: " + leftRight;
                }
            }

            if(e.KeyCode == Keys.Left)
            {
                if(leftRight > -6)
                {
                    spieler.X = spieler.X - breiteJeBereich;
                    leftRight = leftRight - 1;
                    FrmFrogger.ActiveForm.Text = "Frogger - X:  " + upDown + " - Y: " + leftRight;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (leftRight < 6)
                {
                    spieler.X = spieler.X + breiteJeBereich;
                    leftRight = leftRight + 1;
                    FrmFrogger.ActiveForm.Text = "Frogger - X:  " + upDown + " - Y: " + leftRight;
                }
            }

            this.Refresh();
        }
    }
}
