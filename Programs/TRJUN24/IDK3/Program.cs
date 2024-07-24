namespace IDK3;

class Program
{
    
    public class IOBoard
    {
        public int p1=0;
        public int p2=0;
        public int p3=0;
        public int p4=0;
        public int p5=1;
        public int p6=0;
        public int p7=0;
        public int p8=0;

        public int[] state;
        
        public IOBoard()
        {
            state =new int [] {p1,p2,p3,p4,p5,p6,p7,p8};
        
        }
        
    }
    
    
    static void Main(string[] args)
    {
         IOBoard ioBoard1 = new IOBoard();

            for (int i = 0; i < ioBoard1.state.Length; i++)
            {
                ioBoard1.state[i] = 0;
            }

            // Output the state array to verify changes
            foreach (var i in ioBoard1.state)
            {
                Console.WriteLine(i);
            }

            

    }
}
