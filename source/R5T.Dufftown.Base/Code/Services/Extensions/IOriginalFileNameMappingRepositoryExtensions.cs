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
    }
}
