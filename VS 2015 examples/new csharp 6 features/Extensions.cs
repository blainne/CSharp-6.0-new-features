using System;
using System.Collections.Generic;
using System.Linq;
using System;
using Newtonsoft.Json;

namespace new_csharp_6_features
{
    // modified example from http://www.codeproject.com/Tips/789481/Bridging-the-Gap-between-Linqpad-and-Visual-Studio
    public static class ExtensionMethods
    {
        /// <summary>
        /// This is a simple (and lazy, read: effective) solution. Simply send your
        /// object to Newtonsoft serialize method, with the indented formatting, and
        /// you have your own Dump() extension method.
        /// </summary>
        /// <typeparam name="T">The object Type</typeparam>
        /// <param name="anObject">The object to dump</param>
        /// <param name="aTitle">Optional, will print this before the dump.</param>
        /// <returns>The object as you passed it</returns>
        public static T Dump<T>(this T anObject, string aTitle = "")
        {
            var pretty_json = JsonConvert.SerializeObject(anObject, Formatting.Indented);
            if (aTitle != "")
            {
                Console.Out.WriteLine();
                Console.Out.WriteLine("===== " + aTitle + " =====: ");
            }
            Console.Out.WriteLine(pretty_json);
            return anObject;
        }
    }
}
