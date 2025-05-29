// Controllers/UserController.cs
using System.Web.Mvc;

public class UserController : Controller
{
    private static List<User> _users = new List<User>(); // Lưu trữ tạm trong bộ nhớ

    // GET: User/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: User/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(User user)
    {
        if (ModelState.IsValid)
        {
            // Thêm người dùng vào danh sách tạm
            _users.Add(user);

            // Hiển thị thông báo thành công
            TempData["Message"] = "Thêm người dùng thành công!";
            return RedirectToAction("List"); // Chuyển đến trang danh sách
        }

        return View(user);
    }

    // GET: User/List
    public ActionResult List()
    {
        return View(_users);
    }
}