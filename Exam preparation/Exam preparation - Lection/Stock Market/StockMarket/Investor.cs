using System.Collections.Generic;
using System.Linq;
using System;

namespace StockMarket
{
    public class Investor
    {
        private List<Stock> portfolio;
        private string fullName;
        private string emailAddress;
        private decimal moneyToInvest;
        private string brokerName;

        public Investor(string fullName, string emailAdress, decimal moneyToInvest, string brokerName)
        { 
            this.FullName = fullName;
            this.EmailAddress = emailAdress;
            this.MoneyToInvest = moneyToInvest;
            this.brokerName = brokerName;
            this.Portfolio = new List<Stock>();
        }
        public List<Stock> Portfolio { get => portfolio; set => portfolio = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public decimal MoneyToInvest { get => moneyToInvest; set => moneyToInvest = value; }
        public string BrokerName { get => brokerName; set => brokerName = value; }

        public int Count => this.portfolio.Count;
        public void BuyStock(Stock stock)
        {
            if(stock.MarketCapitalization >= 10000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                this.Portfolio.Add(stock);
                MoneyToInvest -= stock.PricePerShare;
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            Stock currentStock = portfolio.Find(x => x.CompanyName == companyName);
            if(currentStock == null)
            {
                return $"{companyName} does not exist.";
            }
            else
            {
                if (sellPrice < currentStock.PricePerShare)
                {
                    return $"Cannot sell {companyName}.";
                }
                else
                {
                    this.MoneyToInvest += sellPrice;
                    Portfolio.Remove(currentStock);
                    return $"{companyName} was sold.";
                }
            }            
        }
        public Stock FindStock(string companyName)
        {
            Stock currentStock = portfolio.Find(x => x.CompanyName == companyName);
            if (currentStock != null)
            {
                return currentStock;
            }
            else return null;
        }

        public Stock FindBiggestCompany()
        {
            if (portfolio.Count == 0)
            {
                return null;
            }
            Stock biggestCompany = null;
            decimal biggestMarketCapitalization = 0;
            foreach (var stock in Portfolio)
            {
                if(stock.MarketCapitalization > biggestMarketCapitalization)
                {
                    biggestCompany = stock;
                    biggestMarketCapitalization = stock.MarketCapitalization;
                }
            }
            return biggestCompany;
           
            //return portfolio.OrderByDescending(x => x.MarketCapitalization).FirstOrDefault();
        }
        public string InvestorInformation()
        {
            return $"The investor {this.FullName} with a broker {this.brokerName} has stocks:" + Environment.NewLine +
                string.Join(Environment.NewLine, Portfolio);
        }
    }
}
