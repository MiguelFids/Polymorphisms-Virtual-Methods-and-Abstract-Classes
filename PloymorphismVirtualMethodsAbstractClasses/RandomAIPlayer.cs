using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloymorphismVirtualMethodsAbstractClasses
{
    class RandomAIPlayer : Player
    {

        private Random random;

        public RandomAIPlayer()
        {
            random = new Random();
        }

        public override MoveDirection MakeMove()
        {
            int choice = random.Next(4);

            if (choice == 0) { return MoveDirection.Left; }
            if (choice == 1) { return MoveDirection.Right; }
            if (choice == 2) { return MoveDirection.Up; }
            if (choice == 3) { return MoveDirection.Down; }

            return MoveDirection.None;
        }

    }
}
