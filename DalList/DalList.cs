using DalApi;

namespace DalList;


/// מימוש חוזה השירות של שכבת הנתונים — חשיפה של פעולות ה-CRUD לכל ישות.

public class DalList : IDal
{
    
    public IStudent Student => new StudentImplementation();

   
    public IQuestion Question => new QuestionImplementation();

    
    public IAnswer Answer => new AnswerImplementation();

   
    public IStudentQuestion StudentQuestion => new StudentQuestionImplementation();

  
    public ITest Test => new TestImplementation();
}
