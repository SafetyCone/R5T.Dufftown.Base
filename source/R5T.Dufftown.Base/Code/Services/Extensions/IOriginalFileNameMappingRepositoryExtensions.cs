using System;
using System.Threading.Tasks;

using R5T.Sparta;


namespace R5T.Dufftown
{
    public static class IOriginalFileNameMappingRepositoryExtensions
    {
        public static async Task Add(this IOriginalFileNameMappingRepository repository, FileName uniqueFileName, FileName originalFileName)
        {
            var mapping = OriginalFileNameMapping.New(uniqueFileName, originalFileName);

            await repository.Add(mapping);
        }

        public static async Task<FileName> GetOriginalImageFileName(this IOriginalFileNameMappingRepository repository, FileName uniqueFileName)
        {
            var mapping = await repository.Get(uniqueFileName);

            var originalFileName = mapping.OriginalFileName;
            return originalFileName;
        }
    }
}
