using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorGrid.Pages
{
    /// <summary>
    /// http://mvc6-grid.azurewebsites.net/Home/Installation
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IQueryable<Person> People { get; set; }

        public void OnGet()
        {
            People = new[]
            {
                new Person
                {
                    Name = "ABC",
                    SomeNumber = 3.1
                },
                new Person
                {
                    Name = "XYZ",
                    SomeNumber = 7.5
                }
            }
            .AsQueryable();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public double SomeNumber { get; set; }
        public DateTime Today => DateTime.UtcNow.ToLocalTime().Date;
    }
}
