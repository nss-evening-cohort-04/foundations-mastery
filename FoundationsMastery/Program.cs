using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foundations Mastery Exercise");
            var showThatAdditionalClassIsWorking = new AdditionalClass();
            Console.WriteLine(showThatAdditionalClassIsWorking.AdditionalClassDoesSomething(""));

            var showThatUsingAdditionalClassIsWorking = new UsingAdditionalClass();
            Console.WriteLine(showThatUsingAdditionalClassIsWorking.AdditionalClassDoesSomething(""));

            var list1 = new List<char> { 'a', 'b', 'c', 'd' };
            var list2 = new List<char> { 'x', 'y', 'z' };
            CustomString customList1 = new CustomString(list1);
            CustomString customList2 = new CustomString(list2);

            Console.WriteLine("using Print(): "+ customList1.Print());
            Console.WriteLine("Concat: "+customList2.Concat(list2).ToString());
            
            Console.WriteLine("customList1 type: "+customList1.GetType());
            

            //foreach (var value in list1)
            //{
            //    var valueType = value.GetType();
            //    var valueToString = value.ToString();
            //    Console.WriteLine(value + " value type= " + valueType);
            //    Console.WriteLine(value + " value to string= " + valueToString);
            //}
            //list1 = new List<char>();
            //foreach (var newvalue in list1)
            //{
            //    var newValueToString = newvalue.ToString();
            //    Console.WriteLine("After clearing values: " + newValueToString);
            //    //nothing prints because theres nothing to loop through
            //}

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
