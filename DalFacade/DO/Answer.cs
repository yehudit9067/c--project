namespace DO;

public record Answer
{
    int answer_id;
    int question_id;
    string content;

    public Answer(int answer_id, int question_id, string content)
    {   this.answer_id = answer_id;
        this.question_id = question_id;
        this.content = content; 
    }

    public Answer() { }
}


