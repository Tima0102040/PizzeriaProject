using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzeriaProject.Model;

namespace PizzeriaProject.Pages.Forms;

public class CustomPizza : PageModel
{
    [BindProperty]
    public PizzasModel PizzasModel { get; set; }
    public void OnGet()
    {
        
    }
}