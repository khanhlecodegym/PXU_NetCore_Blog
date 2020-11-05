using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IRepository;
using WebApplication1.Models;
using WebApplication1.ViewModels.TagsViewModel;

namespace WebApplication1.Controllers
{
    public class TagController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public TagController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public ActionResult Index()
        {
            var model = unitOfWork.Tag.GetAll();
            var vm = mapper.Map<List<TagViewModel>>(model);

            return View(vm);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateTagViewModel vm)
        {
            try
            {
                var model = mapper.Map<Tag>(vm);
                unitOfWork.Tag.Insert(model);
                unitOfWork.Save();

                return RedirectToAction("Index", "Tag");
            } catch
            {
                return NotFound();
            }
        }
    }
}
