 
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.BlogCategoryDtos;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class BlogCategoryController : Controller
    {
        private readonly HttpClient _client = HttpClientIstance.CreatClient();

        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultBlogCategoryDto>>("blogcategory");
            return View(values);
        }
        public async Task<IActionResult> DeleteBlockCategory(int id)
        {
            await _client.DeleteAsync($"blockcategory/{id}");
            return RedirectToAction(nameof(Index));
        }
        public  IActionResult CreateBlockCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreatBlogCategoryDto updateBlogCategoryDto)
        {
            await _client.PostAsJsonAsync("blockcategory", updateBlogCategoryDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateBanner(int id)
        {
            var values = await _client.GetFromJsonAsync<CreatBlogCategoryDto>($"blockcategory/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBanner(UpdateBlogCategoryDto updateBlogCategoryDto)
        {
            await _client.PutAsJsonAsync("blockcategory", updateBlogCategoryDto);
            return RedirectToAction(nameof(Index));
        }


    }
}
