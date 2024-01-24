﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamWebApplication2.Models
{
	public class AppDb : DbContext
	{
		public DbSet<Designation> Designations { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Experience> Experiences { get; set; }


		public DbSet<UserInfo> Users { get; set; }
		public AppDb() : base("dbConn")
		{

		}

	}
}