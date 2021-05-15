using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Card_File.BLL.DTO;

namespace Card_File.BLL.Interfaces
{
    public interface ITagService
    {
        Task CreateTag(TagDto tag);
        Task UpdateTag(TagDto tag);
        Task DeleteTagBuId(int id);
        Task<IEnumerable<TagDto>> GetTags();
        Task<IEnumerable<TagDto>> GetTagsWithDetails();
        Task<TagDto> GetTagByIdWithDateils(int id);
        Task<IEnumerable<TagDto>> FindTags(string term);
    }
}
