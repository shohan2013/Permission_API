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
    public record UpdateCommand(int id,TBLEmployeeEntity Entity) : IRequest<TBLEmployeeEntity>;
    public class UpdateCommandHandler(IEmplolyeeRepository repository) : IRequestHandler<UpdateCommand, TBLEmployeeEntity>
    {
        public async Task<TBLEmployeeEntity> Handle(UpdateCommand request, CancellationToken cancellation)
        {
            return await repository.UpdateData(request.id,request.Entity);
        }
    }
}
