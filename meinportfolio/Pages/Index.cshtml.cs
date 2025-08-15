using Microsoft.AspNetCore.Mvc.RazorPages;
using meinPortfolio.Data;
using meinPortfolio.Models;

namespace meinportfolio.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public List<Project> Projects { get; private set; } = [];
    public void OnGet()
    {
        Projects = ProjectStore.All;
    }
}
