using System.Collections;

namespace Listen {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Liste!");

            ArrayList al = new ArrayList();
            al.Add("Mohamad");
            al.Add("Matthias");
            al.Add("Alexander");
            al.Add("Alexander");
            al.Add("Ugur");

            foreach (string name in al) {
                Console.WriteLine( name );
            }

            Console.Read();
        }
    }
}