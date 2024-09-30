using Backend.DTOs;

namespace Backend.Repository.Interfaces
{
    public interface IProjectConditionViewRepository
    {
        Task<List<ProjectConditionViewDTO>> GetAll();
    }
}
