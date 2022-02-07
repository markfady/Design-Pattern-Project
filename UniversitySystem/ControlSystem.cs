namespace Vscode
{
    public class ControlSystem
    {
        private static ControlSystem obj;
        private ControlSystem() {}
        public static ControlSystem GetControl()
        {
            if (obj == null){
                obj = new ControlSystem();
                Console.WriteLine("Welcome To our University! This is the ControlSystem");
                return obj;
            }
                else
                {
                    return obj;
                }
            }
        }
    }
