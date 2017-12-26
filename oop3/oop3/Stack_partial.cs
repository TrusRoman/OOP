using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    partial class CStack
    {
        private int[] _items;
        public int[] items
        {
            get { return _items; }
            //protected 
            set { _items = value; }
        }
        private int count;
        private const int n = 10;
        public readonly int ID;
        public static int Objcount = 0;


        //private CStack() { } //zakritii constructor

        //static CStack() konstructor klassa
        //{
        //    items = new int[n];
        //}

        public CStack()
        {
            items = new int[n];
            Objcount++;
        }

        public CStack(ref int length)
        {
            items = new int[length];
            Objcount++;
        }

        public CStack(int[] A)
        {
            items = new int[A.Length];
            for (int i = 0; i < items.Length; i++)
            {
                Push(A[i]);
            }
            Objcount++;
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public static void ClassInfo()
        {
            Console.WriteLine("Class Stek");
            Console.WriteLine("Completed");
            Console.WriteLine("Count of class: " + Objcount);
        }

        public int Count
        {
            get { return count; }
        }

        public static bool Otricatelny(CStack a)
        {
            for (int i = 0; i < a.items.Length; i++)
            {
                if (a.items[i] < 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void Push(int item)
        {
            // увеличиваем стек
            if (count == items.Length)
                Resize(items.Length + 10);

            items[count++] = item;
        }

        public int Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("stack is empty");
            int item = items[--count];
            items[count] = default(int); // сбрасываем ссылку

            if (count > 0 && count < items.Length - 10)
                Resize(items.Length - 10);

            return item;
        }//udalyaet vershinu

        public int Peek()
        {
            return items[count - 1];
        }//vozvrashaet vershinu

        private void Resize(int max)
        {
            int[] tempItems = new int[max];
            for (int i = 0; i < count; i++)
                tempItems[i] = items[i];
            items = tempItems;
        }//rasshirenie

        public override string ToString()
        {
            return "Stek prosto super, " + "v nem celih " + items.Length + " elementov mojet bit";
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return 123;
        }
    }
}

