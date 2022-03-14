using Microsoft.AspNetCore.Mvc;
using System;
using Tutorial_site_1.Domain.Entities;
using Tutorial_site_1.Domain.Repositories;
using Tutorial_site_1.Service;

namespace Tutorial_site_1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager dataManager;

        public TextFieldsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Edit(string codeword)
        {
            var entity = dataManager.TextFields.GetTextFieldByCodeWord(codeword);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(TextField model)
        {
            if (ModelState.IsValid)
            {
                dataManager.TextFields.SaveTextField(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }

            return View(model);
        }
    }
}
