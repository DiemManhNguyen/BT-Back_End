using Microsoft.AspNetCore.Mvc;
using YourProjectName.Models;

namespace YourProjectName.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details()
        {
            // Tạo một sản phẩm mẫu
            var product = new Product
            {
                Id = 1,
                Name = "Điện thoại thông minh",
                Price = 15000000
            };

            // Truyền sản phẩm sang View
            return View(product);
        }
    }
}
