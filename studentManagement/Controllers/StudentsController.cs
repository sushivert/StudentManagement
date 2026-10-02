using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using studentManagement.Data;

namespace studentManagement.Controllers;

public class StudentsController : Controller
{
    private readonly AppDbContext _db;

    public StudentsController(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        var students = await _db.Students
            .OrderBy(s => s.LastName)
            .ToListAsync();

        return View(students);
    }
}