namespace Label_Creating_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazynek magazynek = new Magazynek("9mm", "Odłamkowa", 20, "Knauf", "Niemcy", 4356555);
            magazynek.Wyswietl();

            Kolczan kolczan = new Kolczan("Peneracyjna", "Grot", 12.4);
            kolczan.Wyswietl();
        }
    }
}
