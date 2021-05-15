using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Card_File.BLL.DTO;

namespace Card_File.BLL.Interfaces
{
    public interface ICommentService
    {
        Task CreateCommentAsync(CommentDto comment);
        Task UpdateCommentAsync(CommentDto comment);
        //TODO Add pagination system
        Task<IEnumerable<CommentDto>> GetCommentsByMaterialIdAsync(int materialId, int count = 0, bool showHiden = false);
        //TODO Add pagination system
        Task<IEnumerable<CommentDto>> GetCommentsByUserIdAsync(string userId, bool showHiden = false);
        Task<CommentDto> GetCommentByIdAsync(int id);
        Task DeleteCommentByIdAsync(int id);
        Task UnhideCommentByIdAsync(int id);
        Task HideCommentByIdAsync(int id);
    }
}
