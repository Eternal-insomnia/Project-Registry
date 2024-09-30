using Backend.DTOs;

namespace Backend.Repository.Interfaces
{
    public interface IProjectGeneralInfoRepository
    {
        Task<List<ProjectGeneralInfoDTO>> GetAll();
    }
}
