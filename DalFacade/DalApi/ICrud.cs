namespace DalApi;

/// <summary>
/// ממשק גנרי אחיד לפעולות CRUD על ישות מנתונים.
/// </summary>
/// <typeparam name="T">סוג הישות (DO).</typeparam>
public interface ICrud<T>
{
    /// <summary>יוצר אובייקט ישות חדש ב-DAL ומחזיר את המזהה שהוקצה לו.</summary>
    int Create(T item);

    /// <summary>מחזיר את אובייקט הישות לפי מזהה, או null אם לא נמצא.</summary>
    T? Read(int id);

    /// <summary>מחזיר את כל אובייקטי הישות.</summary>
    List<T> ReadAll();

    /// <summary>מעדכן אובייקט ישות קיים.</summary>
    void Update(T item);

    /// <summary>מוחק אובייקט ישות לפי מזהה.</summary>
    void Delete(int id);
}
