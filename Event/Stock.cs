namespace Csharp
{
    public class Stock // publisher (for event)
    {
        private string name;
        private decimal price;

        // event
        public event StockPriceChangeHandler OnStockPriceChange;
        public string Name => this.name;
        public decimal Price { get => this.price; set => this.price = value; }

        public Stock(string name)
        {
            this.name = name;
        }

        public void ChangeStockPriceBy(decimal percent)
        {
            var OldPrice = this.price;
            this.price += Math.Round(this.price * percent, 2);

            if (OnStockPriceChange != null)//Make sure there is a subscriber
            {
                OnStockPriceChange(this, OldPrice);
            }
        }
    }





}