namespace Vscode
{   
    public  interface Icourse
    { 
  
    void notify(); //Notify will call update method in (IcourseList interface)
    void attach(IcourseList observer );
    void deattach(IcourseList observer );
    }
    
}

        
            
        
    
