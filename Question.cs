using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathquiz
{
    public class Question
    {
        public int a;
        public int b;
        public int result;
        public char sign;
        public int points;
        public bool isCorrect;
        public Question(int a, int b, char sign)
        {
            this.a = a;
            this.b = b;
            this.sign = sign;
            isCorrect = false;
            calculate();
        }
        private void calculate()
        {
            switch(sign)
            {
                case '-':
                    result = a - b;
                    points = a.ToString().Length+b.ToString().Length;
                    break;
                case '+': 
                    result = a + b;
                    points = a.ToString().Length + b.ToString().Length;
                    break;
                case '*': 
                    result = a * b;
                    points = (a.ToString().Length + b.ToString().Length)*3;
                    break;
            }
        }

        public override string ToString()
        {
            return a.ToString() + " " + sign + " " + b.ToString() + " = ";
        }
    }
}
