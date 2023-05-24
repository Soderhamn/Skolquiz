using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Admin_webbplats.Models;

namespace Admin_webbplats.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Admin_webbplats.Models.Category> Category { get; set; } = default!;
		public DbSet<Admin_webbplats.Models.Question> Question { get; set; } = default!;
	}
}