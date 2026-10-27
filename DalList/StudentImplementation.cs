using DalApi;
using DO;

namespace DalList;

/// <summary>
/// מימוש פעולות CRUD על ישות התלמיד מול רשימת התלמידים ב-DataSource.
/// </summary>
internal class StudentImplementation : IStudent
{
    /// <inheritdoc/>
    public int Create(Student item)
    {
        if (DataSource.s_students.Any(s => s.Id == item.Id))
            throw new DalAlreadyExistsException($"Student with ID={item.Id} already exists");

        // תעודת הזהות משמשת כמזהה, ולכן מזהה 0 פירושו "טרם הוקצה".
        Student newItem = item.Id != 0
            ? item
            : item with { Id = Config.NextStudentId };

        DataSource.s_students.Add(newItem);
        return newItem.Id;
    }

    /// <inheritdoc/>
    public Student? Read(int id) => DataSource.s_students.FirstOrDefault(s => s.Id == id);

    /// <inheritdoc/>
    public List<Student> ReadAll() => new(DataSource.s_students);

    /// <inheritdoc/>
    public void Update(Student item)
    {
        if (!DataSource.s_students.Any(s => s.Id == item.Id))
            throw new DalDoesNotExistException($"Student with ID={item.Id} does not exist");

        DataSource.s_students.RemoveAll(s => s.Id == item.Id);
        DataSource.s_students.Add(item);
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        if (!DataSource.s_students.Any(s => s.Id == id))
            throw new DalDoesNotExistException($"Student with ID={id} does not exist");

        DataSource.s_students.RemoveAll(s => s.Id == id);
    }
}
