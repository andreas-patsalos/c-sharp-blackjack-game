namespace BlackjackGame
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerTotaLabel = new System.Windows.Forms.Label();
            this.dealerTotalLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.twistButton = new System.Windows.Forms.Button();
            this.stickButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.randomStartingCard1 = new System.Windows.Forms.PictureBox();
            this.randomStartingCard2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.randomDealerCard = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomStartingCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomStartingCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomDealerCard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "You";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dealer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1311, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1311, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total:";
            // 
            // playerTotaLabel
            // 
            this.playerTotaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTotaLabel.Location = new System.Drawing.Point(1281, 126);
            this.playerTotaLabel.Name = "playerTotaLabel";
            this.playerTotaLabel.Size = new System.Drawing.Size(100, 66);
            this.playerTotaLabel.TabIndex = 4;
            this.playerTotaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerTotalLabel
            // 
            this.dealerTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerTotalLabel.Location = new System.Drawing.Point(1281, 474);
            this.dealerTotalLabel.Name = "dealerTotalLabel";
            this.dealerTotalLabel.Size = new System.Drawing.Size(100, 66);
            this.dealerTotalLabel.TabIndex = 5;
            this.dealerTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(646, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 149);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // twistButton
            // 
            this.twistButton.Location = new System.Drawing.Point(517, 290);
            this.twistButton.Name = "twistButton";
            this.twistButton.Size = new System.Drawing.Size(75, 36);
            this.twistButton.TabIndex = 7;
            this.twistButton.Text = "Twist";
            this.twistButton.UseVisualStyleBackColor = true;
            this.twistButton.Click += new System.EventHandler(this.twistButton_Click);
            // 
            // stickButton
            // 
            this.stickButton.Location = new System.Drawing.Point(794, 290);
            this.stickButton.Name = "stickButton";
            this.stickButton.Size = new System.Drawing.Size(75, 36);
            this.stickButton.TabIndex = 8;
            this.stickButton.Text = "Stick";
            this.stickButton.UseVisualStyleBackColor = true;
            this.stickButton.Click += new System.EventHandler(this.stickButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(646, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 149);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // randomStartingCard1
            // 
            this.randomStartingCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.randomStartingCard1.Location = new System.Drawing.Point(34, 94);
            this.randomStartingCard1.Name = "randomStartingCard1";
            this.randomStartingCard1.Size = new System.Drawing.Size(100, 149);
            this.randomStartingCard1.TabIndex = 10;
            this.randomStartingCard1.TabStop = false;
            // 
            // randomStartingCard2
            // 
            this.randomStartingCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.randomStartingCard2.Location = new System.Drawing.Point(174, 94);
            this.randomStartingCard2.Name = "randomStartingCard2";
            this.randomStartingCard2.Size = new System.Drawing.Size(100, 149);
            this.randomStartingCard2.TabIndex = 11;
            this.randomStartingCard2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Your Cards";
            // 
            // randomDealerCard
            // 
            this.randomDealerCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.randomDealerCard.Location = new System.Drawing.Point(113, 391);
            this.randomDealerCard.Name = "randomDealerCard";
            this.randomDealerCard.Size = new System.Drawing.Size(100, 149);
            this.randomDealerCard.TabIndex = 13;
            this.randomDealerCard.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dealer\'s Card";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackjackGame.Properties.Resources.App_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1426, 655);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.randomDealerCard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.randomStartingCard2);
            this.Controls.Add(this.randomStartingCard1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.stickButton);
            this.Controls.Add(this.twistButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dealerTotalLabel);
            this.Controls.Add(this.playerTotaLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomStartingCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomStartingCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomDealerCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerTotaLabel;
        private System.Windows.Forms.Label dealerTotalLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button twistButton;
        private System.Windows.Forms.Button stickButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox randomStartingCard1;
        private System.Windows.Forms.PictureBox randomStartingCard2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox randomDealerCard;
        private System.Windows.Forms.Label label6;
    }
}