using System;

public class TextInput
{
    public string sValue;
    public virtual void Add(char c)
    {
        sValue = sValue + c;
    }

    public string GetValue()
    {        

        return sValue;
    }


}


public class NumericInput :TextInput
{
    public override void Add(char c)
    {
        if (char.IsDigit(c))
        {
            sValue = sValue + c;
        }
    }
}

public class UserInput
{
//    Console.ReadLine();


//            Bagpack pack = null;
//    List<Bagpack> packs = new List<Bagpack>();
//    bool isRunnig = true;
//    int i = 0;
//            while(isRunnig)
//            {
//                Console.WriteLine("Welcome!! You are inside bagPack");
//                Console.WriteLine("\t Press [1] to Enter Item in the Bagpack:");
//                Console.WriteLine("\t Press [2] to show contents Bagpack:");
//                Console.WriteLine("\t Press [3] to remove Item in the Bagpack:");
//                Console.WriteLine("\t Press [4] to clear all contents in the Bagpack:");
//                Console.WriteLine("\t Press [5] to Exit:");
                               
//                int iVal = Convert.ToInt16(Console.ReadLine());                
//              switch(iVal)
//                {
//                    case 1:
//                        Console.WriteLine("Enter your Item:");
                        
//                        pack = new Bagpack();
//    pack.Item = Console.ReadLine();
//                        packs.Add(pack);
//                        break;
//                    case 2:
//                        Console.WriteLine("Your contents are: ");
//                         i = 0;
//                        foreach (var item in packs)
//                        {
//                            i = i++;
//                            Console.WriteLine("Item No " + i + ":" + item.Item);
//                        }
//Console.WriteLine("Total No of Items in the bag:" + i);
//break;
//                    case 3:
//                        Console.WriteLine("Name the Item to remove:");
//pack = new Bagpack();
//pack.Item = Console.ReadLine();
//packs.Remove(pack);
//i = 0;
//foreach (var item in packs)
//{
//    i = i++;
//    Console.WriteLine("Item No " + i + ":" + item.Item);
//}
//Console.WriteLine("Remaining Items are:");
//break;
//                    case 4:
//                        Console.WriteLine("Your all times are cleared:");
//packs.Clear();
//Console.WriteLine("All items are cleared !!");
//break;
//                    case 5:
//                        isRunnig = false;
//break;
//default:
//                        Console.WriteLine("Incorrect Input please enter between 1-4");
//break;

//                }              


//            }
}