using ALTC_Website.Services;
using ALTC_Website.ViewModels;
using Microsoft.AspNetCore.Mvc;
using SharpCompress.Common;
using System.ComponentModel.DataAnnotations;

namespace ALTC_Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RequestController : Controller
    {
        private readonly IRequestService requestService;
        public RequestController(IRequestService _requestService)
        {
            requestService = _requestService;
        }
        public IActionResult Index()
        {
          var requests=  requestService.GetAll();
          List<RequestVM> requestsVM = requests.Select(r => new RequestVM{Name=r.Name,Email=r.Email,Phone=r.Phone,Details=r.Details,File=null}).ToList();
          
            return View(requestsVM);
        }
        public IActionResult Download(string name)
        {
            //var fileBytes = System.IO.File.ReadAllBytes(filepath);
            //var fileName = Path.GetFileName(filepath);
            //return File(fileBytes, "application/octet-stream", fileName);

            return RedirectToAction(nameof(Index));

        }
    }
}
