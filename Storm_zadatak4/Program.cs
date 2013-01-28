using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Storm_zadatak4
{
    public class NumberList<T>
    {
        class ListNode
        {
            private ListNode next;
            private T element;

            public ListNode(T item)
            {
                next = null;
                element = item;
            }

            public ListNode Next
            {
                get
                {
                    return next;
                }

                set
                {
                    next = value;
                }
            }

            public T Element
            {
                get
                {
                    return element;
                }

                set
                {
                    element = value;
                }
            }
        }

        private ListNode head;

        public NumberList()
        {
            head = null;
        }
        //fja
        public void AddHead(T item)
        {
            ListNode node = new ListNode(item);
            node.Next = head;
            head = node;
        }

        //override
        public IEnumerator<T> GetEnumerator()
        {
            ListNode current = head;

            while (current != null)
            {
                yield return current.Element;
                current = current.Next;
            }
        }
    }

    public class Program
    {
        //metoda za stvaranje genericke liste za bilo koji tip broja
        //private static Object CreateCustomList(Type typeX)
        //{
        //    Type listType = typeof(List<>);
        //    Type[] typeArgs = { typeX };
        //    Type customType = listType.MakeGenericType(typeArgs);
        //    object obj = Activator.CreateInstance(customType);

        //    return obj;
        //}

        static void Main(string[] args)
        {
            

            //Console.WriteLine("==========================");
            //Console.WriteLine("Izaberite jednu od opcija:");
            //Console.WriteLine("==========================");

            //integer list
            NumberList<int> intList = new NumberList<int>();//objekt
            int _num1 = 43453254;
            int _num2 = 34546457;
            int _num3 = 4;

            intList.AddHead(_num1);
            intList.AddHead(_num2);
            intList.AddHead(_num3);

            //
            foreach (int nums in intList)
            {
                Console.WriteLine("***" + nums);
            }

            Console.ReadKey();
            //string listType = 23;
            //Type t = Type.GetType(listType);



            //Console.Write("Izaberite opciju:\n");
            //ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        }
    }
}
