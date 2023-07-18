using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatFormRepo
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();
        Platform? GetPlatformById(int id);
        void CreatePlatform(Platform platform);
    }
}