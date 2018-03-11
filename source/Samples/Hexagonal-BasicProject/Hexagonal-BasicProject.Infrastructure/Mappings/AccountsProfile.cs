﻿namespace Hexagonal_BasicProject.Infrastructure.Mappings
{
    using AutoMapper;
    using Hexagonal_BasicProject.Application.Results;
    using Hexagonal_BasicProject.Application.Commands.Close;
    using Hexagonal_BasicProject.Domain.Accounts;

    public class AccountsProfile : Profile
    {
        public AccountsProfile()
        {
            CreateMap<Account, AccountResult>()
                .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CurrentBalance, opt => opt.MapFrom(src => src.GetCurrentBalance().Value))
                .ForMember(dest => dest.Transactions, opt => opt.MapFrom(src => src.Transactions.Items));

            CreateMap<Debit, TransactionResult>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount.Value))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.TransactionDate, opt => opt.MapFrom(src => src.TransactionDate));

            CreateMap<Credit, TransactionResult>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount.Value))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.TransactionDate, opt => opt.MapFrom(src => src.TransactionDate));

            CreateMap<Account, CloseResult>()
                .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
