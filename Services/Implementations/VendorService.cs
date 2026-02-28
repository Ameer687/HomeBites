using HomeBites.Data;
using HomeBites.Models;
using HomeBites.Services.Interfaces;
namespace HomeBites.Services.Implementations
{
    

    public class VendorService : IVendorService
    {
        private readonly HomeBitesContext _context;

        public VendorService(HomeBitesContext context)
        {
            _context = context;
        }

        public async Task<Vendor> RegisterVendor(Vendor vendor)
        {
            _context.Vendors.Add(vendor);
            await _context.SaveChangesAsync();
            return vendor;
        }
    }

}
