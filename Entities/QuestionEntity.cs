public class QuestionEntity
{

    public string id { get; set; }
    public string desc { get; set; }
    public string title { get; set; }
    public QuestionTypeEnum type { get; set; }
    public string hint { get; set; }
    public bool required { get; set; }
    public decimal max { get; set; }
    public decimal min { get; set; }
    public string regex { get; set; }
    public int length { get; set; }
    public IEnumerable<string> options { get; set; }

    public QuestionEntity(string id, string desc, string title, QuestionTypeEnum type, string hint, bool required, decimal max, decimal min, string regex, int length, IEnumerable<string> options)
    {
        this.id = id;
        this.desc = desc;
        this.title = title;
        this.type = type;
        this.hint = hint;
        this.required = required;
        this.max = max;
        this.min = min;
        this.regex = regex;
        this.length = length;
        this.options = options;
    }

    public QuestionEntity()
    {
    }
}