﻿using Portal.CMS.Services.Themes;
using Portal.CMS.Web.Architecture.Helpers;
using Portal.CMS.Web.Areas.PageBuilder.ViewModels.Theme;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Portal.CMS.Web.Areas.PageBuilder.Controllers
{
    [SessionState(SessionStateBehavior.ReadOnly)]
    public class ThemeController : Controller
    {
        #region Dependencies

        readonly IThemeService _themeService;

        public ThemeController(IThemeService themeService)
        {
            _themeService = themeService;
        }

        #endregion Dependencies

        public ActionResult Render()
        {
            var model = new ThemeViewModel
            {
                Theme = AsyncHelpers.RunSync(() => _themeService.GetDefaultAsync())
            };

            return View(model);
        }
    }
}