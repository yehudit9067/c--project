namespace DalApi;


// חוזה השירות של שכבת הנתונים — מאפשר גישה לכל אחת מהישויות.

public interface IDal
{
   //גישה לפעולות על ישות התלמיד.
    IStudent Student { get; }

    // גישה לפעולות על ישות התשובה.
    IAnswer Answer { get; }

    // גישה לפעולות על ישות השאלה.
    IQuestion Question { get; }

    // גישה לפעולות על ישות השאלה לנבחן.
    IStudentQuestion StudentQuestion { get; }

    // גישה לפעולות על ישות המבחן.
    ITest Test { get; }
}

