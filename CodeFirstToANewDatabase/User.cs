using System.ComponentModel.DataAnnotations;

namespace CodeFirstToANewDatabase
{
	public class User
	{
		[Key]
		public string Username { get; set; }
		public string DisplayName { get; set; }
	}
}
