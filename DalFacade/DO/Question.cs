namespace DO;

/// <summary>
/// ישות שאלה במאגר השאלות.
/// </summary>
public record Question
{
    /// <summary>מספר מזהה ייחודי של השאלה.</summary>
    public int Id { get; init; }

    /// <summary>נושא השאלה.</summary>
    public Topic Topic { get; init; }

    /// <summary>תוכן השאלה.</summary>
    public string Content { get; init; } = "";

    /// <summary>מזהה התשובה הנכונה.</summary>
    public int CorrectAnswerId { get; init; }

    /// <summary>בנאי ריק — נדרש לצורכי שכבת הנתונים.</summary>
    public Question() { }
}
