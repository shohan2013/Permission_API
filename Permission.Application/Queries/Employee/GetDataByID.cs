using MediatR;
using Permission.Core.Entities.EmployeeEntity;
using Permission.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Application.Queries.Employee
{
    public record GetDataByID(int ID) : IRequest<TBLEmployeeEntity>;
    public class GetDataByIDQueryHandler(IEmplolyeeRepository repository) : IRequestHandler<GetDataByID, TBLEmployeeEntity>
    {
        public async Task<TBLEmployeeEntity> Handle(GetDataByID request, CancellationToken cancellation)
        {
            return await repository.GetDataByID(request.ID);
        }
    }
}
