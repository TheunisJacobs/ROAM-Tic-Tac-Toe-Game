namespace ROAMTicTacToe.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
            this.ContextKey = "ROAMTicTacToeGame.Data.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
        }
    }
}
