namespace Vscode
{
    public class morethan3 : IRegisteration 
    {

        public void Courses()      //when obj 3 = morethan 3 this method will be called and displayed 
        {
          
            int i;
            Console.WriteLine("Enter The name of the 6 Courses&The 7th is optional");
             List<string> ItemList = new List<string>();

            for (i = 1; i <= 7; i++)
            {
             
                     var Listcourse = Console.ReadLine(); // User inputs value into field.
                    ItemList.Add(Listcourse);

                Console.WriteLine("Course Number" + i + " ) " + "is:" + Listcourse);

            }
                Console.WriteLine("The Courses are: "+String.Join(", ", ItemList));
        }


    }

}



