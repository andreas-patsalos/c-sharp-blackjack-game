using BlackjackGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackGame
{
    public partial class Form2 : Form
    {
        // Globals
        Random rand = new Random();
        int dealerHand = 0;
        int playerHand = 0;

        void checkWin()
        {
            if (playerHand > 21)
            {
                MessageBox.Show("Busted. You lost your bet.", "You lose", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Windows.Forms.Application.Exit();
            }
            if (dealerHand > 21)
            {
                MessageBox.Show("Dealer is busted. You win the game.", "You win", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Windows.Forms.Application.Exit();
            }
        }
      
        void dealCards()
        {
            int randomCard = rand.Next(1, 53);
            
            switch (randomCard)
            {
                case 1:
                    pictureBox1.BackgroundImage = Resources.AC;
                    playerHand += 11;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Resources.AD;
                    playerHand += 11;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Resources.AH;
                    playerHand += 11;
                    break;
                case 4:
                    pictureBox1.BackgroundImage = Resources.AS;
                    playerHand += 11;
                    break;
                case 5:
                    pictureBox1.BackgroundImage = Resources._2C;
                    playerHand += 2;
                    break;
                case 6:
                    pictureBox1.BackgroundImage = Resources._2D;
                    playerHand += 2;
                    break;
                case 7:
                    pictureBox1.BackgroundImage = Resources._2H;
                    playerHand += 2;
                    break;
                case 8:
                    pictureBox1.BackgroundImage = Resources._2S;
                    playerHand += 2;
                    break;
                case 9:
                    pictureBox1.BackgroundImage = Resources._3C;
                    playerHand += 3;
                    break;
                case 10:
                    pictureBox1.BackgroundImage = Resources._3D;
                    playerHand += 3;
                    break;
                case 11:
                    pictureBox1.BackgroundImage = Resources._3H;
                    playerHand += 3;
                    break;
                case 12:
                    pictureBox1.BackgroundImage = Resources._3S;
                    playerHand += 3;
                    break;
                case 13:
                    pictureBox1.BackgroundImage = Resources._4C;
                    playerHand += 4;
                    break;
                case 14:
                    pictureBox1.BackgroundImage = Resources._4D;
                    playerHand += 4;
                    break;
                case 15:
                    pictureBox1.BackgroundImage = Resources._4H;
                    playerHand += 4;
                    break;
                case 16:
                    pictureBox1.BackgroundImage = Resources._4S;
                    playerHand += 4;
                    break;
                case 17:
                    pictureBox1.BackgroundImage = Resources._5C;
                    playerHand += 5;
                    break;
                case 18:
                    pictureBox1.BackgroundImage = Resources._5D;
                    playerHand += 5;
                    break;
                case 19:
                    pictureBox1.BackgroundImage = Resources._5H;
                    playerHand += 5;
                    break;
                case 20:
                    pictureBox1.BackgroundImage = Resources._5S;
                    playerHand += 5;
                    break;
                case 21:
                    pictureBox1.BackgroundImage = Resources._6C;
                    playerHand += 6;
                    break;
                case 22:
                    pictureBox1.BackgroundImage = Resources._6D;
                    playerHand += 6;
                    break;
                case 23:
                    pictureBox1.BackgroundImage = Resources._6H;
                    playerHand += 6;
                    break;
                case 24:
                    pictureBox1.BackgroundImage = Resources._6S;
                    playerHand += 6;
                    break;
                case 25:
                    pictureBox1.BackgroundImage = Resources._7C;
                    playerHand += 7;
                    break;
                case 26:
                    pictureBox1.BackgroundImage = Resources._7D;
                    playerHand += 7;
                    break;
                case 27:
                    pictureBox1.BackgroundImage = Resources._7H;
                    playerHand += 7;
                    break;
                case 28:
                    pictureBox1.BackgroundImage = Resources._7S;
                    playerHand += 7;
                    break;
                case 29:
                    pictureBox1.BackgroundImage = Resources._8C;
                    playerHand += 8;
                    break;
                case 30:
                    pictureBox1.BackgroundImage = Resources._8D;
                    playerHand += 8;
                    break;
                case 31:
                    pictureBox1.BackgroundImage = Resources._8H;
                    playerHand += 8;
                    break;
                case 32:
                    pictureBox1.BackgroundImage = Resources._8S;
                    playerHand += 8;
                    break;
                case 33:
                    pictureBox1.BackgroundImage = Resources._9C;
                    playerHand += 9;
                    break;
                case 34:
                    pictureBox1.BackgroundImage = Resources._9D;
                    playerHand += 9;
                    break;
                case 35:
                    pictureBox1.BackgroundImage = Resources._9H;
                    playerHand += 9;
                    break;
                case 36:
                    pictureBox1.BackgroundImage = Resources._9S;
                    playerHand += 9;
                    break;
                case 37:
                    pictureBox1.BackgroundImage = Resources._10C;
                    playerHand += 10;
                    break;
                case 38:
                    pictureBox1.BackgroundImage = Resources._10D;
                    playerHand += 10;
                    break;
                case 39:
                    pictureBox1.BackgroundImage = Resources._10H;
                    playerHand += 10;
                    break;
                case 40:
                    pictureBox1.BackgroundImage = Resources._10S;
                    playerHand += 10;
                    break;
                case 41:
                    pictureBox1.BackgroundImage = Resources.JC;
                    playerHand += 10;
                    break;
                case 42:
                    pictureBox1.BackgroundImage = Resources.JD;
                    playerHand += 10;
                    break;
                case 43:
                    pictureBox1.BackgroundImage = Resources.JH;
                    playerHand += 10;
                    break;
                case 44:
                    pictureBox1.BackgroundImage = Resources.JS;
                    playerHand += 10;
                    break;
                case 45:
                    pictureBox1.BackgroundImage = Resources.QC;
                    playerHand += 10;
                    break;
                case 46:
                    pictureBox1.BackgroundImage = Resources.QD;
                    playerHand += 10;
                    break;
                case 47:
                    pictureBox1.BackgroundImage = Resources.QH;
                    playerHand += 10;
                    break;
                case 48:
                    pictureBox1.BackgroundImage = Resources.QS;
                    playerHand += 10;
                    break;
                case 49:
                    pictureBox1.BackgroundImage = Resources.KC;
                    playerHand += 10;
                    break;
                case 50:
                    pictureBox1.BackgroundImage = Resources.KD;
                    playerHand += 10;
                    break;
                case 51:
                    pictureBox1.BackgroundImage = Resources.KH;
                    playerHand += 10;
                    break;
                case 52:
                    pictureBox1.BackgroundImage = Resources.KS;
                    playerHand += 10;
                    break;
                default:
                    break;


            }
            playerTotaLabel.Text = playerHand.ToString();    
        }

        void dealDealerCards()
        {
            int randomCard2 = rand.Next(1, 53);

            // Switch statement for randomCard2
            switch (randomCard2)
            {
                case 1:
                    pictureBox2.BackgroundImage = Resources.AC;
                    dealerHand += 11;
                    break;
                case 2:
                    pictureBox2.BackgroundImage = Resources.AD;
                    dealerHand += 11;
                    break;
                case 3:
                    pictureBox2.BackgroundImage = Resources.AH;
                    dealerHand += 11;
                    break;
                case 4:
                    pictureBox2.BackgroundImage = Resources.AS;
                    dealerHand += 11;
                    break;
                case 5:
                    pictureBox2.BackgroundImage = Resources._2C;
                    dealerHand += 2;
                    break;
                case 6:
                    pictureBox2.BackgroundImage = Resources._2D;
                    dealerHand += 2;
                    break;
                case 7:
                    pictureBox2.BackgroundImage = Resources._2H;
                    dealerHand += 2;
                    break;
                case 8:
                    pictureBox2.BackgroundImage = Resources._2S;
                    dealerHand += 2;
                    break;
                case 9:
                    pictureBox2.BackgroundImage = Resources._3C;
                    dealerHand += 3;
                    break;
                case 10:
                    pictureBox2.BackgroundImage = Resources._3D;
                    dealerHand += 3;
                    break;
                case 11:
                    pictureBox2.BackgroundImage = Resources._3H;
                    dealerHand += 3;
                    break;
                case 12:
                    pictureBox2.BackgroundImage = Resources._3S;
                    dealerHand += 3;
                    break;
                case 13:
                    pictureBox2.BackgroundImage = Resources._4C;
                    dealerHand += 4;
                    break;
                case 14:
                    pictureBox2.BackgroundImage = Resources._4D;
                    dealerHand += 4;
                    break;
                case 15:
                    pictureBox2.BackgroundImage = Resources._4H;
                    dealerHand += 4;
                    break;
                case 16:
                    pictureBox2.BackgroundImage = Resources._4S;
                    dealerHand += 4;
                    break;
                case 17:
                    pictureBox2.BackgroundImage = Resources._5C;
                    dealerHand += 5;
                    break;
                case 18:
                    pictureBox2.BackgroundImage = Resources._5D;
                    dealerHand += 5;
                    break;
                case 19:
                    pictureBox2.BackgroundImage = Resources._5H;
                    dealerHand += 5;
                    break;
                case 20:
                    pictureBox2.BackgroundImage = Resources._5S;
                    dealerHand += 5;
                    break;
                case 21:
                    pictureBox2.BackgroundImage = Resources._6C;
                    dealerHand += 6;
                    break;
                case 22:
                    pictureBox2.BackgroundImage = Resources._6D;
                    dealerHand += 6;
                    break;
                case 23:
                    pictureBox2.BackgroundImage = Resources._6H;
                    dealerHand += 6;
                    break;
                case 24:
                    pictureBox2.BackgroundImage = Resources._6S;
                    dealerHand += 6;
                    break;
                case 25:
                    pictureBox2.BackgroundImage = Resources._7C;
                    dealerHand += 7;
                    break;
                case 26:
                    pictureBox2.BackgroundImage = Resources._7D;
                    dealerHand += 7;
                    break;
                case 27:
                    pictureBox2.BackgroundImage = Resources._7H;
                    dealerHand += 7;
                    break;
                case 28:
                    pictureBox2.BackgroundImage = Resources._7S;
                    dealerHand += 7;
                    break;
                case 29:
                    pictureBox2.BackgroundImage = Resources._8C;
                    dealerHand += 8;
                    break;
                case 30:
                    pictureBox2.BackgroundImage = Resources._8D;
                    dealerHand += 8;
                    break;
                case 31:
                    pictureBox2.BackgroundImage = Resources._8H;
                    dealerHand += 8;
                    break;
                case 32:
                    pictureBox2.BackgroundImage = Resources._8S;
                    dealerHand += 8;
                    break;
                case 33:
                    pictureBox2.BackgroundImage = Resources._9C;
                    dealerHand += 9;
                    break;
                case 34:
                    pictureBox2.BackgroundImage = Resources._9D;
                    dealerHand += 9;
                    break;
                case 35:
                    pictureBox2.BackgroundImage = Resources._9H;
                    dealerHand += 9;
                    break;
                case 36:
                    pictureBox2.BackgroundImage = Resources._9S;
                    dealerHand += 9;
                    break;
                case 37:
                    pictureBox2.BackgroundImage = Resources._10C;
                    dealerHand += 10;
                    break;
                case 38:
                    pictureBox2.BackgroundImage = Resources._10D;
                    dealerHand += 10;
                    break;
                case 39:
                    pictureBox2.BackgroundImage = Resources._10H;
                    dealerHand += 10;
                    break;
                case 40:
                    pictureBox2.BackgroundImage = Resources._10S;
                    dealerHand += 10;
                    break;
                case 41:
                    pictureBox2.BackgroundImage = Resources.JC;
                    dealerHand += 10;
                    break;
                case 42:
                    pictureBox2.BackgroundImage = Resources.JD;
                    dealerHand += 10;
                    break;
                case 43:
                    pictureBox2.BackgroundImage = Resources.JH;
                    dealerHand += 10;
                    break;
                case 44:
                    pictureBox2.BackgroundImage = Resources.JS;
                    dealerHand += 10;
                    break;
                case 45:
                    pictureBox2.BackgroundImage = Resources.QC;
                    dealerHand += 10;
                    break;
                case 46:
                    pictureBox2.BackgroundImage = Resources.QD;
                    dealerHand += 10;
                    break;
                case 47:
                    pictureBox2.BackgroundImage = Resources.QH;
                    dealerHand += 10;
                    break;
                case 48:
                    pictureBox2.BackgroundImage = Resources.QS;
                    dealerHand += 10;
                    break;
                case 49:
                    pictureBox2.BackgroundImage = Resources.KC;
                    dealerHand += 10;
                    break;
                case 50:
                    pictureBox2.BackgroundImage = Resources.KD;
                    dealerHand += 10;
                    break;
                case 51:
                    pictureBox2.BackgroundImage = Resources.KH;
                    dealerHand += 10;
                    break;
                case 52:
                    pictureBox2.BackgroundImage = Resources.KS;
                    dealerHand += 10;
                    break;
                default:
                    break;
            }
            dealerTotalLabel.Text = dealerHand.ToString();
        }

        void randomPlayerStartingCards()
        {
            int randomCard1 = rand.Next(1, 53);
            int randomCard2 = rand.Next(1, 53);

            // Switch statement for randomCard1
            switch (randomCard1)
            {
                case 1:
                    randomStartingCard1.BackgroundImage = Resources.AC;
                    playerHand += 11;
                    break;
                case 2:
                    randomStartingCard1.BackgroundImage = Resources.AD;
                    playerHand += 11;
                    break;
                case 3:
                    randomStartingCard1.BackgroundImage = Resources.AH;
                    playerHand += 11;
                    break;
                case 4:
                    randomStartingCard1.BackgroundImage = Resources.AS;
                    playerHand += 11;
                    break;
                case 5:
                    randomStartingCard1.BackgroundImage = Resources._2C;
                    playerHand += 2;
                    break;
                case 6:
                    randomStartingCard1.BackgroundImage = Resources._2D;
                    playerHand += 2;
                    break;
                case 7:
                    randomStartingCard1.BackgroundImage = Resources._2H;
                    playerHand += 2;
                    break;
                case 8:
                    randomStartingCard1.BackgroundImage = Resources._2S;
                    playerHand += 2;
                    break;
                case 9:
                    randomStartingCard1.BackgroundImage = Resources._3C;
                    playerHand += 3;
                    break;
                case 10:
                    randomStartingCard1.BackgroundImage = Resources._3D;
                    playerHand += 3;
                    break;
                case 11:
                    randomStartingCard1.BackgroundImage = Resources._3H;
                    playerHand += 3;
                    break;
                case 12:
                    randomStartingCard1.BackgroundImage = Resources._3S;
                    playerHand += 3;
                    break;
                case 13:
                    randomStartingCard1.BackgroundImage = Resources._4C;
                    playerHand += 4;
                    break;
                case 14:
                    randomStartingCard1.BackgroundImage = Resources._4D;
                    playerHand += 4;
                    break;
                case 15:
                    randomStartingCard1.BackgroundImage = Resources._4H;
                    playerHand += 4;
                    break;
                case 16:
                    randomStartingCard1.BackgroundImage = Resources._4S;
                    playerHand += 4;
                    break;
                case 17:
                    randomStartingCard1.BackgroundImage = Resources._5C;
                    playerHand += 5;
                    break;
                case 18:
                    randomStartingCard1.BackgroundImage = Resources._5D;
                    playerHand += 5;
                    break;
                case 19:
                    randomStartingCard1.BackgroundImage = Resources._5H;
                    playerHand += 5;
                    break;
                case 20:
                    randomStartingCard1.BackgroundImage = Resources._5S;
                    playerHand += 5;
                    break;
                case 21:
                    randomStartingCard1.BackgroundImage = Resources._6C;
                    playerHand += 6;
                    break;
                case 22:
                    randomStartingCard1.BackgroundImage = Resources._6D;
                    playerHand += 6;
                    break;
                case 23:
                    randomStartingCard1.BackgroundImage = Resources._6H;
                    playerHand += 6;
                    break;
                case 24:
                    randomStartingCard1.BackgroundImage = Resources._6S;
                    playerHand += 6;
                    break;
                case 25:
                    randomStartingCard1.BackgroundImage = Resources._7C;
                    playerHand += 7;
                    break;
                case 26:
                    randomStartingCard1.BackgroundImage = Resources._7D;
                    playerHand += 7;
                    break;
                case 27:
                    randomStartingCard1.BackgroundImage = Resources._7H;
                    playerHand += 7;
                    break;
                case 28:
                    randomStartingCard1.BackgroundImage = Resources._7S;
                    playerHand += 7;
                    break;
                case 29:
                    randomStartingCard1.BackgroundImage = Resources._8C;
                    playerHand += 8;
                    break;
                case 30:
                    randomStartingCard1.BackgroundImage = Resources._8D;
                    playerHand += 8;
                    break;
                case 31:
                    randomStartingCard1.BackgroundImage = Resources._8H;
                    playerHand += 8;
                    break;
                case 32:
                    randomStartingCard1.BackgroundImage = Resources._8S;
                    playerHand += 8;
                    break;
                case 33:
                    randomStartingCard1.BackgroundImage = Resources._9C;
                    playerHand += 9;
                    break;
                case 34:
                    randomStartingCard1.BackgroundImage = Resources._9D;
                    playerHand += 9;
                    break;
                case 35:
                    randomStartingCard1.BackgroundImage = Resources._9H;
                    playerHand += 9;
                    break;
                case 36:
                    randomStartingCard1.BackgroundImage = Resources._9S;
                    playerHand += 9;
                    break;
                case 37:
                    randomStartingCard1.BackgroundImage = Resources._10C;
                    playerHand += 10;
                    break;
                case 38:
                    randomStartingCard1.BackgroundImage = Resources._10D;
                    playerHand += 10;
                    break;
                case 39:
                    randomStartingCard1.BackgroundImage = Resources._10H;
                    playerHand += 10;
                    break;
                case 40:
                    randomStartingCard1.BackgroundImage = Resources._10S;
                    playerHand += 10;
                    break;
                case 41:
                    randomStartingCard1.BackgroundImage = Resources.JC;
                    playerHand += 10;
                    break;
                case 42:
                    randomStartingCard1.BackgroundImage = Resources.JD;
                    playerHand += 10;
                    break;
                case 43:
                    randomStartingCard1.BackgroundImage = Resources.JH;
                    playerHand += 10;
                    break;
                case 44:
                    randomStartingCard1.BackgroundImage = Resources.JS;
                    playerHand += 10;
                    break;
                case 45:
                    randomStartingCard1.BackgroundImage = Resources.QC;
                    playerHand += 10;
                    break;
                case 46:
                    randomStartingCard1.BackgroundImage = Resources.QD;
                    playerHand += 10;
                    break;
                case 47:
                    randomStartingCard1.BackgroundImage = Resources.QH;
                    playerHand += 10;
                    break;
                case 48:
                    randomStartingCard1.BackgroundImage = Resources.QS;
                    playerHand += 10;
                    break;
                case 49:
                    randomStartingCard1.BackgroundImage = Resources.KC;
                    playerHand += 10;
                    break;
                case 50:
                    randomStartingCard1.BackgroundImage = Resources.KD;
                    playerHand += 10;
                    break;
                case 51:
                    randomStartingCard1.BackgroundImage = Resources.KH;
                    playerHand += 10;
                    break;
                case 52:
                    randomStartingCard1.BackgroundImage = Resources.KS;
                    playerHand += 10;
                    break;
                default:    
                    break;
            }

            // Switch statement for randomCard2
            switch (randomCard2)
            {
                case 1:
                    randomStartingCard2.BackgroundImage = Resources.AC;
                    playerHand += 11;
                    break;
                case 2:
                    randomStartingCard2.BackgroundImage = Resources.AD;
                    playerHand += 11;
                    break;
                case 3:
                    randomStartingCard2.BackgroundImage = Resources.AH;
                    playerHand += 11;
                    break;
                case 4:
                    randomStartingCard2.BackgroundImage = Resources.AS;
                    playerHand += 11;
                    break;
                case 5:
                    randomStartingCard2.BackgroundImage = Resources._2C;
                    playerHand += 2;
                    break;
                case 6:
                    randomStartingCard2.BackgroundImage = Resources._2D;
                    playerHand += 2;
                    break;
                case 7:
                    randomStartingCard2.BackgroundImage = Resources._2H;
                    playerHand += 2;
                    break;
                case 8:
                    randomStartingCard2.BackgroundImage = Resources._2S;
                    playerHand += 2;
                    break;
                case 9:
                    randomStartingCard2.BackgroundImage = Resources._3C;
                    playerHand += 3;
                    break;
                case 10:
                    randomStartingCard2.BackgroundImage = Resources._3D;
                    playerHand += 3;
                    break;
                case 11:
                    randomStartingCard2.BackgroundImage = Resources._3H;
                    playerHand += 3;
                    break;
                case 12:
                    randomStartingCard2.BackgroundImage = Resources._3S;
                    playerHand += 3;
                    break;
                case 13:
                    randomStartingCard2.BackgroundImage = Resources._4C;
                    playerHand += 4;
                    break;
                case 14:
                    randomStartingCard2.BackgroundImage = Resources._4D;
                    playerHand += 4;
                    break;
                case 15:
                    randomStartingCard2.BackgroundImage = Resources._4H;
                    playerHand += 4;
                    break;
                case 16:
                    randomStartingCard2.BackgroundImage = Resources._4S;
                    playerHand += 4;
                    break;
                case 17:
                    randomStartingCard2.BackgroundImage = Resources._5C;
                    playerHand += 5;
                    break;
                case 18:
                    randomStartingCard2.BackgroundImage = Resources._5D;
                    playerHand += 5;
                    break;
                case 19:
                    randomStartingCard2.BackgroundImage = Resources._5H;
                    playerHand += 5;
                    break;
                case 20:
                    randomStartingCard2.BackgroundImage = Resources._5S;
                    playerHand += 5;
                    break;
                case 21:
                    randomStartingCard2.BackgroundImage = Resources._6C;
                    playerHand += 6;
                    break;
                case 22:
                    randomStartingCard2.BackgroundImage = Resources._6D;
                    playerHand += 6;
                    break;
                case 23:
                    randomStartingCard2.BackgroundImage = Resources._6H;
                    playerHand += 6;
                    break;
                case 24:
                    randomStartingCard2.BackgroundImage = Resources._6S;
                    playerHand += 6;
                    break;
                case 25:
                    randomStartingCard2.BackgroundImage = Resources._7C;
                    playerHand += 7;
                    break;
                case 26:
                    randomStartingCard2.BackgroundImage = Resources._7D;
                    playerHand += 7;
                    break;
                case 27:
                    randomStartingCard2.BackgroundImage = Resources._7H;
                    playerHand += 7;
                    break;
                case 28:
                    randomStartingCard2.BackgroundImage = Resources._7S;
                    playerHand += 7;
                    break;
                case 29:
                    randomStartingCard2.BackgroundImage = Resources._8C;
                    playerHand += 8;
                    break;
                case 30:
                    randomStartingCard2.BackgroundImage = Resources._8D;
                    playerHand += 8;
                    break;
                case 31:
                    randomStartingCard2.BackgroundImage = Resources._8H;
                    playerHand += 8;
                    break;
                case 32:
                    randomStartingCard2.BackgroundImage = Resources._8S;
                    playerHand += 8;
                    break;
                case 33:
                    randomStartingCard2.BackgroundImage = Resources._9C;
                    playerHand += 9;
                    break;
                case 34:
                    randomStartingCard2.BackgroundImage = Resources._9D;
                    playerHand += 9;
                    break;
                case 35:
                    randomStartingCard2.BackgroundImage = Resources._9H;
                    playerHand += 9;
                    break;
                case 36:
                    randomStartingCard2.BackgroundImage = Resources._9S;
                    playerHand += 9;
                    break;
                case 37:
                    randomStartingCard2.BackgroundImage = Resources._10C;
                    playerHand += 10;
                    break;
                case 38:
                    randomStartingCard2.BackgroundImage = Resources._10D;
                    playerHand += 10;
                    break;
                case 39:
                    randomStartingCard2.BackgroundImage = Resources._10H;
                    playerHand += 10;
                    break;
                case 40:
                    randomStartingCard2.BackgroundImage = Resources._10S;
                    playerHand += 10;
                    break;
                case 41:
                    randomStartingCard2.BackgroundImage = Resources.JC;
                    playerHand += 10;
                    break;
                case 42:
                    randomStartingCard2.BackgroundImage = Resources.JD;
                    playerHand += 10;
                    break;
                case 43:
                    randomStartingCard2.BackgroundImage = Resources.JH;
                    playerHand += 10;
                    break;
                case 44:
                    randomStartingCard2.BackgroundImage = Resources.JS;
                    playerHand += 10;
                    break;
                case 45:
                    randomStartingCard2.BackgroundImage = Resources.QC;
                    playerHand += 10;
                    break;
                case 46:
                    randomStartingCard2.BackgroundImage = Resources.QD;
                    playerHand += 10;
                    break;
                case 47:
                    randomStartingCard2.BackgroundImage = Resources.QH;
                    playerHand += 10;
                    break;
                case 48:
                    randomStartingCard2.BackgroundImage = Resources.QS;
                    playerHand += 10;
                    break;
                case 49:
                    randomStartingCard2.BackgroundImage = Resources.KC;
                    playerHand += 10;
                    break;
                case 50:
                    randomStartingCard2.BackgroundImage = Resources.KD;
                    playerHand += 10;
                    break;
                case 51:
                    randomStartingCard2.BackgroundImage = Resources.KH;
                    playerHand += 10;
                    break;
                case 52:
                    randomStartingCard2.BackgroundImage = Resources.KS;
                    playerHand += 10;
                    break;
                default:
                    // Handle any unexpected case for randomCard2
                    break;
            }
            playerTotaLabel.Text = playerHand.ToString();
        }

        void randomDealerStartingCard()
        {
            int randomDealerCard1 = rand.Next(1, 53);

            // Switch statement for randomDealerCard1
            switch (randomDealerCard1)
            {
                case 1:
                    randomDealerCard.BackgroundImage = Resources.AC;
                    dealerHand += 11;
                    break;
                case 2:
                    randomDealerCard.BackgroundImage = Resources.AD;
                    dealerHand += 11;
                    break;
                case 3:
                    randomDealerCard.BackgroundImage = Resources.AH;
                    dealerHand += 11;
                    break;
                case 4:
                    randomDealerCard.BackgroundImage = Resources.AS;
                    dealerHand += 11;
                    break;
                case 5:
                    randomDealerCard.BackgroundImage = Resources._2C;
                    dealerHand += 2;
                    break;
                case 6:
                    randomDealerCard.BackgroundImage = Resources._2D;
                    dealerHand += 2;
                    break;
                case 7:
                    randomDealerCard.BackgroundImage = Resources._2H;
                    dealerHand += 2;
                    break;
                case 8:
                    randomDealerCard.BackgroundImage = Resources._2S;
                    dealerHand += 2;
                    break;
                case 9:
                    randomDealerCard.BackgroundImage = Resources._3C;
                    dealerHand += 3;
                    break;
                case 10:
                    randomDealerCard.BackgroundImage = Resources._3D;
                    dealerHand += 3;
                    break;
                case 11:
                    randomDealerCard.BackgroundImage = Resources._3H;
                    dealerHand += 3;
                    break;
                case 12:
                    randomDealerCard.BackgroundImage = Resources._3S;
                    dealerHand += 3;
                    break;
                case 13:
                    randomDealerCard.BackgroundImage = Resources._4C;
                    dealerHand += 4;
                    break;
                case 14:
                    randomDealerCard.BackgroundImage = Resources._4D;
                    dealerHand += 4;
                    break;
                case 15:
                    randomDealerCard.BackgroundImage = Resources._4H;
                    dealerHand += 4;
                    break;
                case 16:
                    randomDealerCard.BackgroundImage = Resources._4S;
                    dealerHand += 4;
                    break;
                case 17:
                    randomDealerCard.BackgroundImage = Resources._5C;
                    dealerHand += 5;
                    break;
                case 18:
                    randomDealerCard.BackgroundImage = Resources._5D;
                    dealerHand += 5;
                    break;
                case 19:
                    randomDealerCard.BackgroundImage = Resources._5H;
                    dealerHand += 5;
                    break;
                case 20:
                    randomDealerCard.BackgroundImage = Resources._5S;
                    dealerHand += 5;
                    break;
                case 21:
                    randomDealerCard.BackgroundImage = Resources._6C;
                    dealerHand += 6;
                    break;
                case 22:
                    randomDealerCard.BackgroundImage = Resources._6D;
                    dealerHand += 6;
                    break;
                case 23:
                    randomDealerCard.BackgroundImage = Resources._6H;
                    dealerHand += 6;
                    break;
                case 24:
                    randomDealerCard.BackgroundImage = Resources._6S;
                    dealerHand += 6;
                    break;
                case 25:
                    randomDealerCard.BackgroundImage = Resources._7C;
                    dealerHand += 7;
                    break;
                case 26:
                    randomDealerCard.BackgroundImage = Resources._7D;
                    dealerHand += 7;
                    break;
                case 27:
                    randomDealerCard.BackgroundImage = Resources._7H;
                    dealerHand += 7;
                    break;
                case 28:
                    randomDealerCard.BackgroundImage = Resources._7S;
                    dealerHand += 7;
                    break;
                case 29:
                    randomDealerCard.BackgroundImage = Resources._8C;
                    dealerHand += 8;
                    break;
                case 30:
                    randomDealerCard.BackgroundImage = Resources._8D;
                    dealerHand += 8;
                    break;
                case 31:
                    randomDealerCard.BackgroundImage = Resources._8H;
                    dealerHand += 8;
                    break;
                case 32:
                    randomDealerCard.BackgroundImage = Resources._8S;
                    dealerHand += 8;
                    break;
                case 33:
                    randomDealerCard.BackgroundImage = Resources._9C;
                    dealerHand += 9;
                    break;
                case 34:
                    randomDealerCard.BackgroundImage = Resources._9D;
                    dealerHand += 9;
                    break;
                case 35:
                    randomDealerCard.BackgroundImage = Resources._9H;
                    dealerHand += 9;
                    break;
                case 36:
                    randomDealerCard.BackgroundImage = Resources._9S;
                    dealerHand += 9;
                    break;
                case 37:
                    randomDealerCard.BackgroundImage = Resources._10C;
                    dealerHand += 10;
                    break;
                case 38:
                    randomDealerCard.BackgroundImage = Resources._10D;
                    dealerHand += 10;
                    break;
                case 39:
                    randomDealerCard.BackgroundImage = Resources._10H;
                    dealerHand += 10;
                    break;
                case 40:
                    randomDealerCard.BackgroundImage = Resources._10S;
                    dealerHand += 10;
                    break;
                case 41:
                    randomDealerCard.BackgroundImage = Resources.JC;
                    dealerHand += 10;
                    break;
                case 42:
                    randomDealerCard.BackgroundImage = Resources.JD;
                    dealerHand += 10;
                    break;
                case 43:
                    randomDealerCard.BackgroundImage = Resources.JH;
                    dealerHand += 10;
                    break;
                case 44:
                    randomDealerCard.BackgroundImage = Resources.JS;
                    dealerHand += 10;
                    break;
                case 45:
                    randomDealerCard.BackgroundImage = Resources.QC;
                    dealerHand += 10;
                    break;
                case 46:
                    randomDealerCard.BackgroundImage = Resources.QD;
                    dealerHand += 10;
                    break;
                case 47:
                    randomDealerCard.BackgroundImage = Resources.QH;
                    dealerHand += 10;
                    break;
                case 48:
                    randomDealerCard.BackgroundImage = Resources.QS;
                    dealerHand += 10;
                    break;
                case 49:
                    randomDealerCard.BackgroundImage = Resources.KC;
                    dealerHand += 10;
                    break;
                case 50:
                    randomDealerCard.BackgroundImage = Resources.KD;
                    dealerHand += 10;
                    break;
                case 51:
                    randomDealerCard.BackgroundImage = Resources.KH;
                    dealerHand += 10;
                    break;
                case 52:
                    randomDealerCard.BackgroundImage = Resources.KS;
                    dealerHand += 10;
                    break;
                default:
                    break;
            }
            dealerTotalLabel.Text = dealerHand.ToString();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            randomPlayerStartingCards();
            randomDealerStartingCard();
        }

        private void twistButton_Click(object sender, EventArgs e)
        {
            dealCards();
            checkWin();
        }

        private void stickButton_Click(object sender, EventArgs e)
        {

            while (dealerHand < 17)
            {
                dealDealerCards();
                checkWin();
            }
            if (dealerHand <= 21)
            {
                if (playerHand > dealerHand)
                {
                    MessageBox.Show("Your hand is bigger than the dealer. You win the game!", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Windows.Forms.Application.Exit();
                }
                else if (playerHand < dealerHand)
                {
                    MessageBox.Show("Your hand is smaller than the dealer. You lose the game.", "You lose", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Windows.Forms.Application.Exit();
                }
                else if (playerHand == dealerHand)
                {
                    MessageBox.Show("It's a draw.", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Windows.Forms.Application.Exit();
                }
            } 
        }
    }
}
