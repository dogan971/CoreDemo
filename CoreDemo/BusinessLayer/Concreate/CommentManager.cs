using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concreate
{


    public class CommentManager : ICommentService
    {
        ICommentDal _CommentDal;

        public CommentManager(ICommentDal commentdal)
        {
            _CommentDal = commentdal;
        }

        public void Add(Comment p)
        {
            _CommentDal.Insert(p);
        }


        public void Delete(Comment p)
        {
            throw new NotImplementedException();
        }

        public Comment getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> List(int id)
        {
            return _CommentDal.ListID(x => x.blogID == id);
        }

        public List<Comment> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Comment p)
        {
            throw new NotImplementedException();
        }
    }
}
