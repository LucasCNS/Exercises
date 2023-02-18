using Microsoft.EntityFrameworkCore;
using web_backend.Models;

namespace web_backend
{
	public class Startup
	{
		public IConfiguration Configuration { get; }
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>();
			services.AddDbContext<ApplicationDbContext>(options =>
			options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
		}


		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
		}
	}

	//public class Startup
	//{
	//	public IConfiguration Configuration { get; }
	//	public Startup(IConfiguration configuration)
	//	{
	//		this.Configuration = configuration;
	//	}

	//	// This method gets called by the runtime. Use this method to add serices to the container.
	//	public void ConfigureServices(IServiceCollection services)
	//	{
	//		services.AddDbContext<ApplicationDbContext>(options =>
	//		options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
	//		);
	//		services.AddControllersWithViews();
	//	}

	//	// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
	//	public void Configure(WebApplication app, IWebHostEnvironment env)
	//	{

	//	}
	//}
}
