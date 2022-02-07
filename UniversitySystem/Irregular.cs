using System;

namespace Vscode
{
     class Irregular : IStudents 
    {
        public string getType()
        {
          return "Irregular";
        }
        public void action(){
          Console.WriteLine("This is Irregular Student");

        }
    }

}



