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
    public record DeleteCommand(int id) : IRequest<bool>;
    public class DeleteCommandHandler(IEmplolyeeRepository Repository) : IRequestHandler<DeleteCommand,bool>
    {
        public async Task<bool> Handle(DeleteCommand request, CancellationToken cancellation)
        {
            return await Repository.Delete(request.id);
        }
    }
}
