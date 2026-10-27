using DalApi;
using DO;

namespace DalTest;

/// <summary>
/// אתחול ראשוני של שכבת הנתונים — מילוי כל רשימות הישויות בנתוני דוגמה.
/// </summary>
public static class Initialization
{
    private static IDal? s_dal;

    /// <summary>יוצר נתוני דוגמה לכל הישויות. יש לקרוא לפני כל שימוש ב-DAL.</summary>
    public static void Initialize()
    {
        s_dal = new DalList.DalList();

        createStudents();
        createTests();
        createQuestions();
        createAnswers();
        createStudentQuestions();
    }

    private static void createStudents()
    {
        s_dal!.Student.Create(new Student { Name = "יהודית כהן", TestId = 10, Score = 85 });
        s_dal!.Student.Create(new Student { Name = "רות לוי", TestId = 10, Score = 90 });
        s_dal!.Student.Create(new Student { Name = "תמר כץ", TestId = 10, Score = 70 });
    }

    private static void createTests()
    {
        s_dal!.Test.Create(new Test { Topic = Topic.Math, Date = new DateTime(2025, 6, 1), NumOfQuestions = 10 });
        s_dal!.Test.Create(new Test { Topic = Topic.Hebrew, Date = new DateTime(2025, 6, 8), NumOfQuestions = 10 });
        s_dal!.Test.Create(new Test { Topic = Topic.English, Date = new DateTime(2025, 6, 15), NumOfQuestions = 10 });
    }

    private static void createQuestions()
    {
        for (int i = 1; i <= 20; i++)
        {
            Topic topic = (Topic)((i - 1) / 7 + 1);
            if ((int)topic > (int)Topic.English)
                topic = Topic.English;

            s_dal!.Question.Create(new Question
            {
                Topic = topic,
                Content = $"השאלה {i}",
                CorrectAnswerId = 10 + (i - 1) * 4
            });
        }
    }

    private static void createAnswers()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int option = 0; option < 4; option++)
            {
                s_dal!.Answer.Create(new Answer
                {
                    QuestionId = 10 + i,
                    Content = $"התשובה {option + 1}"
                });
            }
        }
    }

    private static void createStudentQuestions()
    {
        s_dal!.StudentQuestion.Create(new StudentQuestion
        {
            StudentId = 1,
            TestId = 10,
            QuestionId = 10,
            AnswerId = 10
        });
    }
}
