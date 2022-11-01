using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_game_4kids.GameLogic
{
    public class MediumOperation : Operation
    {
        public MediumOperation()
        {
            fillNumberList();
            this.listSize = numbers.Count;

        }
        public override void fillNumberList()
        {
            for (int i = 0; i <= 20; i++)
            {
                numbers.Add(i);
            }
            for (int i = 30; i <= 100; i = i + 10)
            {
                numbers.Add(i);
            }

            listSize = numbers.Count;
        }
        public override void setNumbers()
        {
            num1 = getRandomNumber(listSize);
            num2 = getRandomNumber(listSize);

            if (num1 < num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            result = getRandomOperator() == '+' ? num1 + num2 : num1 - num2;
        }
    }
}
