using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    public  class SlotMachine
    {
        // this will bake the slot machine
        static int m;
        static int row1, row1Max, row1Min;
        static int row2, row2Max, row2Min;
        static int row3, row3Max, row3Min;
       
        public static void MakeMachine()
        {
            string[] machine = new string[5];
            machine[0] = "Left";
            machine[1] = "Top";
            machine[2] = "Right";
            machine[3] = "Bottom";
            machine[4] = "Screen";
            Console.WriteLine(String.Format("This is: {0} Side", machine[0]));
            Console.WriteLine(String.Format("This is: {0} Side", machine[1]));
            Console.WriteLine(String.Format("This is: {0} Side", machine[2]));
            Console.WriteLine(String.Format("This is: {0} Side", machine[3]));
            Console.WriteLine(String.Format("This is: {0} Side", machine[4]));
            row1Min = 1;
            row1Max = 4;
            
            Thread TSpin = new Thread(SpinSlot);
            TSpin.Start();
        }

        //initiate the spin
        public static void SpinSlot()
        {
            
            
            for (int i = 0; i < 100; i++)
            {
                //row1 = GetRandomNumber(row1Max, row1Min);
                //row2 =GetRandomNumber(row2Max, row2Min);
                //row3=  GetRandomNumber(row3Max, row3Min);
                //row4 = GetRandomNumber(row4Max, row4Min);
                RollSlot(row1Max, row1Min);
                Console.WriteLine("Row 1 Value is: " + row1);
                Console.WriteLine("Row 2 Value is: " + row2);
                Console.WriteLine("Row 3 Value is: " + row3);

                Thread.Sleep(4000);
            }
        }

        //Stop the slot
        public void StopSlot()
        {

        }

        public static int GetRandomNumber(int MaxNum, int MinNum)
        {
            int retNum; 
            Random ran = new Random();
            retNum = ran.Next(MinNum, MaxNum);
            return retNum;
        }

        private static void RollSlot(int MaxNum, int MinNum)
        {
            // variable m will increment by 10
            m = m + 10;
            Random ran = new Random();
            

            // if m will be equal to 1000 and above
            if (m <= 100)
            {
                // randomize variable a
                row1 = ran.Next(MinNum, MaxNum);
                row2 = ran.Next(MinNum, MaxNum);
                row3 = ran.Next(MinNum, MaxNum);
               

                //contents of variable a
                switch (row1)
                {
                    case 1:
                        //path of the image file of apple
                        Console.WriteLine("Apple");
                        break;
                    //path of the image file of grapes
                    case 2:
                        Console.WriteLine("Grapes");
                        break;
                    //path of the image file of strawberry
                    case 3:
                        Console.WriteLine("Strawberry");
                        break;

                }
                //contents of b variable
                switch (row2)
                {
                    //path of the image file of apple
                    case 1:
                        //path of the image file of apple
                        Console.WriteLine("Apple");
                        break;
                    //path of the image file of grapes
                    case 2:
                        Console.WriteLine("Grapes");
                        break;
                    //path of the image file of strawberry
                    case 3:
                        Console.WriteLine("Strawberry");
                        break;

                }
                //contents of variable c
                switch (row3)
                {
                    //path of the image file of apple
                    case 1:
                        //path of the image file of apple
                        Console.WriteLine("Apple");
                        break;
                    //path of the image file of grapes
                    case 2:
                        Console.WriteLine("Grapes");
                        break;
                    //path of the image file of strawberry
                    case 3:
                        Console.WriteLine("Strawberry");
                        break;

                }

            }
            else
            {
                
                // m variable will be back to 0
                m = 0;
                // if contents of a will be equal to b and c, you will win the prize
                if (System.Convert.ToInt32(row1 == row2) == row3)
                {
                    Console.WriteLine("Jackpot! You won $1000");
                }
                // otherwise, you've lost
                else
                {
                    Console.WriteLine("No luck, try again");

                }
            }

        }

         

    }
}
