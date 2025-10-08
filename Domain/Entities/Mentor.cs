using CareerMentoringNetwork.API.Domain.Shared;

namespace CareerMentoringNetwork.API.Domain.Entities;

public class Mentor : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Expertise { get; set; }
    public string Bio { get; set; }
    public int YearsOfExperience { get; set; }
    public ICollection<Session> Sessions { get; set; } = new List<Session>(); //List of sessions associated with the mentor;  Lists and collectiosn
    public Mentor(string name, string email, string expertise, string bio, int yearsOfExperience)
    {
        Name = name;
        Email = email;
        Expertise = expertise;
        Bio = bio;
        YearsOfExperience = yearsOfExperience;
    }
    public Mentor() { }
}
