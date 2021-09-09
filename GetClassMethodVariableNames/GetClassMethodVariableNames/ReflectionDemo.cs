using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
namespace GetClassMethodVariableNames
{
   public class ReflectionDemo
    {
        public ArrayList getMethodsName()
        {
            Type mymeth = typeof(Operations);
            MethodInfo[] myArrayMethodInfo = mymeth.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            ArrayList meths = new ArrayList();
            Console.WriteLine("Method Names:");
            for (int i = 0; i < myArrayMethodInfo.Length; i++)
            {
                MethodInfo myMethodInfo = (MethodInfo)myArrayMethodInfo[i];
                Console.WriteLine(myMethodInfo.Name);
                meths.Add(myMethodInfo.Name.ToString());
            }
            return meths;
        }

        public ArrayList getVariables()
        {
            Type myfield = typeof(Operations);
            Console.WriteLine("Variables present:");
            FieldInfo[] fi = myfield.GetFields();

            ArrayList vars = new ArrayList();
            foreach (FieldInfo field in fi)
            {
                Console.WriteLine(field.Name);
                vars.Add(field.Name.ToString());

            }

            return vars;
        }
    }
}
