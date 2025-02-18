﻿using BuyMe.Application.Common.Behaviour;
using BuyMe.Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BuyMe.Application.Employee.Commonds.CreateEdit
{
    public class CreatEditEmployeeCommondHandler : IRequestHandler<CreatEditEmployeeCommond, int>
    {
        private readonly IBuyMeDbContext _context;
        private readonly IApplicationUserServcie _applicationUserServcie;

        public CreatEditEmployeeCommondHandler(IBuyMeDbContext context, IApplicationUserServcie applicationUserServcie)
        {
            _context = context;
            this._applicationUserServcie = applicationUserServcie;
        }

        public async Task<int> Handle(CreatEditEmployeeCommond request, CancellationToken cancellationToken)
        {
            Domain.Entities.Employee employee;
            if (request.Id.HasValue)
            {
                var entity = await _context.Employees.FindAsync(request.Id);
                Guard.Against.Null(entity, request.Id);
                await _applicationUserServcie.EditApplicationUser(request.UserId, request.FirstName, request.LastName, request.Password
                    , request.Email, request.CompanyId.Value, request.Photo);
                employee = entity;
            }
            else
            {
                employee = new Domain.Entities.Employee();
                employee.UserId = await _applicationUserServcie.AddApplicationUser(request.FirstName, request.LastName, request.Password
                    , request.Email, request.CompanyId.Value, request.Photo);
                await _context.Employees.AddAsync(employee);
            }
            employee.LastName = request.LastName;
            employee.FirstName = request.FirstName;
            employee.Title = request.Title;
            employee.BirthDate = request.BirthDate;
            employee.HireDate = request.HireDate;
            employee.Address = request.Address;
            employee.City = request.City;
            employee.Region = request.Region;
            employee.Country = request.Country;
            employee.HomePhone = request.HomePhone;
            employee.Photo = request.Photo;
            employee.Notes = request.Notes;
            employee.Email = request.Email;
            employee.Password = request.Password;
            employee.CompanyId = request.CompanyId.Value;
            await _context.SaveChangesAsync(cancellationToken);
            return employee.Id;
        }
    }
}