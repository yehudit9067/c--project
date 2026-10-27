namespace DalApi;

/// <summary>
/// חריגה הנזרקת כאשר מבקשים לגשת לישות שאינה קיימת ב-DAL.
/// </summary>
public class DalDoesNotExistException : Exception
{
    /// <summary>יוצר חריגה עם הודעת שגיאה.</summary>
    public DalDoesNotExistException(string message) : base(message) { }
}

/// <summary>
/// חריגה הנזרקת כאשר מבקשים ליצור ישות שכבר קיימת ב-DAL.
/// </summary>
public class DalAlreadyExistsException : Exception
{
    /// <summary>יוצר חריגה עם הודעת שגיאה.</summary>
    public DalAlreadyExistsException(string message) : base(message) { }
}
