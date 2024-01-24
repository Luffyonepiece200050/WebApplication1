namespace ExamWebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExamWebApplication2.Models.AppDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ExamWebApplication2.Models.AppDb context)
        {
			


			context.Users.AddOrUpdate(new Models.UserInfo() { UserName = "admin", Password = "abc123", Role = "Admin" });


			context.Users.AddOrUpdate(new Models.UserInfo() { UserName = "ditc", Password = "123456", Role = "User" });
		}
    }
}
