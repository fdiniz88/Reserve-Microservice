namespace ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate.Extensions
{
    public interface IBusinessRule
    {
        bool IsBroken();

        string Message { get; }
    }
}