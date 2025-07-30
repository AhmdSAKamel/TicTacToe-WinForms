namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblPlayer = new Label();
            label2 = new Label();
            lblWinner = new Label();
            btnRestart = new Button();
            label3 = new Label();
            button9 = new Button();
            button4 = new Button();
            button7 = new Button();
            button2 = new Button();
            button5 = new Button();
            button8 = new Button();
            button3 = new Button();
            button6 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT Condensed", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(47, 78);
            label1.Name = "label1";
            label1.Size = new Size(74, 41);
            label1.TabIndex = 0;
            label1.Text = "Turn";
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(47, 119);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(110, 40);
            lblPlayer.TabIndex = 1;
            lblPlayer.Text = "Player1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT Condensed", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(47, 179);
            label2.Name = "label2";
            label2.Size = new Size(106, 41);
            label2.TabIndex = 2;
            label2.Text = "Winner";
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWinner.ForeColor = Color.FromArgb(0, 192, 0);
            lblWinner.Location = new Point(47, 231);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(158, 40);
            lblWinner.TabIndex = 3;
            lblWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Black;
            btnRestart.Cursor = Cursors.Hand;
            btnRestart.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = SystemColors.ButtonHighlight;
            btnRestart.Location = new Point(29, 353);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(203, 48);
            btnRestart.TabIndex = 4;
            btnRestart.Text = "Restart Game";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(350, 9);
            label3.Name = "label3";
            label3.Size = new Size(354, 46);
            label3.TabIndex = 5;
            label3.Text = "Tic-Tac-Toe Game";
            // 
            // button9
            // 
            button9.BackColor = Color.Black;
            button9.BackgroundImageLayout = ImageLayout.Center;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatAppearance.MouseDownBackColor = Color.Black;
            button9.FlatAppearance.MouseOverBackColor = Color.Black;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = Properties.Resources.question_mark_96;
            button9.Location = new Point(664, 384);
            button9.Name = "button9";
            button9.Size = new Size(111, 96);
            button9.TabIndex = 23;
            button9.Tag = "?";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.MouseDownBackColor = Color.Black;
            button4.FlatAppearance.MouseOverBackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.question_mark_96;
            button4.Location = new Point(316, 231);
            button4.Name = "button4";
            button4.Size = new Size(111, 96);
            button4.TabIndex = 16;
            button4.Tag = "?";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.MouseDownBackColor = Color.Black;
            button7.FlatAppearance.MouseOverBackColor = Color.Black;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.question_mark_96;
            button7.Location = new Point(316, 384);
            button7.Name = "button7";
            button7.Size = new Size(111, 96);
            button7.TabIndex = 17;
            button7.Tag = "?";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = Color.Black;
            button2.FlatAppearance.MouseOverBackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.question_mark_96;
            button2.Location = new Point(485, 78);
            button2.Name = "button2";
            button2.Size = new Size(111, 96);
            button2.TabIndex = 18;
            button2.Tag = "?";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.MouseDownBackColor = Color.Black;
            button5.FlatAppearance.MouseOverBackColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.question_mark_96;
            button5.Location = new Point(485, 231);
            button5.Name = "button5";
            button5.Size = new Size(111, 96);
            button5.TabIndex = 19;
            button5.Tag = "?";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.BackgroundImageLayout = ImageLayout.Center;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatAppearance.MouseDownBackColor = Color.Black;
            button8.FlatAppearance.MouseOverBackColor = Color.Black;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.question_mark_96;
            button8.Location = new Point(485, 384);
            button8.Name = "button8";
            button8.Size = new Size(111, 96);
            button8.TabIndex = 20;
            button8.Tag = "?";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.MouseDownBackColor = Color.Black;
            button3.FlatAppearance.MouseOverBackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.question_mark_96;
            button3.Location = new Point(664, 89);
            button3.Name = "button3";
            button3.Size = new Size(111, 96);
            button3.TabIndex = 21;
            button3.Tag = "?";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.MouseDownBackColor = Color.Black;
            button6.FlatAppearance.MouseOverBackColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.question_mark_96;
            button6.Location = new Point(664, 240);
            button6.Name = "button6";
            button6.Size = new Size(111, 96);
            button6.TabIndex = 22;
            button6.Tag = "?";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.question_mark_96;
            button1.Location = new Point(316, 78);
            button1.Name = "button1";
            button1.Size = new Size(111, 96);
            button1.TabIndex = 15;
            button1.Tag = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(897, 531);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(btnRestart);
            Controls.Add(lblWinner);
            Controls.Add(label2);
            Controls.Add(lblPlayer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblPlayer;
        private Label label2;
        private Label lblWinner;
        private Button btnRestart;
        private Label label3;
        private Button button9;
        private Button button4;
        private Button button7;
        private Button button2;
        private Button button5;
        private Button button8;
        private Button button3;
        private Button button6;
        private Button button1;
    }
}
