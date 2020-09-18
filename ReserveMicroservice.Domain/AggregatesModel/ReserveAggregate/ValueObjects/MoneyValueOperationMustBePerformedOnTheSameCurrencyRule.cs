


using ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate.Extensions;

namespace ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate
{
    public class MoneyValueOperationMustBePerformedOnTheSameCurrencyRule : IBusinessRule
    {
        private readonly MoneyValue _left;

        private readonly MoneyValue _right;

        public MoneyValueOperationMustBePerformedOnTheSameCurrencyRule(MoneyValue left, MoneyValue right)
        {
            _left = left;
            _right = right;
        }

        public bool IsBroken() => _left.Currency != _right.Currency;

        public string Message => "As moedas do valor monetário devem ser as mesmas";
    }
}