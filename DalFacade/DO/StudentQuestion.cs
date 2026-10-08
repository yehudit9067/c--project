namespace DO;

public record StudentQuestion
{
    int student_id;
    int exam_id;
    int question_id;  
    int answer_id;   //The selected answer


public StudentQuestion(int student_id, int exam_Id, int question_id, int answer_id)
    {
        this.student_id = student_id;
        this.exam_id = exam_Id;
        this.question_id = question_id; 
        this.answer_id = answer_id; 
    }

    public StudentQuestion() { }

}
