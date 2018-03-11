﻿namespace Hexagonal_ReadOnlyProject.Application.Commands.Withdraw
{
    using Hexagonal_ReadOnlyProject.Application.Results;
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
