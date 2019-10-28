using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickupSticks
{
    public partial class Main : Form
    {

        bool Start;
        int TotalPlayers;
        int TotalSticks;
        int PickupRange;

        int CurrentPlayer;
        int CurrentSticks;

        public Main()
        {
            InitializeComponent();
        }
        
        private void SettingsLabel_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Start = !Start;

            if(Start)
            {
                //init stat
                TotalPlayers = Convert.ToInt16(TotalPlayersTextbox.Text);
                TotalSticks = Convert.ToInt16(TotalSticksTextbox.Text);
                PickupRange = Convert.ToInt16(PickUpRangeTextbox.Text);
                CurrentPlayer = 1;
                CurrentSticks = TotalSticks;
                CurrentPlayerLabel.Text = "Player " + Convert.ToString(CurrentPlayer);
                CurrentSticksLabel.Text = Convert.ToString(CurrentSticks);

                //disable settings
                TotalPlayersTextbox.Enabled = false;
                TotalSticksTextbox.Enabled = false;
                PickUpRangeTextbox.Enabled = false;

                //enable game
                PickUpAmountTextbox.Enabled = true;
                PickUpButton.Enabled = true;
                StartButton.Text = "Restart";
            }
            else
            {
                //enable settings
                TotalPlayersTextbox.Enabled = true;
                TotalSticksTextbox.Enabled = true;
                PickUpRangeTextbox.Enabled = true;

                //disable game
                PickUpAmountTextbox.Enabled = false;
                PickUpButton.Enabled = false;
                StartButton.Text = "Start";
            }
        }

        private void PickUpButton_Click(object sender, EventArgs e)
        {
            //game progress
            if(CurrentSticks > 0)
            {
                if(Convert.ToInt16(PickUpAmountTextbox.Text) <= PickupRange && Convert.ToInt16(PickUpAmountTextbox.Text) > 0)
                {
                    //pick up sticks
                    CurrentSticks -= Convert.ToInt16(PickUpAmountTextbox.Text);
                    CurrentSticksLabel.Text = Convert.ToString(CurrentSticks);

                    //next player
                    if (CurrentPlayer < TotalPlayers)
                    {
                        CurrentPlayer++;
                    }
                    else
                    {
                        CurrentPlayer = 1;
                    }
                    CurrentPlayerLabel.Text = "Player " + Convert.ToString(CurrentPlayer);
                }

            }


            //check win status
            if(CurrentSticks <= 0)
            {
                //disable game
                CurrentSticksLabel.Text = "0";
                PickUpAmountTextbox.Enabled = false;
                PickUpButton.Enabled = false;
                MessageBox.Show(CurrentPlayerLabel.Text + " Wins!");
            }
        }
    }
}
