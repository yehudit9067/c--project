namespace DalApi;

/// <summary>
/// חוזה השירות של שכבת הנתונים — מאפשר גישה לכל אחת מהישויות.
/// </summary>
public interface IDal
{
    /// <summary>גישה לפעולות על ישות התלמיד.</summary>
    IStudent Student { get; }

    /// <summary>גישה לפעולות על ישות התשובה.</summary>
    IAnswer Answer { get; }

    /// <summary>גישה לפעולות על ישות השאלה.</summary>
    IQuestion Question { get; }

    /// <summary>גישה לפעולות על ישות השאלה לנבחן.</summary>
    IStudentQuestion StudentQuestion { get; }

    /// <summary>גישה לפעולות על ישות המבחן.</summary>
    ITest Test { get; }
}
