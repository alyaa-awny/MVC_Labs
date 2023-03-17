namespace Lab2.Models.Domain;

public class Actor
{
    public Guid Id { get; set; }
    public string Mail { get; set; } = string.Empty; //mail
    public string Password { get; set; } = string.Empty; //password
    public bool IsClose { get; set; } //checkbox
    public Country Country { get; set; } //=> CountryId
    public Severity Severity { get; set; } //=> Select
    public List<Award> Awards { get; set; } //=>AwardsId => MultiSelect

    public Actor()
    {
        Id = Guid.NewGuid();
    }

    public Actor(string mail,
        string password,
        bool isClose,
        Country country,
        Severity severity,
        List<Award> awards)
    {
        Id = Guid.NewGuid();
        Mail = mail;
        Password = password;
        IsClose = isClose;
        Country = country;
        Severity = severity;
        Awards = awards;
    }
}



