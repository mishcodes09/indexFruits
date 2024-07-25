namespace indexFruits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Fruits fr = new Fruits("Apple", "Granny Smith", "Seeded");
            Fruits fr2 = new Fruits("Orange", "Naartjie", "Seedless");

            string dispInt = "----------- accessing using int index ----------------";
            Console.WriteLine(dispInt + "\nFruit Type:  " + fr[0] + "\nFruit Name: " + fr[1] + "\nFruit Group: "+ fr[2]);

            string dispAttrName = "\n----------- accessing using attrName index ----------------";
            Console.WriteLine(dispAttrName + "\nFruit Type:  " + fr2["type"] + "\nFruit Name: " + fr2["name"] + "\nFruit Group: " + fr2["group"]);

        }
    }
}
