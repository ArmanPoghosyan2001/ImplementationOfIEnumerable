using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection users = new UserCollection();

            IEnumerable enumerable = users as IEnumerable;
            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Element element = enumerator.Current as Element;
                Console.WriteLine(element.Name);
            }
            enumerator.Reset();
        }
    }
}
