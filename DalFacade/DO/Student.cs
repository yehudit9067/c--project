namespace DO;

public record Student
{
    int student_id;
    string student_name;
    int exam_id;
    int score;

    public Student(int student_id, string student_name, int exam_id, int score)
    {
        this.student_id = student_id;
        this.student_name = student_name;
        this.exam_id = exam_id;
        this.score = score;
    }

    public Student() { }
}
