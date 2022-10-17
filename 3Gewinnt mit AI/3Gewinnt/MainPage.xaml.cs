using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _3Gewinnt
{
    public partial class MainPage : ContentPage
    {
        private int welcherspieler = 0;
        private int gewonnen = 0;
        private int modus;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Mehrspieler_Clicked(object sender, EventArgs e)
        {
            Mehrspieler.IsVisible = false;
            Einzelspieler.IsVisible = false;
            SpielerText.IsVisible = true;
            SpielerText.Text = "Spieler 1 ist dran";


            B1.IsEnabled = true;
            B2.IsEnabled = true;
            B3.IsEnabled = true;
            B4.IsEnabled = true;
            B5.IsEnabled = true;
            B6.IsEnabled = true;
            B7.IsEnabled = true;
            B8.IsEnabled = true;
            B9.IsEnabled = true;

            B1.Background = Brush.Gray;
            B2.Background = Brush.Gray;
            B3.Background = Brush.Gray;
            B4.Background = Brush.Gray;
            B5.Background = Brush.Gray;
            B6.Background = Brush.Gray;
            B7.Background = Brush.Gray;
            B8.Background = Brush.Gray;
            B9.Background = Brush.Gray;

            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            B4.Text = "";
            B5.Text = "";
            B6.Text = "";
            B7.Text = "";
            B8.Text = "";
            B9.Text = "";

            gewonnen = 0;
            modus = 0;
            Deckfeld.IsVisible = false;
        }

        private void Einzelspieler_Clicked(object sender, EventArgs e)
        {
            Einzelspieler.IsVisible = false;
            Mehrspieler.IsVisible = false;
            SpielerText.IsVisible = true;
            SpielerText.Text = "Du bist dran";


            B1.IsEnabled = true;
            B2.IsEnabled = true;
            B3.IsEnabled = true;
            B4.IsEnabled = true;
            B5.IsEnabled = true;
            B6.IsEnabled = true;
            B7.IsEnabled = true;
            B8.IsEnabled = true;
            B9.IsEnabled = true;

            B1.Background = Brush.Gray;
            B2.Background = Brush.Gray;
            B3.Background = Brush.Gray;
            B4.Background = Brush.Gray;
            B5.Background = Brush.Gray;
            B6.Background = Brush.Gray;
            B7.Background = Brush.Gray;
            B8.Background = Brush.Gray;
            B9.Background = Brush.Gray;

            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            B4.Text = "";
            B5.Text = "";
            B6.Text = "";
            B7.Text = "";
            B8.Text = "";
            B9.Text = "";

            gewonnen = 0;
            modus = 1;
            Deckfeld.IsVisible = false;
        }

        private void B1_Clicked(object sender, EventArgs e)
        {
            if (gewonnen == 0)
            {
                if (welcherspieler == 0)
                {
                    B1.Background = Brush.Red;
                    B1.Text = "Spieler 1";
                    B1.IsEnabled = false;
                    SpielerText.Text = "Spieler 2 ist dran";
                    welcherspieler = 1;
                    GewinTest1();
                }
                else
                {
                    B1.Background = Brush.Green;
                    B1.Text = "Spieler 2";
                    B1.IsEnabled = false;
                    SpielerText.Text = "Spieler 1 ist dran";
                    welcherspieler = 0;
                    GewinTest2();
                }

                if (modus == 1)
                {
                    Gegner();
                }
            }
        }

        private void B2_Clicked(object sender, EventArgs e)
        {
            if (gewonnen == 0)
            {
                if (welcherspieler == 0)
                {
                    B2.Background = Brush.Red;
                    B2.Text = "Spieler 1";
                    B2.IsEnabled = false;
                    SpielerText.Text = "Spieler 2 ist dran";
                    welcherspieler = 1;
                    GewinTest1();
                }
                else
                {
                    B2.Background = Brush.Green;
                    B2.Text = "Spieler 2";
                    B2.IsEnabled = false;
                    SpielerText.Text = "Spieler 1 ist dran";
                    welcherspieler = 0;
                    GewinTest2();
                }

                if (modus == 1)
                {
                    Gegner();
                }
            }
        }

        private void B3_Clicked(object sender, EventArgs e)
        {
            if (gewonnen == 0)
            {
                if (welcherspieler == 0)
                {
                    B3.Background = Brush.Red;
                    B3.Text = "Spieler 1";
                    B3.IsEnabled = false;
                    SpielerText.Text = "Spieler 2 ist dran";
                    welcherspieler = 1;
                    GewinTest1();
                }
                else
                {
                    B3.Background = Brush.Green;
                    B3.Text = "Spieler 2";
                    B3.IsEnabled = false;
                    SpielerText.Text = "Spieler 1 ist dran";
                    welcherspieler = 0;
                    GewinTest2();
                }

                if (modus == 1)
                {
                    Gegner();
                }
            }

        }

        private void B4_Clicked(object sender, EventArgs e)
        {
            if (gewonnen == 0)
            {
                if (welcherspieler == 0)
                {
                    B4.Background = Brush.Red;
                    B4.Text = "Spieler 1";
                    B4.IsEnabled = false;
                    SpielerText.Text = "Spieler 2 ist dran";
                    welcherspieler = 1;
                    GewinTest1();
                }
                else
                {
                    B4.Background = Brush.Green;
                    B4.Text = "Spieler 2";
                    B4.IsEnabled = false;
                    SpielerText.Text = "Spieler 1 ist dran";
                    welcherspieler = 0;
                    GewinTest2();
                }

                if (modus == 1)
                {
                    Gegner();
                }
            }
        }

        private void B5_Clicked(object sender, EventArgs e)
        {
            if (gewonnen == 0)
            {
                if (welcherspieler == 0)
                {
                    B5.Background = Brush.Red;
                    B5.Text = "Spieler 1";
                    B5.IsEnabled = false;
                    SpielerText.Text = "Spieler 2 ist dran";
                    welcherspieler = 1;
                    GewinTest1();
                }
                else
                {
                    B5.Background = Brush.Green;
                    B5.Text = "Spieler 2";
                    B5.IsEnabled = false;
                    SpielerText.Text = "Spieler 1 ist dran";
                    welcherspieler = 0;
                    GewinTest2();
                }

                if (modus == 1)
                {
                    Gegner();
                }
            }
        }

        private void B6_Clicked(object sender, EventArgs e)
        {
            if (gewonnen == 0)
            {
                if (welcherspieler == 0)
                {
                    B6.Background = Brush.Red;
                    B6.Text = "Spieler 1";
                    B6.IsEnabled = false;
                    SpielerText.Text = "Spieler 2 ist dran";
                    welcherspieler = 1;
                    GewinTest1();
                }
                else
                {
                    B6.Background = Brush.Green;
                    B6.Text = "Spieler 2";
                    B6.IsEnabled = false;
                    SpielerText.Text = "Spieler 1 ist dran";
                    welcherspieler = 0;
                    GewinTest2();
                }

                if (modus == 1)
                {
                    Gegner();
                }
            }
        }

        private void B7_Clicked(object sender, EventArgs e)
        {
            if (gewonnen == 0)
            {
                if (welcherspieler == 0)
                {
                    B7.Background = Brush.Red;
                    B7.Text = "Spieler 1";
                    B7.IsEnabled = false;
                    SpielerText.Text = "Spieler 2 ist dran";
                    welcherspieler = 1;
                    GewinTest1();
                }
                else
                {
                    B7.Background = Brush.Green;
                    B7.Text = "Spieler 2";
                    B7.IsEnabled = false;
                    SpielerText.Text = "Spieler 1 ist dran";
                    welcherspieler = 0;
                    GewinTest2();
                }

                if (modus == 1)
                {
                    Gegner();
                }
            }
        }

        private void B8_Clicked(object sender, EventArgs e)
        {
            if (gewonnen == 0)
            {
                if (welcherspieler == 0)
                {
                    B8.Background = Brush.Red;
                    B8.Text = "Spieler 1";
                    B8.IsEnabled = false;
                    SpielerText.Text = "Spieler 2 ist dran";
                    welcherspieler = 1;
                    GewinTest1();
                }
                else
                {
                    B8.Background = Brush.Green;
                    B8.Text = "Spieler 2";
                    B8.IsEnabled = false;
                    SpielerText.Text = "Spieler 1 ist dran";
                    welcherspieler = 0;
                    GewinTest2();
                }

                if (modus == 1)
                {
                    Gegner();
                }
            }
        }

        private void B9_Clicked(object sender, EventArgs e)
        {
            if (gewonnen == 0)
            {
                if (welcherspieler == 0)
                {
                    B9.Background = Brush.Red;
                    B9.Text = "Spieler 1";
                    B9.IsEnabled = false;
                    SpielerText.Text = "Spieler 2 ist dran";
                    welcherspieler = 1;
                    GewinTest1();
                }
                else
                {
                    B9.Background = Brush.Green;
                    B9.Text = "Spieler 2";
                    B9.IsEnabled = false;
                    SpielerText.Text = "Spieler 1 ist dran";
                    welcherspieler = 0;
                    GewinTest2();
                }

                if (modus == 1)
                {
                    Gegner();
                }
            }
        }

        private void GewinTest1()
        {
            if (B1.Text == "Spieler 1" && B2.Text == "Spieler 1" && B3.Text == "Spieler 1")
            {
                SpielerText.Text = "Spieler 1 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B4.Text == "Spieler 1" && B5.Text == "Spieler 1" && B6.Text == "Spieler 1")
            {
                SpielerText.Text = "Spieler 1 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B7.Text == "Spieler 1" && B8.Text == "Spieler 1" && B9.Text == "Spieler 1")
            {
                SpielerText.Text = "Spieler 1 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B1.Text == "Spieler 1" && B4.Text == "Spieler 1" && B7.Text == "Spieler 1")
            {
                SpielerText.Text = "Spieler 1 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B2.Text == "Spieler 1" && B5.Text == "Spieler 1" && B8.Text == "Spieler 1")
            {
                SpielerText.Text = "Spieler 1 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B3.Text == "Spieler 1" && B6.Text == "Spieler 1" && B9.Text == "Spieler 1")
            {
                SpielerText.Text = "Spieler 1 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B1.Text == "Spieler 1" && B5.Text == "Spieler 1" && B9.Text == "Spieler 1")
            {
                SpielerText.Text = "Spieler 1 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B3.Text == "Spieler 1" && B5.Text == "Spieler 1" && B7.Text == "Spieler 1")
            {
                SpielerText.Text = "Spieler 1 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B1.Text != "" && B2.Text != "" && B3.Text != "" && B4.Text != "" && B5.Text != "" && B6.Text != "" && B7.Text != "" && B8.Text != "" && B9.Text != "")
            {
                SpielerText.Text = "Keiner hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
        }

        private void GewinTest2()
        {
            if (B1.Text == "Spieler 2" && B2.Text == "Spieler 2" && B3.Text == "Spieler 2")
            {
                SpielerText.Text = "Spieler 2 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B4.Text == "Spieler 2" && B5.Text == "Spieler 2" && B6.Text == "Spieler 2")
            {
                SpielerText.Text = "Spieler 2 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B7.Text == "Spieler 2" && B8.Text == "Spieler 2" && B9.Text == "Spieler 2")
            {
                SpielerText.Text = "Spieler 2 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B1.Text == "Spieler 2" && B4.Text == "Spieler 2" && B7.Text == "Spieler 2")
            {
                SpielerText.Text = "Spieler 2 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B2.Text == "Spieler 2" && B5.Text == "Spieler 2" && B8.Text == "Spieler 2")
            {
                SpielerText.Text = "Spieler 2 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B3.Text == "Spieler 2" && B6.Text == "Spieler 2" && B9.Text == "Spieler 2")
            {
                SpielerText.Text = "Spieler 2 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B1.Text == "Spieler 2" && B5.Text == "Spieler 2" && B9.Text == "Spieler 2")
            {
                SpielerText.Text = "Spieler 2 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B3.Text == "Spieler 2" && B5.Text == "Spieler 2" && B7.Text == "Spieler 2")
            {
                SpielerText.Text = "Spieler 2 hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
            else if (B1.Text != "" && B2.Text != "" && B3.Text != "" && B4.Text != "" && B5.Text != "" && B6.Text != "" && B7.Text != "" && B8.Text != "" && B9.Text != "")
            {
                SpielerText.Text = "Keiner hat gewonnen";
                gewonnen = 1;
                Mehrspieler.IsVisible = true;
                Mehrspieler.IsEnabled = true;
                Einzelspieler.IsVisible = true;
                Einzelspieler.IsEnabled = true;
            }
        }

        private void Gegner()
        {
            Deckfeld.IsVisible = true;

            //Zeile Links
            if (B1.Text == "Spieler 1" && B2.Text == "Spieler 1")
            {
                B3.Background = Brush.Green;
                B3.Text = "Spieler 2";
                B3.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B2.Text == "Spieler 1" && B3.Text == "Spieler 1")
            {
                B1.Background = Brush.Green;
                B1.Text = "Spieler 2";
                B1.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B1.Text == "Spieler 1" && B3.Text == "Spieler 1")
            {
                B2.Background = Brush.Green;
                B2.Text = "Spieler 2";
                B2.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }

            //Zeile Mitte
            else if (B4.Text == "Spieler 1" && B5.Text == "Spieler 1")
            {
                B6.Background = Brush.Green;
                B6.Text = "Spieler 2";
                B6.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B5.Text == "Spieler 1" && B6.Text == "Spieler 1")
            {
                B4.Background = Brush.Green;
                B4.Text = "Spieler 2";
                B4.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B4.Text == "Spieler 1" && B6.Text == "Spieler 1")
            {
                B5.Background = Brush.Green;
                B5.Text = "Spieler 2";
                B5.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }

            //Zeile Rechts
            else if (B7.Text == "Spieler 1" && B8.Text == "Spieler 1")
            {
                B9.Background = Brush.Green;
                B9.Text = "Spieler 2";
                B9.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B8.Text == "Spieler 1" && B9.Text == "Spieler 1")
            {
                B7.Background = Brush.Green;
                B7.Text = "Spieler 2";
                B7.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B7.Text == "Spieler 1" && B9.Text == "Spieler 1")
            {
                B8.Background = Brush.Green;
                B8.Text = "Spieler 2";
                B8.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }

            //Zeile oben
            else if (B1.Text == "Spieler 1" && B4.Text == "Spieler 1")
            {
                B7.Background = Brush.Green;
                B7.Text = "Spieler 2";
                B7.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B4.Text == "Spieler 1" && B7.Text == "Spieler 1")
            {
                B1.Background = Brush.Green;
                B1.Text = "Spieler 2";
                B1.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B1.Text == "Spieler 1" && B7.Text == "Spieler 1")
            {
                B4.Background = Brush.Green;
                B4.Text = "Spieler 2";
                B4.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }

            //Zeile Mitte
            else if (B2.Text == "Spieler 1" && B5.Text == "Spieler 1")
            {
                B8.Background = Brush.Green;
                B8.Text = "Spieler 2";
                B8.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B5.Text == "Spieler 1" && B8.Text == "Spieler 1")
            {
                B2.Background = Brush.Green;
                B2.Text = "Spieler 2";
                B2.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B2.Text == "Spieler 1" && B8.Text == "Spieler 1")
            {
                B5.Background = Brush.Green;
                B5.Text = "Spieler 2";
                B5.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }

            //Zeile unten
            else if (B3.Text == "Spieler 1" && B6.Text == "Spieler 1")
            {
                B9.Background = Brush.Green;
                B9.Text = "Spieler 2";
                B9.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B6.Text == "Spieler 1" && B9.Text == "Spieler 1")
            {
                B3.Background = Brush.Green;
                B3.Text = "Spieler 2";
                B3.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B3.Text == "Spieler 1" && B9.Text == "Spieler 1")
            {
                B6.Background = Brush.Green;
                B6.Text = "Spieler 2";
                B6.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }

            //Zeile unten links nach oben rechts
            else if (B3.Text == "Spieler 1" && B5.Text == "Spieler 1")
            {
                B7.Background = Brush.Green;
                B7.Text = "Spieler 2";
                B7.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B5.Text == "Spieler 1" && B7.Text == "Spieler 1")
            {
                B3.Background = Brush.Green;
                B3.Text = "Spieler 2";
                B3.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B3.Text == "Spieler 1" && B7.Text == "Spieler 1")
            {
                B5.Background = Brush.Green;
                B5.Text = "Spieler 2";
                B5.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }

            //Zeile unten rechts nach oben links
            else if (B1.Text == "Spieler 1" && B5.Text == "Spieler 1")
            {
                B9.Background = Brush.Green;
                B9.Text = "Spieler 2";
                B9.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B5.Text == "Spieler 1" && B9.Text == "Spieler 1")
            {
                B1.Background = Brush.Green;
                B1.Text = "Spieler 2";
                B1.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            else if (B1.Text == "Spieler 1" && B9.Text == "Spieler 1")
            {
                B5.Background = Brush.Green;
                B5.Text = "Spieler 2";
                B5.IsEnabled = false;
                SpielerText.Text = "Spieler 1 ist dran";
                welcherspieler = 0;
                GewinTest2();
            }
            /*else
            {
                Random rnd = new Random();
                int[] Zahlen = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int zah = rnd.Next(Zahlen.Length);
                var Feld  = "B" + 1;
                Button bt = (Button) ;
                if (bt.Text != "Spieler 1")
                {

                }*/
            Deckfeld.IsVisible = false;
        }
            
    }
}

