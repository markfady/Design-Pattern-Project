using System;
namespace Vscode
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ControlSystem obj1 = ControlSystem.GetControl();    //There is only one ControlSystem Using Singelton DesignPattern
            TypeFactory obj =new TypeFactory();
            Console.WriteLine("Please Choose From Regular , Irregular");
             string Type = Console.ReadLine();
            IStudents reg= obj.e(Type); //The input take from user then goes to Factory Class.
            reg.action();
            creator obj2 = new creator();                       //File Name (object) Where category is defined and courses are chosen
            obj2.setCourses();                                  //without parameters to let the user choose in the console run!


            courselist software=new courselist();               //Notify 2 Majors of Same College
            software.setName("Software");
     
            courselist Network=new courselist();
            Network.setName("Network");

            course critical=new course();
            critical.setName("Course1");

            critical.attach(software);
            critical.attach(Network);
            critical.setName("New Lecture in Course1!");

        

        }
    }
}