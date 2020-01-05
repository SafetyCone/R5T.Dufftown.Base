using System;
using System.Threading.Tasks;

using R5T.Sparta;


namespace R5T.Dufftown
{
    /// <summary>
    /// Read-only items.
    /// </summary>
    public interface IOriginalFileNameMappingRepository
    {
        Task Add(OriginalFileNameMapping mapping);

        Task<bool> Exists(FileName uniqueFileName);

        Task<OriginalFileNameMapping> Get(FileName uniqueFileName);

        Task Delete(FileName uniqueFileName);
    }
}
