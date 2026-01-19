namespace hw_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oceanarium<ISeaCreature> oceanarium = new Oceanarium<ISeaCreature>();

            oceanarium.Add(new Fish("Susi", "Osetr"));
            oceanarium.Add(new Dolphin("Dustin", "Default dolphin"));
            oceanarium.Add(new Shark("Stas", "White shark"));

            foreach (var creature in oceanarium)
            {
                Console.WriteLine(creature);
            }
        }
    }
}
