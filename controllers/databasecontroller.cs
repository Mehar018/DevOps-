using Microsoft.AspNetCore.Mvc;

public class DatabaseController : Controller
{
    public IActionResult DatabaseAccess()
    {
        return Content("Database access has already been done on Nov 28, 2024, by Mehar.");
    }
}
