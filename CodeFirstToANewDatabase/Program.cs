using System;
using System.Linq;
using System.Data.Entity;

namespace CodeFirstToANewDatabase
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new BloggingContext())
			{
				//Create and save a new Blog
				Console.Write("Enter a name for a new Blog: ");
				var name = Console.ReadLine();

				var blog = new Blog { Name = name };
				db.Blogs.Add(blog);
				db.SaveChanges();

				//Display all Blogs drom the database
				var query = from b in db.Blogs
							orderby b.Name
							select b;

				Console.WriteLine("All blogs in the database: \n");
				foreach (var item in query)
				{
					Console.WriteLine(item.Name);
				}

				Console.WriteLine("\nPress any key to exit... ");
				Console.ReadKey();

			}

		}
	}

	class BloggingContext : DbContext
	{
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>()
				.Property(u => u.DisplayName)
				.HasColumnName("display_name");
		}
	}
}
