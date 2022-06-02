namespace Tic_Tac_Toe_VB
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        bool turnq = true;// true = X turn; false = Y turn
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turnq)
                b.Text = "X";
            else
                b.Text = "O";

            turnq = !turnq;
            b.Enabled = false;
            
            turn_count++;

            checkForWinner();
        }
        private void checkForWinner()
        {

            bool there_is_a_winner = false;

            //horizontal checks
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((B4.Text == B5.Text) && (B5.Text == B6.Text) && (!B4.Enabled))
                there_is_a_winner = true;
            else if ((B7.Text == B8.Text) && (B8.Text == B9.Text) && (!B7.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disableButtons();

                String winner = "";
                if (turnq)
                    winner = "X";
                else
                    winner = "O";

                MessageBox.Show(winner + " Won!", " Takes Home the Bacon!");
            }//end if

            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw");
            }

        }//end checkForWinner
        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                c.Enabled = false;
            }
        }
    }
}