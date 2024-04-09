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
    public partial class Form1 : Form
    {
        private int numOfAnswered;
        private int minPoints;
        private int maxPoints;
        private int totalPoints;
        private int avgPoints;
        public Form1()
        {
            InitializeComponent();
            numOfAnswered = 0;
            minPoints = 0;
            maxPoints = 0;
            avgPoints = 0;
            totalPoints = 0;
            updateStats();
        }

        private void answerBtn_Click(object sender, EventArgs e)
        {
            QuestionForm form = new QuestionForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK) {
                //populate
                Question question = form.question;
                string str = question.ToString() + " " + question.result;
                if (question.isCorrect)
                {
                    str += " ТОЧНО ";
                }
                else str += " НЕТОЧНО ";
                str += question.points + " поени";
                questionsLb.Items.Add(str);
                calculateStats(question.points);
            }
        }
        private void calculateStats(int points)
        {
            numOfAnswered++;
            if(points < minPoints)
            {
                minPoints = points;
            }else if(points > maxPoints)
            {
                maxPoints = points;
            }
            totalPoints += points;
            avgPoints = totalPoints / numOfAnswered;
            updateStats();
        }
        private void updateStats()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Број на одговорени прашања: " + numOfAnswered);
            stringBuilder.AppendLine("Минимално освоени поени: " +  minPoints);
            stringBuilder.AppendLine("Максимално освоени поени: " + maxPoints);
            stringBuilder.AppendLine("Вкупно освоени поени: " + totalPoints);
            stringBuilder.AppendLine("Просек на освоени поени: " + avgPoints);
            statsTb.Text = stringBuilder.ToString();    
        }
    }
}
