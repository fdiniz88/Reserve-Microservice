using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReserveMicroservice.Common.Domain.DTO;
using ReserveMicroservice.Common.Domain.Interfaces.Repositories;

namespace ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate
{
    public interface IReserveRepository : IRepository<Guid, Reserve>
    {
        Task<IEnumerable<ReserveDto>> ReadAllReservesAsync(Guid CarId);
    }
}
