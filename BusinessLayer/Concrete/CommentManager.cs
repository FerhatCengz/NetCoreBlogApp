using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDAL _commentDAL;
        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public void CommentAdd(Comment comment)
        {
            _commentDAL.Insert(comment);
        }

        public List<Comment> CommentGetList(int id)
        {
            return _commentDAL.GetAllList(x => x.BlogID == id);
        }
    }
}
