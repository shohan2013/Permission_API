using Permission.Core.Entities.EmployeeEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Core.Interfaces
{
    public interface IEmplolyeeRepository
    {
        Task<IEnumerable<TBLEmployeeEntity>> GetData();
        Task<TBLEmployeeEntity> GetDataByID(int id);
        Task<TBLEmployeeEntity> AddData(TBLEmployeeEntity entity);
        Task<TBLEmployeeEntity> UpdateData(int id, TBLEmployeeEntity entity);
        Task<bool> Delete(int id);
    }
}
