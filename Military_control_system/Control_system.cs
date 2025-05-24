namespace Military_control_system
{
    class ControlSystem
    {
        Database database;
        Aman aman;
        Force force;
        Attack_Management attack_Management;
        public ControlSystem(Organization organization, Organization organizationEnemy, string officerName)
        {

            database = new();
            initialization.InitializeDatabase(database, organizationEnemy);

            aman = new(database);
            force = new(organization, initialization.initializationAttackSystem());
            attack_Management = new(database, officerName, force);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Control system activated\n");
            Console.ResetColor();
            force.PrintReport();

        }

        public void IntelligenceAnalysis()
        {
            int IdTerrorist = aman.mostInformation();
            Terrorist terrorist = database.GetTerroristBiId(IdTerrorist);

            Console.WriteLine(" ======= The terrorist with the most intelligence =======");
            terrorist.Print();

        }
        public void AttackAvailability()
        {
            force.PrintReport();
        }

        public void TargetPrioritization()
        {
            int IdTerrorist = aman.mostDangerousTerrorist();
            Terrorist terrorist = database.GetTerroristBiId(IdTerrorist);

            Console.WriteLine(" ======= The most dangerous terrorist =======");
            terrorist.Print();

        }

        public void AttackExecution()
        {
            int IdTerrorist = aman.mostDangerousTerrorist();
            attack_Management.AttackExecution(IdTerrorist);
            
        }

    }
    
}