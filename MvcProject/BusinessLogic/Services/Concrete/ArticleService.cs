using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using BusinessLogic.DTO;
using BusinessLogic.Services.Abstract;
using Domain.Entities;
using Domain.Repositories.Abstract;

namespace BusinessLogic.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private IArticleRepository repository;
        public ArticleService(IArticleRepository articleRepository)
        {
            repository = articleRepository;
        }

        public IEnumerable<ArticlePreviewDTO> GetArticlePreviews()
        {
            Mapper.CreateMap<Article, ArticlePreviewDTO>();
            return Mapper.Map<IEnumerable<Article>, List<ArticlePreviewDTO>>(repository.GetAll());
        }

        public IEnumerable<ArticleDetailDTO> GetArticleDetails()
        {
            Mapper.CreateMap<Article, ArticleDetailDTO>();
            return Mapper.Map<IEnumerable<Article>, List<ArticleDetailDTO>>(repository.GetAll());
        }
    }
}
