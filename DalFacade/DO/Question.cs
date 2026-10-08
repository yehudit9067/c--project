namespace DO;

public record Question
{
    int question_id;
    enum Topic;
    string content;
    int correct_answer_id;

    public Question(int question_id, Enum Topic, string content, int correct_answer_id)
    {   this.question_id = question_id;
        Topic = Topic;
        this.content = content;
        this.correct_answer_id = correct_answer_id;
    }

    public Question() { }

}
