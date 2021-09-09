using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept_Inheritance
{
   public class CallingClass
    {
        static void Main(string[] args)
        {
            Professor prof = new Professor();
            prof.profName = "Professor_Name";
            string proff = prof.profName;
            prof.subject = "Triple Integration";
            prof.teach("Triple Integration");
            prof.work = "Professor";
            prof.Duty(prof.work);
            prof.dept = "Mathematics";
            prof.Department(prof.dept);
            Console.WriteLine("Prof. " + prof.profName + " is working at " + prof.collegeName + " in the department of " + prof.dept + " teaching " + prof.subject + " as a " + prof.work);
            Console.WriteLine("\n");

            Employee emp = new Employee();
            emp.employeeName = "Employee_Name";
            emp.hours = 10;
            emp.workHour(emp.hours);
            emp.work = "Peon";
            emp.Duty(emp.work);
            emp.Department("Maintenance");
            Console.WriteLine("Mr. " + emp.employeeName + " working at " + emp.collegeName + " in the dpartment of " + emp.dept + " as a " + emp.work + " and will work for " + emp.hours + " hours");
            Console.WriteLine("\n");

            Student student = new Student();
            student.studentName = "Student_Name";
            student.majorSub = "Algorithms";
            student.Major(student.majorSub);
            student.work = "Research Scholar";
            student.Duty(student.work);
            student.dept = "CSE";
            student.Department(student.dept);
            Console.WriteLine("Mr. " + student.studentName + " studying at " + student.collegeName + " in the department of " + student.dept + " as a " + student.work + " in the field of " + student.majorSub);

            Console.ReadLine();
        }
    }
}
