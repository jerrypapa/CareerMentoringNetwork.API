using CareerMentoringNetwork.API.Domain.Shared;

namespace CareerMentoringNetwork.API.Domain.Entities;

public class Mentee: BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Goals { get; set; }
    public ICollection<Session> Sessions { get; set; } = new List<Session>(); //List of sessions associated with the mentee;  Lists and collectiosn
    public Mentee(string name, string email, string goals)
    {
        Name = name;
        Email = email;
        Goals = goals;
    }
    public Mentee() { }
}
