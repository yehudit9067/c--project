using DalApi;
using DalTest;
using DO;

IDal s_dal = new DalList.DalList();

try
{
    Initialization.Initialize();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    return;
}

int choice = -1;

do
{
    Console.WriteLine(@"Select an entity to test:
1. Student
2. Question
3. Answer
4. StudentQuestion
5. Test
0. Exit");

    try
    {
        if (!int.TryParse(Console.ReadLine(), out choice))
            throw new FormatException("Invalid input — please enter a number.");

        switch (choice)
        {
            case 1: testStudent(s_dal.Student); break;
            case 2: testQuestion(s_dal.Question); break;
            case 3: testAnswer(s_dal.Answer); break;
            case 4: testStudentQuestion(s_dal.StudentQuestion); break;
            case 5: testTest(s_dal.Test); break;
            case 0: break;
            default: throw new ArgumentOutOfRangeException(nameof(choice), "No such option.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
} while (choice != 0);


static void testStudent(IStudent dal)
{
    int id = int.Parse(Console.ReadLine()!);
    Console.WriteLine(dal.Read(id)?.ToString() ?? "Not found");
    dal.ReadAll().ForEach(Console.WriteLine);
    dal.Delete(id);
    dal.ReadAll().ForEach(Console.WriteLine);
}

static void testQuestion(IQuestion dal)
{
    int id = int.Parse(Console.ReadLine()!);
    Console.WriteLine(dal.Read(id)?.ToString() ?? "Not found");
    dal.ReadAll().ForEach(Console.WriteLine);
    dal.Delete(id);
    dal.ReadAll().ForEach(Console.WriteLine);
}

static void testAnswer(IAnswer dal)
{
    int id = int.Parse(Console.ReadLine()!);
    Console.WriteLine(dal.Read(id)?.ToString() ?? "Not found");
    dal.ReadAll().ForEach(Console.WriteLine);
    dal.Delete(id);
    dal.ReadAll().ForEach(Console.WriteLine);
}

static void testStudentQuestion(IStudentQuestion dal)
{
    int id = int.Parse(Console.ReadLine()!);
    Console.WriteLine(dal.Read(id)?.ToString() ?? "Not found");
    dal.ReadAll().ForEach(Console.WriteLine);
    dal.Delete(id);
    dal.ReadAll().ForEach(Console.WriteLine);
}

static void testTest(ITest dal)
{
    int id = int.Parse(Console.ReadLine()!);
    Console.WriteLine(dal.Read(id)?.ToString() ?? "Not found");
    dal.ReadAll().ForEach(Console.WriteLine);
    dal.Delete(id);
    dal.ReadAll().ForEach(Console.WriteLine);
}
