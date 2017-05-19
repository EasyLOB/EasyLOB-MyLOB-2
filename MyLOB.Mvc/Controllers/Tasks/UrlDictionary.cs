﻿using EasyLOB.Resources;
using System.Web.Mvc;

namespace EasyLOB.Mvc
{
    public partial class TasksController
    {
        #region Methods

        // GET: Tasks/UrlDictionary
        [HttpGet]
        public ActionResult UrlDictionary()
        {
            TaskViewModel viewModel = new TaskViewModel("Tasks", "UrlDictionary", PresentationResources.TaskUrlDictionary);

            return View(viewModel);
        }

        #endregion Methods
    }
}