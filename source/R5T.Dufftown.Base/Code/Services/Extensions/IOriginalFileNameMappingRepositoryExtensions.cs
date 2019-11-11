using System;

using R5T.Sparta;


namespace R5T.Dufftown
{
    public static class IOriginalFileNameMappingRepositoryExtensions
    {
        public static void Add(this IOriginalFileNameMappingRepository repository, FileName uniqueFileName, FileName originalFileName)
        {
            var mapping = OriginalFileNameMapping.New(uniqueFileName, originalFileName);

            repository.Add(mapping);
        }

        public static FileName GetOriginalImageFileName(this IOriginalFileNameMappingRepository repository, FileName uniqueFileName)
        {
            var mapping = repository.Get(uniqueFileName);

            var originalFileName = mapping.OriginalFileName;
            return originalFileName;
        }
    }
}
