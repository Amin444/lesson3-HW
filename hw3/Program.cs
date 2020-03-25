using System;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
          /* int A=6,B=6;
           if(A==B)System.Console.WriteLine($"A={0} B={0}");
           if(A>B)System.Console.WriteLine($"A={A} B={A}");
           if(A<B)System.Console.WriteLine($"A={B} B={B}");*/
        
                   //task 3
              /*double operand1 =double.Parse(Console.ReadLine());
              string sing=Console.ReadLine();
              double operand2 =double.Parse(Console.ReadLine());

                switch(sing)
                {
                    case "+":System.Console.WriteLine(operand1+operand2);break;
                    case "-":System.Console.WriteLine(operand1-operand2);break;
                    case "*":System.Console.WriteLine(operand1*operand2);break;
                    case "/":
                    {
                        if(operand1==0||operand2==0)
                        {System.Console.WriteLine("error!!!");}

                           System.Console.WriteLine(operand1/operand2);break;
                    } 
                     default:Console.WriteLine("error!!!"); break; 
                }*/
                
               
                      //task 4

                            int num=int.Parse(Console.ReadLine());
                            
                            if(num>=0&&num<15)System.Console.WriteLine($"В промежутке[0-14]->{num}");
                            if(num>14&&num<36)System.Console.WriteLine($"В промежутке[15-35]->{num}");
                            if(num>=36&&num<51)System.Console.WriteLine($"В промежутке[36-50]->{num}");
                            if(num>=50&&num<101)System.Console.WriteLine($"В промежутке[50-100]->{num}");
                        Console.ReadKey();
                     
                       
                        
                        

        }
    }
}
