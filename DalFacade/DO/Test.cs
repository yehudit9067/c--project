namespace DO;


/// ישות מבחן (בחינה).

public record Test
{
    /// מספר מזהה ייחודי של המבחן.
    public int Id { get; init; }

    /// נושא המבחן.
    public Topic Topic { get; init; }

    /// תאריך הבחינה.
    public DateTime Date { get; init; }

    /// מספר השאלות במבחן.
    public int NumOfQuestions { get; init; }

    /// בנאי ריק — נדרש לצורכי שכבת הנתונים.
    public Test() { }
}
