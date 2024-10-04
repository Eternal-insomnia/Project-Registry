using Backend.DTOs;

namespace Backend.Repository.Interfaces
{
    public interface IGeneralInfoRepository
    {
        Task<List<ProjectGeneralInfoDTO>> GetAll();
    }
}
