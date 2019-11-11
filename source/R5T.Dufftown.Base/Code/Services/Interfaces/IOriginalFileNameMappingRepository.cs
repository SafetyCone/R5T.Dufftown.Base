using System;

using R5T.Sparta;


namespace R5T.Dufftown
{
    /// <summary>
    /// Read-only items.
    /// </summary>
    public interface IOriginalFileNameMappingRepository
    {
        void Add(OriginalFileNameMapping mapping);

        bool Exists(FileName uniqueFileName);

        OriginalFileNameMapping Get(FileName uniqueFileName);

        void Delete(FileName uniqueFileName);
    }
}
