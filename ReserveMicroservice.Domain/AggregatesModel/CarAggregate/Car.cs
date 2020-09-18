using System;

namespace CarMicroservice.Domain.AggregatesModel.CarAggregate
{
    public class Car
    {
        public Guid Id { get; set; }
        public CarType ActionType { get; set; }
        public string Description { get; set; }        
    }
}
