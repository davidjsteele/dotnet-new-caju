﻿namespace Clean_ReadOnlyProject.Application.Repositories
{
    using Clean_ReadOnlyProject.Domain.Customers;
    using System.Threading.Tasks;

    public interface ICustomerWriteOnlyRepository
    {
        Task Add(Customer customer);
        Task Update(Customer customer);
    }
}
