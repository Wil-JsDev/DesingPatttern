using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesingPattern.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private EarnFactory _LocaEarnFactory;

        public ProductDetailsController(EarnFactory locaEarnFactory)
        {
            _LocaEarnFactory = locaEarnFactory;
        }

        public IActionResult actionResult()
        {
            var localEarn = _LocaEarnFactory.GetEarn();
            return Ok(localEarn);
        }

    }
}
