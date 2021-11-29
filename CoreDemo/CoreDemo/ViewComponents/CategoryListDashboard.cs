using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    [ViewComponent]
    public class CategoryListDashboard : ViewComponent
    {
        CategoryManager bm = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.List();
            return View(values);
        }


    }
}
