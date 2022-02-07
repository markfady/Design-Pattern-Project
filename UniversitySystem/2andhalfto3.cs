namespace Vscode
{
    public class twoandhalfto3 : IRegisteration
    {

        public void Courses()    //when obj 2 = twoandhalfto3  this method will be called and displayed 
        {
            
            int i;
            Console.WriteLine("Enter The name of the 6 Courses");
            List<string> ItemList = new List<string>();

            for (i = 1; i <= 6; i++)
            {
                     var Listcourse = Console.ReadLine(); // User inputs value into field.
                    ItemList.Add(Listcourse);

                Console.WriteLine("Course Number" + i + " ) " + "is:" + Listcourse);

            }
                    Console.WriteLine("The 6 Courses are: "+String.Join(", ", ItemList)); 
        }
    }
}




