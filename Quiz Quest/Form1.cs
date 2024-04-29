using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Quest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void txbxName_TextChanged(object sender, EventArgs e)
        {


        }


        private void btnQz_Click(object sender, EventArgs e)
        {
            //Assign Name
            string name = txbxName.Text;
            if (IsNameValid(name))
            {
                //Make all letters in name lower case
                name = name.ToLower();
                //Make the first letter upper case 
                name = char.ToUpper(name[0]) + name.Substring(1);
            }
            else
            {
                //Ask User To Enter New Name If theres was invalid
                MessageBox.Show("Name Is Invalid\nEnter a New Name");
                return;
            }

            // Check Question Number Input is Valid
            int question = (int)numQuestion.Value;
            if (IsQuestionValid(question))
            {
                
            }
            else
            {
                //Ask User To Enter New Number
                MessageBox.Show("Number Is Invalid\nEnter an Integer between 1 and 20");
                //Clear NumericUpDown 
                numQuestion.Text = "";
                return;
            }


            // Open Form When Button Clicked  
            Form2 form2 = new Form2(name, question);
            Visible = false;
            form2.ShowDialog();
        }

            
        private bool IsNameValid(string name)
        {       
            //Check Name length is valid
            return name.Length >= 1;
        }

        private bool IsQuestionValid(int question)
        {

            //Check Number Is Between 1 and 20
            if (question >= 1 && question <= 20)
            {
                return true;
            }
            
            else
            {
                return false;
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
