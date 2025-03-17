using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _CommentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _CommentDal = commentDal;
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Comment t)
        {
            if (t.CommentContent != null && t.MemberID <= 1 && t.CommentStatus == false)
            {
                _CommentDal.Insert(t);
            }
            else
            {
                //hata mesajları
                //content alanı boş geçilemez
                //member id değeri yanlış
                //status bilgisi true olamaz
            }
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
