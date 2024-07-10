using CompanyInfo.BL.Managers.Abstract;
using CompanyInfo.Entities.Models.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInfo.MVCUI.Views.Shared.Components

{
    public abstract class MenuViewComponent : ViewComponent
    {
        private readonly IManager<Menu> menuManager;
        public MenuViewComponent(IManager<Menu> menuManager)
        {
            this.menuManager = menuManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var parentMenuler = menuManager.GetAllInclude(p => p.ParentId == null, p => p.Menuler);
            return View(parentMenuler);

        }
    }
}
