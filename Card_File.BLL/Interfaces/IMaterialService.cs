using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Card_File.BLL.DTO;
using Card_File.BLL.Infrastructure;

namespace Card_File.BLL.Interfaces
{
    public interface IMaterialService
    {
        Task CreateMaterialAsync(TextMaterialDto textMaterial);
        Task UpdateMaterialAsync(TextMaterialDto textMaterial);
        Task DeleteMaterialByIdAsync(int id);
        Task HideMaterialByIdAsync(int id);
        Task UnhideMaterialByIdAsync(int id);
        Task<IEnumerable<TextMaterialDto>> GetMaterialsAsync(int skip = 0, int count = 0, bool showHidden = false);
        Task<IEnumerable<TextMaterialDto>> GetMaterialsSortedWithDetailsAsync(
            SortingParam sorting = SortingParam.AddedDate,
            bool reverseOrder = false,
            int skip = 0,
            int count = 0,
            bool showHidden = false);
        Task<IEnumerable<TextMaterialDto>> GetMaterialsByUserIdWithDetailsAsync(int userId, int skip = 0,
            int count = 0, bool showHidden = false);
        Task<TextMaterialDto> GetMaterialByIdWithDetailAsync(int id);
        Task CreateMaterialPartAsync(MaterialPartDto materialPart);
        Task UpdateMaterialPartAsync(MaterialPartDto materialPart);
        Task DeleteMaterialPartByIdAsync(int id);
        Task<MaterialPartDto> GetMaterialPartByIdAsync(int id);
    }
}
