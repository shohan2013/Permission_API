using Microsoft.EntityFrameworkCore;
using Permission.Core.Entities.EmployeeEntity;
using Permission.Core.Interfaces;
using Permission.Infrastructure.Data;

namespace Permission.Infrastructure.Repositories
{
    public class EmployeeRepository(AppDbContext dbContext) : IEmplolyeeRepository
    {
        public async Task<IEnumerable<TBLEmployeeEntity>> GetData()
        {
            return await dbContext.TBLEmployeeEntity.ToListAsync();
        }

        public async Task<TBLEmployeeEntity> GetDataByID(int id)
        {
            return await dbContext.TBLEmployeeEntity.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<TBLEmployeeEntity> AddData(TBLEmployeeEntity entity)
        {
            dbContext.TBLEmployeeEntity.Add(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TBLEmployeeEntity> UpdateData(int id,TBLEmployeeEntity entity)
        {
            var employee = await dbContext.TBLEmployeeEntity.FirstOrDefaultAsync(x => x.ID== id);
            if(employee is not null)
            {
                employee.Name = entity.Name;
                employee.Email = entity.Email;
                employee.Phone = entity.Phone;
                await dbContext.SaveChangesAsync();
                return employee;
            }

            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var employee = await dbContext.TBLEmployeeEntity.FirstOrDefaultAsync(x => x.ID == id);
            if (employee is not null)
            {
                dbContext.TBLEmployeeEntity.Remove(employee);
                return await dbContext.SaveChangesAsync() > 0;
            }

            return false;
        }


    }
}
