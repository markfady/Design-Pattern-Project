namespace Vscode
{
    public class courselist : IcourseList
    {

        string name;
        public string getName(){
            return name;
        }
        public void setName(string name){
            this.name=name;
        }

        public void update(Icourse Course)
        {
            course c =Course as course;   //With class not the interface
            Console.WriteLine("Major"+name+"Updated:"+c.getName()); 

        }
    }

}

        
            
        
    
 