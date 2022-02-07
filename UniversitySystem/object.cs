namespace Vscode
{
    public class creator
    {                                            //Using Polymorphism&Strategy Design Pattern Concept.
        IRegisteration obj = new LessThan2();  //The Parent Can Create object From child
        IRegisteration obj2 = new twoandhalfto3();
        IRegisteration obj3 = new morethan3();




        public void setCourses()
        {
            string name;
            Console.WriteLine("Choose Your GPA category >>LessThan2 , twoandhalfto3 ,morethan3");  //each object from it's class (<3,>3,>2)
            name = Console.ReadLine();
            if (name == "LessThan2")                            //if data Entered by user = "" then return ""
            {
                obj.Courses();
            }
            else if (name == "twoandhalfto3")
            {
                obj2.Courses();
            }
            else if (name == "morethan3")
            {
                obj3.Courses();
            }
            else{ 
   Console.WriteLine(new Nullvalue());
        }
        }


    }
}





