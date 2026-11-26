using DalApi;
using DO;

namespace DalList;

/// <summary>
/// מימוש פעולות CRUD על ישות המבחן מול רשימת המבחנים ב-DataSource.
/// </summary>
internal class TestImplementation : ITest
{
    /// <inheritdoc/>
    public int Create(Test item)
    {
        if (DataSource.s_tests.Any(t => t.Id == item.Id))
            throw new DalAlreadyExistsException($"Test with ID={item.Id} already exists");

        Test newItem = item with { Id = Config.NextTestId };
        DataSource.s_tests.Add(newItem);
        return newItem.Id;
    }

    /// <inheritdoc/>
    public Test? Read(int id) => DataSource.s_tests.FirstOrDefault(t => t.Id == id);

    /// <inheritdoc/>
    public List<Test> ReadAll() => new(DataSource.s_tests);

    /// <inheritdoc/>
    public void Update(Test item)
    {
        if (!DataSource.s_tests.Any(t => t.Id == item.Id))
            throw new DalDoesNotExistException($"Test with ID={item.Id} does not exist");

        DataSource.s_tests.RemoveAll(t => t.Id == item.Id);
        DataSource.s_tests.Add(item);
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        if (!DataSource.s_tests.Any(t => t.Id == id))
            throw new DalDoesNotExistException($"Test with ID={id} does not exist");

        DataSource.s_tests.RemoveAll(t => t.Id == id);
    }
}
