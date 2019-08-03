using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EuromonitorLessThan5
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue = "";
            int inputValueConvetered = 0;
            bool exitLoop = false;
            // NOTCE: This Loop may be exited by pressing/entering 'q' during any input phase
            while (!exitLoop)
            {
                Console.Write("Please enter a number less than 5: ");
                inputValue = Console.ReadLine();
                if(inputValue == "q")
                {
                    exitLoop = true;
                } else
                {
                    //NOTE: Safe Convertions (Also Handles Edge Cases)
                    if(Int32.TryParse(inputValue, out inputValueConvetered)){
                        Console.WriteLine(string.Format("The number required to get to 5 is {0}", EuromonitorMath.GetDifferenceToMake5(inputValueConvetered)));
                    }
                    else
                    {
                        Console.WriteLine(string.Format("{0} is not a valid number, use whole intergers only, or enter q to exit", inputValue));
                    }
                    Console.WriteLine(""); //NOTE: Adds Spacing, For Next Loop Iteration
                }
            }
        }
    }
}
