public class SubmissionEntity
{

    public string id { get; set; }
    public string formId { get; set; }
    public string userId { get; set; }
    public DateTime createdAt { get; set; }
    public IEnumerable<QAPairModel> questionList { get; set; }

    public SubmissionEntity(string id, string formId, string userId, DateTime createdAt, IEnumerable<QAPairModel> questionList)
    {
        this.id = id;
        this.formId = formId;
        this.userId = userId;
        this.createdAt = createdAt;
        this.questionList = questionList;
    }

    public SubmissionEntity()
    {
    }
}


public class QAPairModel
{
    public string qId { get; set; }
    public string answer { get; set; }
}