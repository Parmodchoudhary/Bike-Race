using System;
using System.Windows.Forms;

namespace Bike_Race.Classes
{
    class Bike
    {
        public string name { get; set; }
        public int startingPosition { get; set; }
        public int raceTrackLength { get; set; }
        public PictureBox bikePicture = null;
        public bool winner = false;
        public int location = 0;
        public int oddsFor, oddsAgainst;

        public Random randomizer = new Random();

        public bool Run()
        {
            int move = randomizer.Next(1, 6);
            location = location + move;
            bikePicture.Left = startingPosition + location;
            if(bikePicture.Right >= raceTrackLength)
            {
                winner = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            location = 0;
            bikePicture.Left = startingPosition;
        }
    }
}
