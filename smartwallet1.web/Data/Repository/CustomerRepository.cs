using Microsoft.EntityFrameworkCore;
using smartwallet1.web.Data.Entities;
using smartwallet1.web.Data.Repository.Interface;
using SmartWallet1.Web.Data.Repositories;

namespace smartwallet1.web.Data.Repository
{
    public class CustomerRepository : Repository<Customer, Guid>
    {
        public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}