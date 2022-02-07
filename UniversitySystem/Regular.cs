using System;

namespace Vscode
{
     class Regular : IStudents 
    {
        public string getType()
        {
          return "Regular";
        }
        public void action(){
          Console.WriteLine("This is Regular Student");
    
  

        }
    }

}



