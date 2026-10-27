namespace DO;


/// ישות הקושרת בין תלמיד, מבחן, שאלה והתשובה שנבחרה בה.

public record StudentQuestion
{
    ///מזהה התלמיד.
    public int StudentId { get; init; }

    /// מזהה המבחן.
    public int TestId { get; init; }

    /// מזהה השאלה.
    public int QuestionId { get; init; }

    /// מזהה התשובה שנבחרה על ידי התלמיד.
    public int AnswerId { get; init; }

    /// בנאי ריק — נדרש לצורכי שכבת הנתונים.
    public StudentQuestion() { }
}
