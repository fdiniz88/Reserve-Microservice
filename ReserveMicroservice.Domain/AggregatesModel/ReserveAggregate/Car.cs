
using System;


namespace ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate
{
    public class Car
    {
        public Guid Id { get; set; }      
        
        public string Description { get; set; }
    }
}
