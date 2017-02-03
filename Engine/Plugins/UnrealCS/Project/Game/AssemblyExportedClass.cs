using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnrealEngine;

namespace Game
{
    public class AssemblyExportedClass
    {
        public static void GetExportedTypes(ref string[] data)
        {
            List<string> classList = new List<string>();
            foreach (Type t in Assembly.GetExecutingAssembly().GetExportedTypes())
            {
                if (t.IsClass && t.IsSubclassOf(typeof(UObject)))
                {
                    classList.Add(t.Name);
                }
            }
            data = classList.ToArray();
        }
    }
}
