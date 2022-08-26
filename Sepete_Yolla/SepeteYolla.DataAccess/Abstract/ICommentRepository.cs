using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess.Abstract
{
    public interface ICommentRepository
    {
        List<Comment> GetComments();

        List<Comment> GetCommentsByProductId(int id);

        List<Comment> GetCommentsByCustomerId(int id);

        List<Comment> GetCommentsByCompanyId(int id);

        Comment CreateComment(Comment comment);

        Comment UpdateComment(Comment comment);

        void DeleteComment(int id);
    }
}
