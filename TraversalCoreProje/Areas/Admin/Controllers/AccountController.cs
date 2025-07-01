using BusinessLayer.Abstract.AbstractUow;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {  private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AccountViewModel model)
        {
            var valuesender = _accountService.TGetByID(model.SenderID);
            var valuereceiver = _accountService.TGetByID(model.ReceiverID);

            valuesender.Balance -= model.Amount;
            valuereceiver.Balance += model.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                valuesender,
                valuereceiver
            };

            _accountService.TMultiUpdate(modifiedAccounts);
            return View();
        }
    }
}
