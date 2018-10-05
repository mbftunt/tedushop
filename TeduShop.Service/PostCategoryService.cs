using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategory postCategory);

        void Update(PostCategory postCategory);

        void Delete(int id);

        void Delete(PostCategory postCategory);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllByParentID(int parentID);

        PostCategory GetById(int id);
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRespository _postCategoryRespository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRespository postCategoryRespository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRespository = postCategoryRespository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(PostCategory postCategory)
        {
            throw new NotImplementedException();
        }

        public void Delete(PostCategory postCategory)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _postCategoryRespository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRespository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentID(int parentID)
        {
            return _postCategoryRespository.GetMulti(x => x.Status && x.ParentID == parentID);
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryRespository.GetSingleById(id);
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryRespository.Update(postCategory);
        }
    }
}