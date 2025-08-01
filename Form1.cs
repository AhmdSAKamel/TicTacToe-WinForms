using Tic_Tac_Toe.Properties;




namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(White);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            // Draw horizontal lines  
            e.Graphics.DrawLine(pen, 300, 200, 800, 200);
            e.Graphics.DrawLine(pen, 300, 350, 800, 350);

            e.Graphics.DrawLine(pen, 460, 100, 460, 480);
            e.Graphics.DrawLine(pen, 620, 100, 620, 480);

        }

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,

            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public byte PlayCount;

        }

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {


            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {

                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }

            GameStatus.GameOver = false;
            return false;


        }

        void EndGame()
        {

            lblPlayer.Text = "Game Over";

            switch (GameStatus.Winner)
            {

                case enWinner.Player1:

                    lblWinner.Text = "Player1";
                    break;

                case enWinner.Player2:

                    lblWinner.Text = "Player2";
                    break;

                default:

                    lblWinner.Text = "Draw";
                    break;

            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void CheckWinner()
        {


            //checked rows
            //check Row1
            if (CheckValues(button1, button2, button3))
                return;

            //check Row2
            if (CheckValues(button4, button5, button6))
                return;

            //check Row3
            if (CheckValues(button7, button8, button9))
                return;

            //checked cols
            //check col1
            if (CheckValues(button1, button4, button7))
                return;

            //check col2
            if (CheckValues(button2, button5, button8))
                return;

            //check col3
            if (CheckValues(button3, button6, button9))
                return;

            //check Diagonal

            if (CheckValues(button1, button5, button9))
                return;

            //check Diagonal2
            if (CheckValues(button3, button5, button7))
                return;


        }

        public void ChangeImage(Button btn)
        {

            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        {
                            btn.Image = Resources.X;
                            PlayerTurn = enPlayer.Player2;
                            lblPlayer.Text = "Player 2";
                            GameStatus.PlayCount++;
                            btn.Tag = "X";
                            CheckWinner();
                            break;
                        }

                    case enPlayer.Player2:
                        {
                            btn.Image = Resources.O;
                            PlayerTurn = enPlayer.Player1;
                            lblPlayer.Text = "Player 1";
                            GameStatus.PlayCount++;
                            btn.Tag = "O";
                            CheckWinner();
                            break;
                        }
                }
            }

            else

            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }


        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeImage(button1);
        }
      
        private void RestButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;

        }

        private void RestartGame()
        {

            RestButton(button1);
            RestButton(button2);
            RestButton(button3);
            RestButton(button4);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);

            PlayerTurn = enPlayer.Player1;
            lblPlayer.Text = "Player 1";

            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;

            GameStatus.Winner = enWinner.GameInProgress;
            lblWinner.Text = "In Progress";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

    }
}
