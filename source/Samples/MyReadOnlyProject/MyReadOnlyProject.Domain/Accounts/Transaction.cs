﻿namespace MyReadOnlyProject.Domain.Accounts
{
    using MyReadOnlyProject.Domain.ValueObjects;
    using System;

    public abstract class Transaction : Entity
    {
        public Amount Amount { get; private set; }
        public abstract string Description { get; }
        public DateTime TransactionDate { get; private set; }

        public Transaction()
        {

        }

        protected Transaction(Amount amount)
        {
            Amount = amount;
            TransactionDate = DateTime.Now;
        }
    }
}
