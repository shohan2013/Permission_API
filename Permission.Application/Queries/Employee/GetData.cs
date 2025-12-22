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
    public record GetData() : IRequest<IEnumerable<TBLEmployeeEntity>>;
    public class GetDataQueryHandler(IEmplolyeeRepository repository) : IRequestHandler<GetData, IEnumerable<TBLEmployeeEntity>>
    {
        public async Task<IEnumerable<TBLEmployeeEntity>> Handle(GetData request, CancellationToken cancellation)
        {
            return await repository.GetData();
        }
    }
}
