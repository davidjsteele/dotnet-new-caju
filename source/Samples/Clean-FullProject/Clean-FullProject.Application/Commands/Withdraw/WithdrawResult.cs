﻿namespace Clean_FullProject.Application.Commands.Withdraw
{
    using Clean_FullProject.Application.Results;
    public class WithdrawResult
    {
        public TransactionResult Transaction { get; private set; }
        public double UpdatedBalance { get; private set; }

        public WithdrawResult()
        {

        }

        public WithdrawResult(TransactionResult transaction, double updatedBalance)
        {
            this.Transaction = transaction;
            this.UpdatedBalance = updatedBalance;
        }
    }
}
