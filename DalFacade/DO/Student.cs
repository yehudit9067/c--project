namespace DO;


///(ישות תלמיד (נבחן.

public record Student
{
    ///( תעודת הזהות של התלמיד (משמשת גם כמזהה הייחודי.
    public int Id { get; init; }

    ///שם התלמיד.
    public string Name { get; init; } = "";

    ///מזהה המבחן שאליו התלמיד ניגש.
    public int TestId { get; init; }

    /// ציון התלמיד.
    public int Score { get; init; }

    /// בנאי ריק — נדרש לצורכי שכבת הנתונים.
    public Student() { }
}
