using System.Collections.Generic;

namespace CodeFirstToANewDatabase
{
	internal class Blog
	{
		public int BlogId { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }

		public List<Post> Posts { get; set; }
	}
}