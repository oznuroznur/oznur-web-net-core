using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using meinPortfolio.Data;
using meinPortfolio.Models;

public class ProjectDetailModel : PageModel
{
    public Project Project { get; set; }

    public IActionResult OnGet(string slug)
    {
        var found = ProjectStore.Find(slug);
        if (found == null) return NotFound();
        Project = found;
        return Page();
    }
}
