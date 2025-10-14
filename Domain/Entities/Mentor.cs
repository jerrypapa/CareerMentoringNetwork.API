using CareerMentoringNetwork.API.Domain.Shared;

namespace CareerMentoringNetwork.API.Domain.Entities;

public class Mentor : BaseEntity
{
    ///// <summary>
    ///// In DDD we can keep the collections private and expose them as read only collections to the outside world
    ///// </summary>
    //private readonly List<Session> sessions = new List<Session>();
    //public IReadOnlyCollection<Session> Sessions => sessions.AsReadOnly();

    //public void AddSession(Session session)
    //{
    //    if (session == null)
    //        throw new ArgumentNullException(nameof(session));
    //    sessions.Add(session);
    //}

    public string Name { get;private set; }
    public string Email { get; set; }
    public string Expertise { get; set; }
    public string Bio { get; set; }
    public int YearsOfExperience { get; set; }
    /// <summary>
    /// One to many relationships
    ///  new List<Session>() is to initialize the collection to avoid null reference issues
    ///  
    /// You expose the interface Icollection to consumers of your class to know what they can do (add/remove) but then use a list internally
    /// to implement it
    ///  
    /// </summary>
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
