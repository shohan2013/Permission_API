using MediatR;
using Permission.Core.Entities.EmployeeEntity;
using Permission.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Application.Commands.Employee
{
    public record AddCommand(TBLEmployeeEntity Entity) : IRequest<TBLEmployeeEntity>;


    public class AddCommanddHandler(IEmplolyeeRepository repository) : IRequestHandler<AddCommand, TBLEmployeeEntity>
    {
        public async Task<TBLEmployeeEntity> Handle(AddCommand request, CancellationToken cancellationToken)
        {
            return await repository.AddData(request.Entity);
        }
    }
}
