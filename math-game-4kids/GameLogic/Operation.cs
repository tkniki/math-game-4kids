using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace math_game_4kids.GameLogic
{
    public abstract class Operation
    {
        protected int num1;
        protected int num2;
        protected int result;
        protected List<int> numbers;
        protected int listSize;
        Random random = new Random();
        public abstract void fillNumberList();
        public char getRandomOperator()
        {
            if (random.Next(2) == 0) { return '+'; }
            else return '-';
        }
        public int getRandomNumber(int listSize)
        {
            return random.Next(listSize);
        }
        public abstract void setNumbers();

    }
}
