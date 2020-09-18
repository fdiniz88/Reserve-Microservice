using System;
using System.Collections.Generic;

namespace ReserveMicroservice.Common.Domain.DTO
{
    public class ReserveDto
    {
        public Guid ReserveId { get; set; }
        public Guid CarId { get; set; }
        public string ActionType { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DevolutionDate { get; set; }
        public Decimal Value { get; set; }
        public string Currency { get; set; }
    }
}