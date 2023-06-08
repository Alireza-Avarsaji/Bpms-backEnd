public class UserEntity
{

    public string id { get; set; }
    public string name { get; set; }
    public string personnelId { get; set; }


    public UserEntity()
    {
    }

    public UserEntity(string id, string name, string personnelId)
    {
        this.id = id;
        this.name = name;
        this.personnelId = personnelId;
    }
}