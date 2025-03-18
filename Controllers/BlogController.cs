using Blog_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog_System.Controllers;
public class BlogController(ApplicationDbContext context) : Controller
{
    private readonly ApplicationDbContext _context = context;

    public IActionResult Index()
    {
        var posts = _context.Posts.ToList();
        return View(posts);
    }

    // Show details of a single post
    public IActionResult Details(int id)
    {
        var post = _context.Posts.Find(id);
        if (post == null) return NotFound();
        return View(post);
    }

    // Show form to create a new post
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(BlogPost post)
    {
        if (ModelState.IsValid)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(post);
    }

    // Show form to edit a post
    public IActionResult Edit(int id)
    {
        var post = _context.Posts.Find(id);
        if (post == null) return NotFound();
        return View(post);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, BlogPost post)
    {
        if (id != post.Id) return NotFound();

        if (ModelState.IsValid)
        {
            _context.Posts.Update(post);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(post);
    }

    // Confirm delete
    public IActionResult Delete(int id)
    {
        var post = _context.Posts.Find(id);
        if (post == null) return NotFound();
        return View(post);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var post = _context.Posts.Find(id);
        if (post == null) return NotFound();

        _context.Posts.Remove(post);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}
