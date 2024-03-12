namespace Csharp
{
    class Money
    {
        private decimal amount;

        public decimal Amount => amount;

        public Money(decimal amount)
        {
            this.amount = amount;
        }

        // applay Operator Overloading in +

        public static Money operator +(Money a, Money b)
        {
            var value = a.Amount + b.Amount;
            return new Money(value);
        }


        // applay Operator Overloading in -

        public static Money operator -(Money a, Money b)
        {
            var value = a.Amount - b.Amount;
            return new Money(value);
        }

        // applay Operator Overloading in *

        public static Money operator *(Money a, Money b)
        {
            var value = a.Amount * b.Amount;
            return new Money(value);
        }
        // applay Operator Overloading in /

        public static Money operator /(Money a, Money b)
        {
            var value = a.Amount / b.Amount;
            return new Money(Math.Round(value,2));
        }


    }




}