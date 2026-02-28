using HomeBites.Data;
using HomeBites.Models;
using HomeBites.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HomeBites.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendorsController : ControllerBase
    {
        private readonly IVendorService _vendorService;

        public VendorsController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(Vendor vendor)
        {
            var result = await _vendorService.RegisterVendor(vendor);
            return Ok(result);
        }
    }


}
