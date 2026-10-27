using DO;

namespace DalList;

/// <summary>
/// מאגר הנתונים בזיכרון — רשימות האובייקטים של כל ישות.
/// </summary>
internal static class DataSource
{
    /// <summary>רשימת התלמידים.</summary>
    internal static readonly List<Student> s_students = new();

    /// <summary>רשימת השאלות.</summary>
    internal static readonly List<Question> s_questions = new();

    /// <summary>רשימת התשובות.</summary>
    internal static readonly List<Answer> s_answers = new();

    /// <summary>רשימת השאלות לנבחנים.</summary>
    internal static readonly List<StudentQuestion> s_studentQuestions = new();

    /// <summary>רשימת המבחנים.</summary>
    internal static readonly List<Test> s_tests = new();
}

/// <summary>
/// מונה המזהים הרצים לכל ישות.
/// </summary>
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
