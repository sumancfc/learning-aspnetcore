using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages;

public class ContactModel : PageModel
{
    private readonly ILogger<AboutModel> _logger;

    public ContactModel(ILogger<AboutModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}