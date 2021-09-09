using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace InvokeMethodReflections
{
   public class StudentFunc
    {

        public String operation(String roll, String name)
        {
            if ((roll == null) || (name == null))
            {
                return null;
            }

            if (name.Any(char.IsDigit))
            {
                return null;
            }

            Assembly execution = Assembly.GetExecutingAssembly();

            Type studentType = execution.GetType("InvokeMethodReflections.Student");
            //Console.WriteLine(studentType);

            object studentObject = Activator.CreateInstance(studentType);


            MethodInfo getMethod = studentType.GetMethod("GetDetails");
            //Console.WriteLine(getMethod);

            String[] param = new String[2];
            param[0] = roll;
            param[1] = name;

            Console.WriteLine("Student Details:");
            String details = (String)getMethod.Invoke(studentObject, param);
            
            
            return details;
        }
        
    }
}
