using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Quest
{
    public partial class Form2 : Form
    {
        //State Global Variables' and their value
        string name;
        int question;
        Random rnd = new Random();
        string[] maths = { "Add", "Subtract", "Multiply" };
        int questionCount = -1;
        int total;
        int score;
        string resultsMsg = "";


        public Form2(string name, int question)
        {
            this.name = name;
            this.question = question;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //Welcome user
            lblWelcomeUser.Text = $"Welcome {name}";
            //Hide the results box until the end when they are needed
            lblThankUser.Hide();
            lblResultTitle.Hide();
            rtbResults.Hide();
            btnReturn.Hide();
            //Run Quiz
            SetupQuiz();
        }


        private void CheckButtonClick(object sender, EventArgs e)
        {
            //Assign 'userEntered' variable a value
            int userEntered = (int)numUserAns.Value;
            //Check answer enter is valid
            if (IsAnswerValid(userEntered))
            {
               
            }
            else
            {
                //Ask user to enter an integer between 1 and 200
                MessageBox.Show("Please Enter An Integer Between 1 and 200");
                return;
            }
                //Have different outcomes depending on whether the users input was correct or not 
                if (userEntered == total)
                {
                    //If user was correct show label stating that they were correct
                    lblResult.Text = "Correct";
                    lblResult.ForeColor = Color.Green;
                    //Increase score by 1
                    score += 1;
                    //Assign what the results message would be for this question
                    resultsMsg = $"{resultsMsg}" + $"Question: {questionCount +1 }\nCorrect\n";
                    //Run next question
                    SetupQuiz();

                }
                else
                {
                    //If user was correct show label stating that they were correct
                    lblResult.Text = "Incorrect";
                    lblResult.ForeColor = Color.Red;
                    //Assign what the results message would be for this question
                    resultsMsg = $"{resultsMsg}" + $"Question: {questionCount +1}\nIncorrect - You entered {userEntered} The correct answer was {total}\n";
                    //Run the next question
                    SetupQuiz();
                }

            if (questionCount == question )
            {
                //Hide The Question, Answer input and Button
                lblNumA.Hide();
                lblNumB.Hide();
                lblOperation.Hide();
                lblEqualSymbol.Hide();
                lblResult.Hide();
                lblQuestionNumber.Hide();
                numUserAns.Hide();
                btnCheck.Hide();
                lblWelcomeUser.Hide();

                //Show the label that thanks user for using Quiz Quest
                lblThankUser.Show();

                //Show Results Textbox and Label
                lblResultTitle.Show();
                rtbResults.Show();
                btnReturn.Show();
                rtbResults.Text = $"{name}'s Results:\n{resultsMsg}" + $"\nScore: {score}\nPercentage: {(score * 100) / question}%";
            }

        }

        private void SetupQuiz()
        {

            //Random Integers And Operation Chosen For Equation
            int numA = rnd.Next(10, 20);
            int numB = rnd.Next(1, 9);

            //Tell user what question they are up to
            lblQuestionNumber.Text = $"Question {questionCount + 2 }:";

            switch (maths[rnd.Next(0, maths.Length)])
            {
                //Different Symbol Put In The Operation Label Depending On The Operation
                //Total Answer Calculated Using Correct Operation
                case "Add":
                    total = numA + numB;
                    lblOperation.Text = "+";
                    break;

                case "Subtract":
                    total = numA - numB;
                    lblOperation.Text = "-";
                    break;

                case "Multiply":
                    total = numA * numB;
                    lblOperation.Text = "x";
                    break;
            }
            //Integers for the question displayed in their various labels
            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();

            //Invrease the question count by 1
            questionCount = questionCount + 1;
            //Clear the NumericUpDowm where user inputs answer
            numUserAns.Value = 0;
            numUserAns.Text = "";

        }
        private bool IsAnswerValid(int userEntered)
        {

            //Check Number Is Between 1 and 20
            if (userEntered >= 1 && userEntered <= 200)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Return to start if button clicked 
            Form1 form1 = new Form1();
            Visible = false;
            form1.ShowDialog();
        }

        private void lblResultTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
