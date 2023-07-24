using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesingPatternsASP.Controllers
{
    public class ProductDetailController : Controller
    {
        private EarnFactory? _localEarnFactorty;
		private ForeignEarnFactory? _foreignEarnFactory;

		public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory? foreignEarnFactory)
        {
            _localEarnFactorty = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
			// Factory
			    // we dont use more this because we not use factory pattern, instead we will use DEPENDENCY INJECTION
			//LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m); 
			//ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m,20); // adding new requirement

			// Product
			var locarEarn = _localEarnFactorty!.GetEarn();
            var foreignEarn = _foreignEarnFactory!.GetEarn();

            //total
            ViewBag.totalLocal = total + locarEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
