using System;
class Program
{   
    static void Main(String[] args)
    {
        Queue<char>queue1 = new Queue<char>();
        char Flower = 'J';
        int Count = 0;
        Console.WriteLine("-------------------");
        Console.WriteLine("Please enter Flower");
        Console.WriteLine("-------------------");
        
        while(Flower == 'J'||Flower == 'G'||Flower == 'O'||Flower == 'R')
        {
            Flower = char.Parse(Console.ReadLine());
            
            if (Flower == 'J')
            {
                AddJ(ref queue1);  
            }
            else if (Flower == 'G')
            {   
                AddG(ref queue1,ref Count);
            }
            else if (Flower == 'O')
            {
                AddO(ref queue1);
            }
            else if (Flower == 'R')
            {
                AddR(ref queue1);
            }
        }

        static void AddJ(ref Queue<char> queue1)
        {
            {
                queue1.Push('J');
            }
        }

        static void AddG(ref Queue<char> queue1,ref int Count)
        {
            
            if(Count < 3)
            {
             queue1.Push('G');
             Count++;   
            }
            else 
            {
               Console.WriteLine("Invalid pattern."); 
            }
        }
      
        static void AddO(ref Queue<char> queue1)
        {
            {
                queue1.Push('O');
            }
        } 

        static void AddR(ref Queue<char> queue1)
        {
            if(queue1.GetLength() != 0)
            {
                queue1.Push('R');
            }
            else
            {
               Console.WriteLine("Invalid pattern."); 
            }
        }

        Console.Write("Output: ");
        for(int n = 0; n < queue1.GetLength();n++)
        {
            Console.Write("{0}",queue1.Get(n));   
        }
    }   
}