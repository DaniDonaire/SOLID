using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace SingleResponsibility
{
    public static class Lists <T>
    {

        public static List<T> AddToList(List<T> list, T obj)
        {
            list.Add(obj);
            PrintList(list);
            return list;
        }

        public static void PrintList(List<T> list)
        {
            foreach (var item in list)
                Console.WriteLine(item.ToString());
        }

    }
}
