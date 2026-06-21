using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface IDepartmentRepository
    {
        public Task<List<Department>> GetAllAsync();
        public Task<Department?> GetByIdAsync(int id);

        public Task<Department> SaveAsync(Department department);

        public Task<Department?> UpdateAsync(int id, Department department);
        public Task<Department?> DeleteById(int id);
    }
}