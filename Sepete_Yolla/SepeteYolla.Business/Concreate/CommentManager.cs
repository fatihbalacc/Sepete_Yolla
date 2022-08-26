using SepeteYolla.Business.Abstract;
using SepeteYolla.DataAccess.Abstract;
using SepeteYolla.DataAccess.Concreate;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.Business.Concreate
{
    public class CommentManager : ICommentService
    {
        private ICommentRepository _commentRepository;
        public CommentManager()
        {
            _commentRepository = new CommentRepository();
        }

        public Comment CreateComment(Comment comment)
        {
            return _commentRepository.CreateComment(comment);
        }

        public void DeleteComment(int id)
        {
            _commentRepository.DeleteComment(id);
        }

        public List<Comment> GetComments()
        {
            return _commentRepository.GetComments();
        }

        public List<Comment> GetCommentsByCompanyId(int id)
        {
            return _commentRepository.GetCommentsByCompanyId(id);
        }

        public List<Comment> GetCommentsByCustomerId(int id)
        {
            return _commentRepository.GetCommentsByCustomerId(id);
        }

        public List<Comment> GetCommentsByProductId(int id)
        {
            return _commentRepository.GetCommentsByProductId(id);
        }

        public Comment UpdateComment(Comment comment)
        {
            return _commentRepository.UpdateComment(comment);
        }
    }
}
