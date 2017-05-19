using System.Web.Mvc;

namespace MyLOB.Mvc
{
    public partial class MyLOBTasksController
    {
        #region Methods

        // GET: MyLOBTasks/MyLOBAPIIndex
        [HttpGet]
        public ActionResult MyLOBAPIIndex()
        {
            return View();
        }

        #endregion Methods
    }
}