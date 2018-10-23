using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloymorphismVirtualMethodsAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Miguel = new HumanPlayer();
            Player MiguelTwo = new RandomAIPlayer();

            MoveDirection MiguelDirection = Miguel.MakeMove();
            MoveDirection MiguelTwoDirection = MiguelTwo.MakeMove();


            Console.ReadLine();
        }
    }
}
