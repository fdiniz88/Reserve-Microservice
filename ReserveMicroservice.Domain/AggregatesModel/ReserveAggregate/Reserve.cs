using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using ReserveMicroservice.Common.Domain.Entities;

namespace ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate
{
    public class Reserve : EntityBase<Guid>
    {
        public Guid CarId { get; set; }
        public CarType ActionType { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DevolutionDate { get; set; }
        public MoneyValue MoneyValue { get; set; }

        //[ForeignKey("ValueId")]
        //public Guid ValueId { get; set; }

        //public ICollection<Reserve> reserves { get; set; }

        //public Reserve()
        //{
        //    reserves = new List<Reserve>();
        //}

        //public void AddReserve(Reserve reserve)
        //{
        //    reserves.Add(reserve);
        //}
    }
}
