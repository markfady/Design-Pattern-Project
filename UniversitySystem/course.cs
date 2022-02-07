namespace Vscode
{
    public class course : Icourse
    {
        List<IcourseList> observers;
        string name;

       public  course(){
            observers = new List<IcourseList>();
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
            notify();          //when the name changed notify must displayed.
        }

        public void attach(IcourseList observer)
        {   
            observers.Add(observer);
        }

        public void deattach(IcourseList observer)
        {
            observers.Remove(observer);

        }

        public void notify()
        {
            foreach(IcourseList  observer in observers){
                observer.update(this); 
                
            }
        }
    }

}





