

using meinPortfolio.Data;
using meinPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace meinPortfolio.Pages;

public class ProjectModel : PageModel
{
    [FromRoute] public string Slug { get; set; } = default!;
    public Project? Project { get; private set; }

    public IActionResult OnGet()
    {
        Project = ProjectStore.Find(Slug);
        return Project is null ? NotFound() : Page();
    }
}
