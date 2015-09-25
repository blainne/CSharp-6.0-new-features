﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_csharp_6_features
{
    public class ExpressionBodyOnMethods
    {
        public void Main()
        {
            var person = "Stormtrooper";

            OldComposeGreetings(person).Dump("Old compose");
            NewComposeGreetings(person).Dump("New compose");

            OldPrintGreetings(person);
            NewPrintGreetings(person);

            OldAsyncPrintGreetings().Wait();
            NewAsyncPrintGreetings().Wait();
        }




        string OldComposeGreetings(string person)
        {
            return "Hello, " + person + "!";
        }

        string NewComposeGreetings(string person) =>
            "Hello, " + person + "!";







        void OldPrintGreetings(string person)
        {
            ("Hello, " + person + "!").Dump("Old print");
        }

        void NewPrintGreetings(string person) =>
            ("Hello, " + person + "!").Dump("New print");







        async Task OldAsyncPrintGreetings()
        {
            await Task.Run(() => VoidDump("Task test", "Old task"));
        }

        async Task NewAsyncPrintGreetings()
            => await Task.Run(() => VoidDump("Task test", "New task"));






        static void VoidDump(string text, string header)
        {
            text.Dump(header);
        }
    }
}
