using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using ReserveMicroservice.Common.Domain.DTO;

namespace ReserveMicroservice.Application.Api.Controllers
{
   // [Authorize(Roles = "ReserveHolder")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservesController : ControllerBase
    {
        private readonly IReserveService _ReserveService;

        public ReservesController(IReserveService ReserveService)
        {
            _ReserveService = ReserveService;
        }

        /// <summary>
        /// List a reserves
        /// </summary>        
        /// <param name="CarId">Car identification number</param>        
        /// <returns>Object containing reserves information
        /// </returns>
        [HttpGet("{CarId}")]
        public async Task<IEnumerable<ReserveDto>> GetCarReserves(Guid CarId)
        {
            return await _ReserveService.GetCarReserves(CarId);
        }

        /// <summary>
        /// Lists all reserves in
        /// the base
        /// </summary>        
        /// <param name="Id">reserve identification number</param>  
        /// <returns>Object containing car information
        /// </returns>
        //[HttpGet("{Id}")]
        //public async Task<Reserve> GetReserve(Guid Id)
        //{
        //    return await _ReserveService.GetReserve(Id);
        //}

        /// <summary>
        /// Lists all reserves in
        /// the base
        /// </summary>              
        /// <returns>Object containing car information
        /// </returns>
        [HttpGet]
        public async Task<IEnumerable<Reserve>> GetReserves()
        {
            return await _ReserveService.GetReserves();
        }

        /// <summary>
        /// Create Reserve
        /// </summary>
        /// <param name="Reserve">Object to create Reserve</param>
        /// <returns>Object containing car information
        /// </returns>
        [HttpPost]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Reserve>> PostReserve([FromBody] Reserve reserve)
        {
            try
            {
                // var resultado = _CarService.PostCar(car);
                var result = await _ReserveService.PostReserve(reserve);

                return Created("", result);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
