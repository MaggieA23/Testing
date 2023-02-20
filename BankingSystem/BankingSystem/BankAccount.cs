﻿using System;
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
    }
}
