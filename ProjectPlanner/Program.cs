namespace ProjectPlanner
{
    class Projekt
    {
        public string Name { get; set; }
        public DateOnly ExistingStart { get; set; }
        public DateOnly ExistingEnd { get; set; }
        internal class Program
        {
            static void Main(string[] args)
            {
                bool zgoda = false;
                List<Projekt> ExistingProjects = new List<Projekt>();
                ExistingProjects.Add(new Projekt { Name = "Signify", ExistingStart = new DateOnly(2020, 01, 03), ExistingEnd = new DateOnly(2020, 01, 30) });
                ExistingProjects.Add(new Projekt { Name = "Tesco", ExistingStart = new DateOnly(2020, 02, 02), ExistingEnd = new DateOnly(2020, 02, 15) });
                ExistingProjects.Add(new Projekt { Name = "Amazon", ExistingStart = new DateOnly(2020, 03, 01), ExistingEnd = new DateOnly(2020, 01, 15) });
                DateOnly projectProposalStart = new DateOnly(2020, 02, 16);
                DateOnly projectProposalEnd = new DateOnly(2020, 02, 29);
                int dlugosc = ExistingProjects.Count;
                //for (int i = 0; i < dlugosc; i++)
                //{
                //    if (projectProposalEnd < ExistingProjects[i].ExistingStart) Console.WriteLine("OK " + ExistingProjects[i].Name); 
                //    else if (projectProposalStart > ExistingProjects[i].ExistingEnd) Console.WriteLine("OK " + ExistingProjects[i].Name);
                //    else Console.WriteLine("Overlaps current project " + ExistingProjects[i].Name);
                //}
                for (int i = 0; i < dlugosc; i++)
                {
                    if (projectProposalEnd < ExistingProjects[i].ExistingStart)
                    {
                        zgoda = true;
                    }
                    else if (projectProposalStart > ExistingProjects[i].ExistingEnd)
                    {
                        zgoda = true;
                    }
                    else zgoda = false;
                }
                Console.WriteLine(zgoda);
            }
        }
    }
}