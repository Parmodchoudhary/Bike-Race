namespace Bike_Race
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.currentBettor = new System.Windows.Forms.Label();
            this.ridersList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.player3Bet = new System.Windows.Forms.Label();
            this.player2Bet = new System.Windows.Forms.Label();
            this.player1Bet = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.bikeYellow = new System.Windows.Forms.PictureBox();
            this.bikeRed = new System.Windows.Forms.PictureBox();
            this.bikePurple = new System.Windows.Forms.PictureBox();
            this.bikeBlue = new System.Windows.Forms.PictureBox();
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.beginRace = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.currentBettor);
            this.panel1.Controls.Add(this.ridersList);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.player3Bet);
            this.panel1.Controls.Add(this.player2Bet);
            this.panel1.Controls.Add(this.player1Bet);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 518);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Place Bet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "on";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(392, 486);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(122, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // currentBettor
            // 
            this.currentBettor.AutoSize = true;
            this.currentBettor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBettor.Location = new System.Drawing.Point(353, 488);
            this.currentBettor.Name = "currentBettor";
            this.currentBettor.Size = new System.Drawing.Size(33, 18);
            this.currentBettor.TabIndex = 11;
            this.currentBettor.Text = "Joe";
            // 
            // ridersList
            // 
            this.ridersList.FormattingEnabled = true;
            this.ridersList.Location = new System.Drawing.Point(551, 486);
            this.ridersList.Name = "ridersList";
            this.ridersList.Size = new System.Drawing.Size(135, 21);
            this.ridersList.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bets";
            // 
            // player3Bet
            // 
            this.player3Bet.AutoSize = true;
            this.player3Bet.Location = new System.Drawing.Point(183, 489);
            this.player3Bet.Name = "player3Bet";
            this.player3Bet.Size = new System.Drawing.Size(35, 13);
            this.player3Bet.TabIndex = 8;
            this.player3Bet.Text = "label5";
            // 
            // player2Bet
            // 
            this.player2Bet.AutoSize = true;
            this.player2Bet.Location = new System.Drawing.Point(183, 466);
            this.player2Bet.Name = "player2Bet";
            this.player2Bet.Size = new System.Drawing.Size(35, 13);
            this.player2Bet.TabIndex = 7;
            this.player2Bet.Text = "label4";
            // 
            // player1Bet
            // 
            this.player1Bet.AutoSize = true;
            this.player1Bet.Location = new System.Drawing.Point(183, 443);
            this.player1Bet.Name = "player1Bet";
            this.player1Bet.Size = new System.Drawing.Size(35, 13);
            this.player1Bet.TabIndex = 6;
            this.player1Bet.Text = "label3";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 485);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 462);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 439);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minimum Bet: $5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Betting Parlor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.bikeYellow);
            this.panel2.Controls.Add(this.bikeRed);
            this.panel2.Controls.Add(this.bikePurple);
            this.panel2.Controls.Add(this.bikeBlue);
            this.panel2.Controls.Add(this.raceTrack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 393);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(0, 287);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(891, 2);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(0, 192);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(891, 2);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(3, 97);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(891, 2);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // bikeYellow
            // 
            this.bikeYellow.Image = global::Bike_Race.Properties.Resources.BikeYellow;
            this.bikeYellow.Location = new System.Drawing.Point(8, 298);
            this.bikeYellow.Name = "bikeYellow";
            this.bikeYellow.Size = new System.Drawing.Size(75, 75);
            this.bikeYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bikeYellow.TabIndex = 5;
            this.bikeYellow.TabStop = false;
            // 
            // bikeRed
            // 
            this.bikeRed.Image = global::Bike_Race.Properties.Resources.BikeRed;
            this.bikeRed.Location = new System.Drawing.Point(8, 201);
            this.bikeRed.Name = "bikeRed";
            this.bikeRed.Size = new System.Drawing.Size(75, 75);
            this.bikeRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bikeRed.TabIndex = 4;
            this.bikeRed.TabStop = false;
            // 
            // bikePurple
            // 
            this.bikePurple.Image = global::Bike_Race.Properties.Resources.BikePurple;
            this.bikePurple.Location = new System.Drawing.Point(8, 108);
            this.bikePurple.Name = "bikePurple";
            this.bikePurple.Size = new System.Drawing.Size(75, 75);
            this.bikePurple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bikePurple.TabIndex = 3;
            this.bikePurple.TabStop = false;
            // 
            // bikeBlue
            // 
            this.bikeBlue.Image = global::Bike_Race.Properties.Resources.BikeBlue;
            this.bikeBlue.Location = new System.Drawing.Point(8, 13);
            this.bikeBlue.Name = "bikeBlue";
            this.bikeBlue.Size = new System.Drawing.Size(75, 75);
            this.bikeBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bikeBlue.TabIndex = 2;
            this.bikeBlue.TabStop = false;
            // 
            // raceTrack
            // 
            this.raceTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raceTrack.Location = new System.Drawing.Point(0, 0);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(874, 393);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.raceTrack.TabIndex = 1;
            this.raceTrack.TabStop = false;
            // 
            // beginRace
            // 
            this.beginRace.Location = new System.Drawing.Point(892, 472);
            this.beginRace.Name = "beginRace";
            this.beginRace.Size = new System.Drawing.Size(228, 58);
            this.beginRace.TabIndex = 15;
            this.beginRace.Text = "Start Race";
            this.beginRace.UseVisualStyleBackColor = true;
            this.beginRace.Click += new System.EventHandler(this.BeginRace_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "Valentino Rossi     1  : 1",
            "Marc Marque         2  : 1",
            "Casey Stoner         3  : 1",
            "Jorge Lorenzo     10  : 1"});
            this.listBox1.Location = new System.Drawing.Point(892, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 264);
            this.listBox1.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 35;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 542);
            this.Controls.Add(this.beginRace);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.Label player3Bet;
        private System.Windows.Forms.Label player2Bet;
        private System.Windows.Forms.Label player1Bet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label currentBettor;
        private System.Windows.Forms.ComboBox ridersList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button beginRace;
        private System.Windows.Forms.PictureBox bikeBlue;
        private System.Windows.Forms.PictureBox bikeYellow;
        private System.Windows.Forms.PictureBox bikeRed;
        private System.Windows.Forms.PictureBox bikePurple;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer;
    }
}

