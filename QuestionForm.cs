using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathquiz
{
    public partial class QuestionForm : Form
    {
        public Question question;

        ErrorProvider errorProvider = new ErrorProvider();
        public QuestionForm()
        {
            InitializeComponent();
            GenerateQuestion();

        }
        private void GenerateQuestion()
        {
            Random random = new Random();
            question = new Question(random.Next(100), random.Next(100), randomSign());
            questionlabel.Text = question.ToString() + "?";

        }

        private char randomSign() {
            Random random = new Random();
            switch (random.Next(1, 4)) {
                case 1:
                    return '+';
              
                case 2:
                    return '-';
             
                case 3:
                    return '*';
                default:
                    return ' ';
            }
        }

        private void AnswerTb_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(AnswerTb.Text, out int a))
            {
                errorProvider.SetError(AnswerTb, "not a number");
            }
            else errorProvider.SetError(AnswerTb, "");
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            if (AnswerTb.Text.Length > 0 && errorProvider.GetError(AnswerTb) == "")
            {
                this.DialogResult = DialogResult.OK;
                if (question.result == int.Parse(AnswerTb.Text))
                {
                    question.isCorrect = true;
                }
                else question.points = -2;
                return;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            return;
        }
    }
}
