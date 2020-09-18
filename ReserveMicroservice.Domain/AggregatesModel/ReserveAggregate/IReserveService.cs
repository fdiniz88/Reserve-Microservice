using ReserveMicroservice.Common.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate
{
    public interface IReserveService
    {       
        Task<IEnumerable<ReserveDto>> GetCarReserves(Guid CarId);
        Task<IEnumerable<Reserve>> GetReserves();
        Task<Reserve> GetReserve(Guid id);
        Task<ReturnResultDto> PutReserve(Guid id, Reserve reserve);
        Task<ReturnResultDto> PostReserve(Reserve reserve);
        Task<ReturnResultDto> DeleteReserve(Guid id);        
    }
}
