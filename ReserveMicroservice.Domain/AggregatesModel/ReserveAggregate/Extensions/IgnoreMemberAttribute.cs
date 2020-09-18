using System;

namespace ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate.Extensions
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class IgnoreMemberAttribute : Attribute
    {
    }
}