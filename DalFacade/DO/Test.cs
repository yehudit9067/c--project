namespace DO;

public record Test
{
    int test_id;
    enum Topic;
    DateTime test_date;
    int num_of_questions;

    
    public Test(int test_id, Enum Topic, DateTime test_date, int num_of_questions)
    { 
        this.test_id = test_id;
        Topic = Topic;
        this.test_date = test_date;
        this.num_of_questions = num_of_questions;
    }

    public Test()
    { }





}
