using System.Runtime.InteropServices;

class ThreeNumbers{
  public static void Main (string[] args) {
    Console.Write("First number: ");
    int numberOne = Convert.ToInt32(Console.ReadLine());
    Console.Write("Second number: ");
    int numberTwo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Third number: ");
    int numberThree = Convert.ToInt32(Console.ReadLine());

    int smallerNumber = numberOne;
    if (numberTwo < smallerNumber){

            smallerNumber = numberTwo;
    }
    if (numberThree < smallerNumber){
        
            smallerNumber = numberThree;
  }
    Console.WriteLine("The smaller number is" + " " + smallerNumber);
  
  }
  }
