namespace Soru_Cevap_Portali.Models
{
    public class Question
    {

        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; } = null!;
        
        public string QuestionText { get; set; } = null!;
        public DateTime CreatedAt { get; set; } 
        public ICollection<Answer> Answers { get; set; } = new List<Answer>(); 
        
        public int CategoryId { get; set; }
       
       
        public string AppUserId { get; set; } = null!;
        public AppUser AppUser { get; set; } = null!; 

    }
}
