using Soru_Cevap_Portali.Models;
using Soru_Cevap_Portali.ViewModels;

namespace Soru_Cevap_Portali.Repository.Abstract
{
    public interface IQuestionRepository
    {
        IQueryable<Question> Questions { get; }
        void CreateQuestion(Question question);
        Task EditQuestion(QuestionModel question);
    }
}
