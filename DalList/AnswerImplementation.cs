using DalApi;
using DO;

namespace DalList;


/// מימוש פעולות CRUD על ישות התשובה מול רשימת התשובות ב-DataSource.

internal class AnswerImplementation : IAnswer
{
 
    public int Create(Answer item)
    {
        if (DataSource.s_answers.Any(a => a.Id == item.Id))
            throw new DalAlreadyExistsException($"Answer with ID={item.Id} already exists");

        Answer newItem = item with { Id = Config.NextAnswerId };
        DataSource.s_answers.Add(newItem);
        return newItem.Id;
    }

    public Answer? Read(int id) => DataSource.s_answers.FirstOrDefault(a => a.Id == id);

    public List<Answer> ReadAll() => new(DataSource.s_answers);

    public void Update(Answer item)
    {
        if (!DataSource.s_answers.Any(a => a.Id == item.Id))
            throw new DalDoesNotExistException($"Answer with ID={item.Id} does not exist");

        DataSource.s_answers.RemoveAll(a => a.Id == item.Id);
        DataSource.s_answers.Add(item);
    }

    public void Delete(int id)
    {
        if (!DataSource.s_answers.Any(a => a.Id == id))
            throw new DalDoesNotExistException($"Answer with ID={id} does not exist");

        DataSource.s_answers.RemoveAll(a => a.Id == id);
    }
}
