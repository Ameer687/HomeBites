using HomeBites.Models;
namespace HomeBites.Services.Interfaces
{
    

    public interface IVendorService
    {
        Task<Vendor> RegisterVendor(Vendor vendor);
    }

}
