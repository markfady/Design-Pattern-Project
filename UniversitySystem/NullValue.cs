using System;

namespace Vscode
{
     class Nullvalue : IStudents 
    {
        
        public string getType()
        {
            return "invalid input";
        }
        public void action(){                           
            int exitCode=0;
            Console.WriteLine ("Please Enter The Type of student accurate");
             Environment.Exit(exitCode);  //If the user entered wrong value The Program will terminate 

        }
    }

}



