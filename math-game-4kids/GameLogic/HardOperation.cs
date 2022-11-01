using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_game_4kids.GameLogic
{
    public class HardOperation : Operation
    {
        public HardOperation()
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
            for (int i = 20; i <= 100; i=i+5)
            {
                numbers.Add(i);
            }
        }
        public override void setNumbers()
        {
            num1 = getRandomNumber(listSize);
            num2 = getRandomNumber(listSize);

            result = getRandomOperator() == '+' ? num1 + num2 : num1 - num2;
        }
    }
}
