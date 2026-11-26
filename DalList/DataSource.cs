using DO;

namespace DalList;


/// מאגר הנתונים בזיכרון — רשימות האובייקטים של כל ישות.

internal static class DataSource
{
    /// רשימת התלמידים.
    internal static readonly List<Student> s_students = new();

    /// רשימת השאלות.
    internal static readonly List<Question> s_questions = new();

    /// רשימת התשובות.
    internal static readonly List<Answer> s_answers = new();

    /// רשימת השאלות לנבחנים.
    internal static readonly List<StudentQuestion> s_studentQuestions = new();

    /// רשימת המבחנים.
    internal static readonly List<Test> s_tests = new();
}


/// מונה המזהים הרצים לכל ישות.

internal static class Config
{
    /// המזהה ההתחלתי של תלמיד
    internal const int StartStudentId = 1;

    ///המזהה ההתחלתי של מבחן.
    internal const int StartTestId = 10;

    /// המזהה ההתחלתי של שאלה.
    internal const int StartQuestionId = 10;

    /// המזהה ההתחלתי של תשובה.
    internal const int StartAnswerId = 10;

    private static int s_studentId = StartStudentId;
    private static int s_questionId = StartQuestionId;
    private static int s_answerId = StartAnswerId;
    private static int s_testId = StartTestId;

    /// מחזיר את המזהה הבא של תלמיד ומקדם את המונה.
    internal static int NextStudentId
    {
        get { return s_studentId++; }
    }

    /// מחזיר את המזהה הבא של שאלה ומקדם את המונה.
    internal static int NextQuestionId
    {
        get { return s_questionId++; }
    }

    /// מחזיר את המזהה הבא של תשובה ומקדם את המונה.
    internal static int NextAnswerId
    {
        get { return s_answerId++; }
    }

    /// מחזיר את המזהה הבא של מבחן ומקדם את המונה.
    internal static int NextTestId
    {
        get { return s_testId++; }
    }
}
