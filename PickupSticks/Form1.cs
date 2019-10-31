using System;
using System.Windows.Forms;

namespace PickupSticks
{
    public partial class Main : Form
    {

        //Game parameters
        int TotalNumberOfPlayers;
        int MaxNumberOfSticks;
        int PlayerPickupRange;

        //Game status
        bool GameHasStarted;
        int CurrentPlayerTurn;
        int CurrentNumberOfSticks;

        public Main()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if(!GameHasStarted)
            {
                StartGame();
            }
            else
            {
                RestartGame();
            }
        }

        private void PickUpButton_Click(object sender, EventArgs e)
        {
            //game progress
            MakeMove();

            //check win status
            CheckWinStatus();
        }

        private void StartGame()
        {
            //init stat
            ExtractGameParameters();

            CurrentPlayerTurn = 1;
            CurrentNumberOfSticks = MaxNumberOfSticks;

            UpdateGameUI();

            //disable settings
            SetGameSettingsVisibility(false);

            //enable game
            SetGameControlsVisibility(true);

            GameHasStarted = true;
        }

        private void RestartGame()
        {
            //enable settings
            SetGameSettingsVisibility(true);

            //disable game
            SetGameControlsVisibility(false);

            GameHasStarted = false;
        }

        private void MakeMove()
        {
            if (CurrentNumberOfSticks > 0)
            {
                int pickUpAmount = Convert.ToInt16(PickUpAmountTextbox.Text);

                if (pickUpAmount <= PlayerPickupRange && pickUpAmount > 0)
                {
                    //pick up sticks
                    CurrentNumberOfSticks -= pickUpAmount;

                    //next player
                    if (CurrentPlayerTurn < TotalNumberOfPlayers)
                    {
                        CurrentPlayerTurn++;
                    }
                    else
                    {
                        CurrentPlayerTurn = 1;
                    }

                    UpdateGameUI();
                }
            }
        }

        private void CheckWinStatus()
        {
            if (CurrentNumberOfSticks <= 0)
            {
                //disable game
                SetGameControlsVisibility(false);
                DisplayWinner();
            }
        }

        private void SetGameSettingsVisibility(bool status)
        {
            TotalPlayersTextbox.Enabled = status;
            TotalSticksTextbox.Enabled = status;
            PickUpRangeTextbox.Enabled = status;
        }

        private void SetGameControlsVisibility(bool status)
        {
            PickUpAmountTextbox.Enabled = status;
            PickUpButton.Enabled = status;
            StartButton.Text = (status) ? "Restart" : "Start";
        }

        private void ExtractGameParameters()
        {
            TotalNumberOfPlayers = Convert.ToInt16(TotalPlayersTextbox.Text);
            MaxNumberOfSticks = Convert.ToInt16(TotalSticksTextbox.Text);
            PlayerPickupRange = Convert.ToInt16(PickUpRangeTextbox.Text);
        }

        private void UpdateGameUI()
        {
            CurrentPlayerLabel.Text = "Player " + Convert.ToString(CurrentPlayerTurn);
            CurrentSticksLabel.Text = Convert.ToString(CurrentNumberOfSticks);
        }

        private void DisplayWinner()
        {
            CurrentSticksLabel.Text = "0";
            MessageBox.Show(CurrentPlayerLabel.Text + " Wins!");
        }
    }
}
