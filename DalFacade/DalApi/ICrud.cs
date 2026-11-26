namespace DalApi;


/// ממשק גנרי אחיד לפעולות CRUD על ישות מנתונים.
/// <typeparam name="T">סוג הישות (DO).</typeparam>
public interface ICrud<T>
{
    /// יוצר אובייקט ישות חדש ב-DAL ומחזיר את המזהה שהוקצה לו.
    int Create(T item);

    /// מחזיר את אובייקט הישות לפי מזהה, או null אם לא נמצא.
    T? Read(int id);

    /// מחזיר את כל אובייקטי הישות.
    List<T> ReadAll();

    /// מעדכן אובייקט ישות קיים.
    void Update(T item);

    /// מוחק אובייקט ישות לפי מזהה.
    void Delete(int id);
}
