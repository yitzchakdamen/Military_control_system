namespace Military_control_system
{
    class Aman
    {
        public Database Database;
        public Aman(Database database)
        {
            Database = database;
        }

        public int mostDangerousTerrorist()
        {
            int IdTerrorist = 1;
            for (int id = 1; id < Database.databaseIntelligence.Count; id++)
            {
                Terrorist terrorist = Database.databaseTerrorist[id];
                if (terrorist.IsAlive && terrorist.QualityScore() > IdTerrorist)
                {
                    IdTerrorist = id;
                }
            }
            return IdTerrorist;
        }

        public int mostInformation()
        {
            int IdTerrorist = 1;
            for (int id = 1; id < Database.databaseIntelligence.Count; id++)
            {
                 Terrorist terrorist = Database.databaseTerrorist[id];
                if (terrorist.IsAlive && Database.databaseIntelligence[id].Count > IdTerrorist)
                {
                    IdTerrorist = id;
                }
            }
            return IdTerrorist;
        }

    }
    
}