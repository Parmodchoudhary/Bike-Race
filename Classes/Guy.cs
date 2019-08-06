using System.Windows.Forms;

namespace Bike_Race.Classes
{
    class Guy : Bet
    {
        public Bet bet;
        public int cash { get; set; }

        public RadioButton radioBtn;
        public Label label;

        public void UpdateLabels()
        {
            radioBtn.Text = name + " has $" + cash;
        }

        public void ClearBet()
        {
            bet = null;
            label.Text = name + " hasn't placed any bets.";
        }

        public bool PlaceBet(int betAmount, string bikerToWin, int test)
        {
            this.bet = new Bet() { amount = betAmount, biker = bikerToWin, odds = test };
            if (betAmount >= cash)
            {
                label.Text = this.name + " bets $" + betAmount + " on " + bikerToWin;
                this.UpdateLabels();
                return true;
            }
            else
            {
                MessageBox.Show(name + " does not have enough to cover that bet");
                this.bet = null;
                return false;
            }
        }

        public void Collect(string winner)
        {
            if (bet != null)
                cash += bet.Payout(winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
