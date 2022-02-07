namespace Vscode
{
    public class LessThan2 : IRegisteration
    {

        public void Courses()   ////when obj = LessThan2  this method will be called and displayed 
        {

            int i;
            List<string> ItemList = new List<string>();
            Console.WriteLine("Enter The name of the 4 Courses");

            for (i = 1; i <= 4; i++)
            {
                var Listcourse = Console.ReadLine(); // User inputs value into field.
                ItemList.Add(Listcourse);

                Console.WriteLine("Course Number" + i + " ) " + "is:" + Listcourse);

            }
            Console.WriteLine("The 4 Courses are: " + String.Join(", ", ItemList)); //String.Join<T>(string separator, IEnumerable<T> values) 
        }

    }
}





