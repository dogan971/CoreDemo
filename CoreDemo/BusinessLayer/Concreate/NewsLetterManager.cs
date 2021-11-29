using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;

namespace BusinessLayer.Concreate
{
    public class NewsLetterManager : INewsLetterService
    {

        INewsLetter _newsLetter;
        public NewsLetterManager(INewsLetter newsLetter)
        {
            _newsLetter = newsLetter;
        }
        public void addNewsLetter(NewsLatter newsLatter)
        {
            _newsLetter.Insert(newsLatter);
        }
    }
}
