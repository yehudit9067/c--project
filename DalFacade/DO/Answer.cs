namespace DO;

/// <summary>
/// ישות תשובה לשאלה.
/// </summary>
public record Answer
{
    /// <summary>מספר מזהה ייחודי של התשובה.</summary>
    public int Id { get; init; }

    /// <summary>מזהה השאלה שהתשובה שייכת לה.</summary>
    public int QuestionId { get; init; }

    /// <summary>תוכן התשובה.</summary>
    public string Content { get; init; } = "";

    /// <summary>בנאי ריק — נדרש לצורכי שכבת הנתונים.</summary>
    public Answer() { }
}

