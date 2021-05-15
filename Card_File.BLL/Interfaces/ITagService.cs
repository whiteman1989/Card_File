using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Card_File.BLL.DTO;

namespace Card_File.BLL.Interfaces
{
    public interface ITagService
    {
        Task CreateTagAsync(TagDto tag);
        Task UpdateTagAsync(TagDto tag);
        Task DeleteTagBuIdAsync(int id);
        Task<IEnumerable<TagDto>> GetTagsAsync();
        Task<IEnumerable<TagDto>> GetTagsWithDetailsAsync();
        Task<TagDto> GetTagByIdWithDateilsAsync(int id);
        Task<IEnumerable<TagDto>> FindTagsAsync(string term);
    }
}
