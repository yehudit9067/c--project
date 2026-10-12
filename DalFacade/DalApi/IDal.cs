

namespace DalApi;

internal interface IDal
{
    IStudent Student { get; }
    IAnswer Answer { get; }
    IQuestion Question { get; }
    IStudentQuestion StudentQuestion { get; }
    ITest Test { get; }
}
