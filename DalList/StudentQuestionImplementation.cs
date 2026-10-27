using DalApi;
using DO;

namespace DalList;

/// <summary>
/// מימוש פעולות CRUD על ישות השאלה לנבחן מול רשימת השאלות לנבחנים ב-DataSource.
/// </summary>
internal class StudentQuestionImplementation : IStudentQuestion
{
    /// <inheritdoc/>
    /// <remarks>
    /// לישות זו אין מזהה ייחודי משלה, ולכן המזהה המוחזר הוא האינדקס שלה ברשימה.
    /// </remarks>
    public int Create(StudentQuestion item)
    {
        DataSource.s_studentQuestions.Add(item);
        return DataSource.s_studentQuestions.Count - 1;
    }

    /// <inheritdoc/>
    public StudentQuestion? Read(int id) =>
        id >= 0 && id < DataSource.s_studentQuestions.Count
            ? DataSource.s_studentQuestions[id]
            : null;

    /// <inheritdoc/>
    public List<StudentQuestion> ReadAll() => new(DataSource.s_studentQuestions);

    /// <inheritdoc/>
    public void Update(StudentQuestion item)
    {
        int index = DataSource.s_studentQuestions.FindIndex(sq =>
            sq.StudentId == item.StudentId &&
            sq.TestId == item.TestId &&
            sq.QuestionId == item.QuestionId);

        if (index == -1)
            throw new DalDoesNotExistException(
                $"StudentQuestion for Student={item.StudentId}, Test={item.TestId}, Question={item.QuestionId} does not exist");

        DataSource.s_studentQuestions[index] = item;
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        if (id < 0 || id >= DataSource.s_studentQuestions.Count)
            throw new DalDoesNotExistException($"StudentQuestion with ID={id} does not exist");

        DataSource.s_studentQuestions.RemoveAt(id);
    }
}
