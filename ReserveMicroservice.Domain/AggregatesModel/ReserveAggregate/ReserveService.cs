using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using ReserveMicroservice.Common.Domain.DTO;

namespace ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate
{
    /// <summary>
    /// Servicos de dominio
    /// </summary>
    public class ReserveService : IReserveService
    {
        private IReserveRepository _ReserveRepository;

        public ReserveService(IReserveRepository ReserveRepository)
        {
            _ReserveRepository = ReserveRepository;
        }

        //Servicos de Dominio
        public async Task<IEnumerable<ReserveDto>> GetCarReserves(Guid CarId)
        {
            return await _ReserveRepository.ReadAllReservesAsync(CarId);
        }

        public async Task<IEnumerable<Reserve>> GetReserves()
        {            
            return await _ReserveRepository.ReadAllAsync();
        }

        public async Task<Reserve> GetReserve(Guid id)
        {
            return await _ReserveRepository.ReadAsync(id);
        }

        public Task<ReturnResultDto> PutReserve(Guid id, Reserve reserve)
        {
            throw new NotImplementedException();
        }

        public async Task<ReturnResultDto> PostReserve(Reserve reserve)
        {      
            await _ReserveRepository.CreateAsync(reserve);
            await _ReserveRepository.SaveChangesAsync();
            ReturnResultDto ReturnResultDto = new ReturnResultDto();
            ReturnResultDto.Action = "Reserva criada com sucesso!!!";
            return ReturnResultDto;
        }

        public Task<ReturnResultDto> DeleteReserve(Guid id)
        {
            throw new NotImplementedException();
        }
      
    }
}
