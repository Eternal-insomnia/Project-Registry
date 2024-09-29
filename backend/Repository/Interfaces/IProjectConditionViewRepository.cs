using ConsentCode.DTOs;

namespace ConsentCode.Repository.Interfaces
{
    public interface IProjectConditionViewRepository
    {
        Task<List<ProjectConditionViewDTO>> GetAll();
    }
}
