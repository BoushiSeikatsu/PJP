using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammar
{
    public static class ExtensionsAssistant
    {
        static void printHashSet<T>(this HashSet<T> set)
        {
            foreach(T item in set)
            {
                Console.Write(item + " ");
            }
        }
    }
}
