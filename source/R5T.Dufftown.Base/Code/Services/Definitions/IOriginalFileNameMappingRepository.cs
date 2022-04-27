using System;
using System.Threading.Tasks;

using R5T.Sparta;

using R5T.T0064;


namespace R5T.Dufftown
{
    /// <summary>
    /// Read-only items.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IOriginalFileNameMappingRepository : IServiceImplementation
    {
        Task Add(OriginalFileNameMapping mapping);

        Task<bool> Exists(FileName uniqueFileName);

        Task<OriginalFileNameMapping> Get(FileName uniqueFileName);

        Task Delete(FileName uniqueFileName);
    }
}
