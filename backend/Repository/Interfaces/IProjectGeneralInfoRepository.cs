using ConsentCode.DTOs;

namespace ConsentCode.Repository.Interfaces
{
    public interface IProjectGeneralInfoRepository
    {
        Task<List<ProjectGeneralInfoDTO>> GetAll();
    }
}
