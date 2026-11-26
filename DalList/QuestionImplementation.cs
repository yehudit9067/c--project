using DalApi;
using DO;

namespace DalList;

/// <summary>
/// מימוש פעולות CRUD על ישות השאלה מול רשימת השאלות ב-DataSource.
/// </summary>
internal class QuestionImplementation : IQuestion
{
    /// <inheritdoc/>
    public int Create(Question item)
    {
        if (DataSource.s_questions.Any(q => q.Id == item.Id))
            throw new DalAlreadyExistsException($"Question with ID={item.Id} already exists");

        Question newItem = item with { Id = Config.NextQuestionId };
        DataSource.s_questions.Add(newItem);
        return newItem.Id;
    }

    /// <inheritdoc/>
    public Question? Read(int id) => DataSource.s_questions.FirstOrDefault(q => q.Id == id);

    /// <inheritdoc/>
    public List<Question> ReadAll() => new(DataSource.s_questions);

    /// <inheritdoc/>
    public void Update(Question item)
    {
        if (!DataSource.s_questions.Any(q => q.Id == item.Id))
            throw new DalDoesNotExistException($"Question with ID={item.Id} does not exist");

        DataSource.s_questions.RemoveAll(q => q.Id == item.Id);
        DataSource.s_questions.Add(item);
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        if (!DataSource.s_questions.Any(q => q.Id == id))
            throw new DalDoesNotExistException($"Question with ID={id} does not exist");

        DataSource.s_questions.RemoveAll(q => q.Id == id);
    }
}
