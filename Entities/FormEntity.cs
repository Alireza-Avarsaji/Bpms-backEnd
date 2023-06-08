public class FormEntity
{

    public string id { get; set; }
    public string name { get; set; }
    public string creatorId { get; set; }
    public IEnumerable<QOPairModel> questionList { get; set; }

    public FormEntity(string id, string name, string creatorId, IEnumerable<QOPairModel> questionList)
    {
        this.id = id;
        this.name = name;
        this.creatorId = creatorId;
        this.questionList = questionList;
    }

    public FormEntity()
    {
    }
}


public class QOPairModel
{
    public string qId { get; set; }
    public string order { get; set; }
}