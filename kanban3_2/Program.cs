using System;
class Program
{   
    static void Main(String[] args)
    {
        Queue<int>queue1 = new Queue<int>();
        Queue<int>queue2 = new Queue<int>();
        Queue<int>queue3 = new Queue<int>();
        char Size = 'L';
        
        Console.WriteLine("-----------------------");
        Console.WriteLine("Please enter fruit size");
        Console.WriteLine("-----------------------");
        
        while(Size == 'L'||Size == 'M'||Size == 'S')
        {
            Size = char.Parse(Console.ReadLine());
            
            if (Size == 'L')
            {
                queue1.Push(1);
                CutL(ref queue2,ref queue3);  
            }
            else if (Size == 'M')
            {
                queue1.Push(2);
                CutM(ref queue2);
            }
            else if (Size == 'S')
            {
                queue1.Push(3);
            }
        }

        static void CutL(ref Queue<int> queue2, ref Queue<int> queue3)
        {
            queue2.Push(2);
            queue2.Push(2);

            queue3.Push(3);
            queue3.Push(3);
            queue3.Push(3);
            queue3.Push(3);
            queue3.Push(3);
            queue3.Push(3);
        }

        static void CutM(ref Queue<int> queue2)
        {
            queue2.Push(3);
            queue2.Push(3);
            queue2.Push(3);
        }

        Console.Write("Output: ");
        for(int n = 0; n < queue1.GetLength();n++)
        {
            Console.Write("{0}",queue1.Get(n));   
        }
        for(int n = 0; n < queue2.GetLength();n++)
        {
            Console.Write("{0}",queue2.Get(n));
        }
        for(int n = 0; n < queue3.GetLength();n++)
        {
            Console.Write("{0}", queue3.Get(n));
        }
    }   
}
