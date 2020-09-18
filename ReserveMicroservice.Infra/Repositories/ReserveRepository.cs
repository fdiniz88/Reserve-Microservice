using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReserveMicroservice.Common.Domain.DTO;
using ReserveMicroservice.Common.Infra.DataAccess;
using ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate;
using ReserveMicroservice.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ReserveMicroservice.Infra.Repositories
{
   public class ReserveRepository : EntityFrameworkRepositoryBase<Guid, Reserve>, IReserveRepository
    {       
        private readonly DbContext _DbContext;
        public ReserveRepository(DbContext DbContext)
      : base(db: DbContext)
        {            
            _DbContext = DbContext;            
        }
 
        public async Task<IEnumerable<ReserveDto>> ReadAllReservesAsync(Guid CarId)
        {
         
            return await (from r in _DbContext.Set<Reserve>()
                          join m in _DbContext.Set<MoneyValue>() on r.MoneyValue.Id equals m.Id
                          where r.CarId == CarId
                          select new ReserveDto
                          {
                              ReserveId = r.Id,
                              CarId = r.Id,
                              ActionType = r.ActionType.ToString(),
                              RentalDate = r.RentalDate,
                              DevolutionDate = r.DevolutionDate,
                              Value = m.Value,
                              Currency = m.Currency

                          }).Distinct().ToListAsync();
          
        }
    }
}
