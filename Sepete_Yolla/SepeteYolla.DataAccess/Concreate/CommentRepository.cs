using SepeteYolla.DataAccess.Abstract;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess.Concreate
{
    public class CommentRepository : ICommentRepository
    {
        public Comment CreateComment(Comment comment)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                sepeteYollaDbContext.Comments.Add(comment);
                sepeteYollaDbContext.SaveChanges();
                return comment;
            }
        }

        public void DeleteComment(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var deleted_Comment = sepeteYollaDbContext.Comments.Find(id);

                sepeteYollaDbContext.Comments.Remove(deleted_Comment);
                sepeteYollaDbContext.SaveChanges();
            }
        }

        public List<Comment> GetComments()
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Comments.ToList();
            }
        }

        public List<Comment> GetCommentsByCompanyId(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Comments.ToList().FindAll(x => x.Company_Id == id);
            }
        }

        public List<Comment> GetCommentsByCustomerId(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Comments.ToList().FindAll(x => x.Customer_Id == id);
            }
        }

        public List<Comment> GetCommentsByProductId(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Comments.ToList().FindAll(x => x.Product_Id == id);
            }
        }

        public Comment UpdateComment(Comment comment)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var updated_comment = sepeteYollaDbContext.Comments.FirstOrDefault(x => x.Id == comment.Id);
                updated_comment = comment;
                sepeteYollaDbContext.Comments.Update(updated_comment);
                sepeteYollaDbContext.SaveChanges();
                return updated_comment;
            }   // BURAYI KONTROL ET 
        }
    }
}
