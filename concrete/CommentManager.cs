﻿using System;
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
            _CommentDal.Delete(t);
        }

        public Comment TGetById(int id)
        {
            return _CommentDal.GetByID(id);
        }

        public List<Comment> TGetList()
        {
            return _CommentDal.GetList();
        }

        public void TInsert(Comment t)
        {
            _CommentDal.Insert(t);
        }

        public void TUpdate(Comment t)
        {
            _CommentDal.Update(t);
        }
    }
}
