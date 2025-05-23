using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Build_for_phase_2
{
    public partial class Form3 : Form
    {
        // quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;




        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {

            switch (questionNumber)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.download;
                    lblQuestion.Text = "How do you make a sprite move in scratch?";
                    button1.Text = "By using the pen clock";
                    button2.Text = "By using the motion block";
                    button3.Text = "By using the looks block";
                    button4.Text = "By using the sound block";
                    correctAnswer = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.what_is_block_coding;
                    lblQuestion.Text = "In Scratch, what is a 'forever' block used for";
                    button1.Text = "To make a sprite disappear";
                    button2.Text = "To loop an action continuously";
                    button3.Text = "To change te background";
                    button4.Text = "To mae a sound lay forever";
                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.download;
                    lblQuestion.Text = "What block would you use to move a character forward in block coding?";
                    button1.Text = "Turn Block";
                    button2.Text = "Move Block";
                    button3.Text = "Jump block";
                    button4.Text = "Print Block";
                    correctAnswer = 2;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.what_is_block_coding;
                    lblQuestion.Text = "In Block Coding, what is the purpose of a 'wait' block?";
                    button1.Text = "It stops the program from running";
                    button2.Text = "It makes the program run faster";
                    button3.Text = "It repeats the last action";
                    button4.Text = "It pauses the program for a set of amount";
                    correctAnswer = 4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.download;
                    lblQuestion.Text = "Which of these blocks would you use to make a sprite turn?";
                    button1.Text = "Move block";
                    button2.Text = "If block";
                    button3.Text = "Turn block";
                    button4.Text = "Jump block";
                    correctAnswer = 3;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.what_is_block_coding ;
                    lblQuestion.Text = "What happens when you connect blocks in block coding?";
                    button1.Text = "It creates a program that tells the computer what to do";
                    button2.Text = "It makes the computer freaze";
                    button3.Text = "It prints a document";
                    button4.Text = "It deletes all the files";
                    correctAnswer = 1;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.download;
                    lblQuestion.Text = "What platform is commonly used to teach block coding beginners?";
                    button1.Text = "tinkercad";
                    button2.Text = "Visual studio";
                    button3.Text = "Microsoft word";
                    button4.Text = "Scratch";
                    correctAnswer = 4;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.what_is_block_coding;
                    lblQuestion.Text = "What is the green flag block?";
                    button1.Text = "It stops the game";
                    button2.Text = "It starts the game";
                    button3.Text = "It opens the code";
                    button4.Text = "It coverts block coding to python";
                    correctAnswer = 2;
                    break;
            }
        }
    }
}