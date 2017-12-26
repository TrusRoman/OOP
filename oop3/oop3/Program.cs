using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    public partial class CStack
    {
        public int this[int index]
        {
            set
            {
                items[index] = value;
            }

            get
            {
                return items[index];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CStack stack1 = new CStack();
            int[] a = new int[] { 12, 32, 3, 124, 1, 24, 12, 434, 12321, 34, 124, 1, -10, 232, 1 };
            for (int i = 0; i < a.Length; i++)
            {
                stack1.Push(a[i]);
            }
            stack1.Pop();
            Console.WriteLine(stack1.Peek());
            CStack stack2 = new CStack(new int[] { 12, 4, 34, 23, 42, 1, 9 });
            CStack stack3 = new CStack(new int[] { 12, 4, 34, 344, 123, 12, 15, 25, -123, -2132 });
            CStack stack4 = new CStack(new int[] { 12, 321, 412, 4, 124, -2 });
            CStack stack5 = new CStack(new int[] { 12, 321, 412, 4, 124, -2 });
            Console.WriteLine(stack2.Peek());
            Console.WriteLine(CStack.Objcount);
            CStack.ClassInfo();
            Console.WriteLine(stack2.ToString());
            CStack[] Obj_array = new CStack[4];
            Obj_array[0] = stack1;
            Obj_array[1] = stack2;
            Obj_array[2] = stack3;
            Obj_array[3] = stack4;
            int max = 0;
            int min = 100000;
            for (int i = 0; i < Obj_array.Length; i++)
            {
                if (Obj_array[i].Peek() > max)
                {
                    max = Obj_array[i].Peek();
                }
            }
            for (int i = 0; i < Obj_array.Length; i++)
            {
                if (max == Obj_array[i].Peek())
                {
                    Console.WriteLine("Stack with maximum top element - stack with element - " + Obj_array[i].Peek());
                }
            }
            for (int i = 0; i < Obj_array.Length; i++)
            {
                if (Obj_array[i].Peek() < min)
                {
                    min = Obj_array[i].Peek();
                }
            }
            for (int i = 0; i < Obj_array.Length; i++)
            {
                if (min == Obj_array[i].Peek())
                {
                    Console.WriteLine("Stack with minimum top element - stack with element - " + Obj_array[i].Peek());
                }
            }
            for (int i = 0; i < Obj_array.Length; i++)
            {
                {
                    if (CStack.Otricatelny(Obj_array[i]))
                    {
                        Console.WriteLine("Stack number " + (i + 1) + " has minus element");
                    }
                }
            }




        }
    }
}
