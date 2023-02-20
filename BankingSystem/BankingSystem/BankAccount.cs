using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(int id, decimal balance = 0)
        {
            this.Id = id;
            this.Balance = balance;
        }

        public int Id {
            get { return Id; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Id must be possitive");
                }
                this.balance = value;
            }
        }
        public decimal Balance 
        {
            get{ return balance; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Balance must be possitive or zero");
                }
                this.balance = value;
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("Negative amount");
            }
            this.Balance += amount;
        }
        public void Credit(decimal cash)
        {
            if (cash <= 0)
            {
                throw new InvalidOperationException("“The amount must beposistive!");
            }
            this.Balance += cash;
        }
        public void Increase(double percent)
        {
            if (percent <= 0)
            {
                throw new InvalidOperationException("The percent must be positive!");
            }
            this.Balance =this.Balance*(decimal)percent;
        }
        public void Bonus()
        {
            if (this.balance<2000 && this.balance>1000)
            {
                this.Balance += 100;
            }
            else if(this.Balance>=2000 && this.Balance<=3000)
            {
                this.Balance  += 200;
            }
            else
            {
                this.Balance += 300;
            }
        }
    }
}
