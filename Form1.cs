using Bike_Race.Classes;
using System;
using System.Windows.Forms;

namespace Bike_Race
{
    public partial class Form1 : Form
    {

        Bike[] bikers = new Bike[4];
        Guy[] bettor = new Guy[3];
        Random randomizer = new Random();
        private int player1 = 0, player2 = 0, player3 = 0;
        private bool bet = false;
        public string winningRider;
        public int odds;
        private string[] riders = new string[4] {
                "Valentino Rossi",
                "Marc Marquez",
                "Casey Stoner",
                "Jorge Lorenzo" };
        private string[] gamblers = new string[3] { "Joe", "Nick", "Hadi" };

        public Form1()
        {
            InitializeComponent();

            bikers[0] = new Bike() { bikePicture = bikeBlue, name = riders[0], raceTrackLength = raceTrack.Width - bikeBlue.Left, randomizer = randomizer, oddsFor = randomizer.Next(1, 3), oddsAgainst = randomizer.Next(2, 8) };
            bikers[1] = new Bike() { bikePicture = bikePurple, name = riders[1], raceTrackLength = raceTrack.Width - bikePurple.Left, randomizer = randomizer, oddsFor = randomizer.Next(1, 3), oddsAgainst = randomizer.Next(2, 14) };
            bikers[2] = new Bike() { bikePicture = bikeRed, name = riders[2], raceTrackLength = raceTrack.Width - bikeRed.Left, randomizer = randomizer, oddsFor = randomizer.Next(1, 3), oddsAgainst = randomizer.Next(2, 12) };
            bikers[3] = new Bike() { bikePicture = bikeYellow, name = riders[3], raceTrackLength = raceTrack.Width - bikeYellow.Left, randomizer = randomizer, oddsFor = randomizer.Next(1, 3), oddsAgainst = randomizer.Next(2, 10) };

            bettor[0] = new Guy() { bet = null, name = gamblers[0], label = player1Bet, cash = 50, radioBtn = radioButton1 };
            bettor[1] = new Guy() { bet = null, name = gamblers[1], label = player2Bet, cash = 75, radioBtn = radioButton2 };
            bettor[2] = new Guy() { bet = null, name = gamblers[2], label = player3Bet, cash = 45, radioBtn = radioButton3 };

            for (int i = 0; i < bettor.Length; i++)
            {
                bettor[i].UpdateLabels();
            }

            ridersList.Items.AddRange(new object[] {
                riders[0], riders[1], riders[2], riders[3]
            });
            ridersList.Text = riders[0];

            currentBettor.Text = radioButton1.Text;

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled)
                currentBettor.Text = gamblers[0];
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Enabled)
                currentBettor.Text = gamblers[1];
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Enabled)
                currentBettor.Text = gamblers[2];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ridersList.Text.ToString() == riders[0])
            {
                odds = bikers[0].oddsAgainst / bikers[0].oddsFor;
            }
            if (ridersList.Text.ToString() == riders[1])
            {
                odds = bikers[1].oddsAgainst / bikers[1].oddsFor;
            }
            if (ridersList.Text.ToString() == riders[2])
            {
                odds = bikers[2].oddsAgainst / bikers[2].oddsFor;
            }
            if (ridersList.Text.ToString() == riders[3])
            {
                odds = bikers[3].oddsAgainst / bikers[3].oddsFor;
            }

            if (currentBettor.Text == gamblers[0])
            {
                Console.WriteLine(gamblers[0]);
                if (player1 == 0)
                {
                    bet = bettor[0].PlaceBet(Convert.ToInt16(numericUpDown1.Value), ridersList.Text.ToString(), odds);
                    if (bet)
                    {
                        player1 = 1;
                    }
                    else
                    {
                        MessageBox.Show(gamblers[0] + " has already placed a bet");
                    }
                }
            }
            if (currentBettor.Text == gamblers[1])
            {
                if (player2 == 0)
                {
                    bet = bettor[1].PlaceBet(Convert.ToInt16(numericUpDown1.Value), ridersList.Text.ToString(), odds);
                    if (bet)
                    {
                        player2 = 1;
                    }
                    else
                    {
                        MessageBox.Show(gamblers[1] + " has already placed a bet");
                    }
                }
            }
            if (currentBettor.Text == gamblers[2])
            {
                if (player3 == 0)
                {
                    bet = bettor[2].PlaceBet(Convert.ToInt16(numericUpDown1.Value), ridersList.Text.ToString(), odds);
                    if (bet)
                    {
                        player3 = 1;
                    }
                    else
                    {
                        MessageBox.Show(gamblers[2] + " has already placed a bet");
                    }
                }
            }
        }

        private void BeginRace_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bikers.Length; i++)
            {
                bikers[i].TakeStartingPosition();
            }

            player1 = 0;
            player2 = 0;
            player3 = 0;
            beginRace.Enabled = false;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < bikers.Length; i++)
            {
                bikers[i].Run();
                if (bikers[i].Run())
                {
                    timer.Stop();
                    timer.Enabled = false;
                    MessageBox.Show(bikers[i].name + " has won the race");
                    winningRider = bikers[i].name;
                    i = bikers.Length;
                    beginRace.Enabled = true;
                    for (int j = 0; j < bettor.Length; j++)
                    {
                        bettor[j].Collect(winningRider);
                    }
                }
            }
        }

        

    }
}
