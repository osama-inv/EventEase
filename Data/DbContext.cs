using EventEase.Models;
using Microsoft.EntityFrameworkCore;

namespace EventEase.Data
{
	// create the db context class
	public class EventEaseContext : DbContext
	{

		public EventEaseContext(DbContextOptions<EventEaseContext> options) : base(options)
		{
		}

		public DbSet<Event> Events { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=.;Database=EventEase; User Id=sa; Password=sa123456;TrustServerCertificate=True;");
			}
		}
	}
}
