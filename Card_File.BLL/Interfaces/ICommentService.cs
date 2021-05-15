using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Card_File.BLL.DTO;

namespace Card_File.BLL.Interfaces
{
    public interface ICommentService
    {
        Task CreateComment(CommentDto comment);
        Task UpdateComment(CommentDto comment);
        //TODO Add pagination system
        Task<IEnumerable<CommentDto>> GetCommentsByMaterialId(int materialId, int count = 0, bool showHiden = false);
        //TODO Add pagination system
        Task<IEnumerable<CommentDto>> GetCommentsByUserId(string userId, bool showHiden = false);
        Task<CommentDto> GetCommentById(int id);
        Task DeleteCommentById(int id);
        Task UnhideCommentById(int id);
        Task HideCommentById(int id);
    }
}
