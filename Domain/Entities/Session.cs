using CareerMentoringNetwork.API.Domain.Shared;

namespace CareerMentoringNetwork.API.Domain.Entities;

public class Session : BaseEntity
{
    public DateTime ScheduledAt { get; set; }
    public string Status { get; set; } 
    public string Topic { get; set; }
    public int MentorId { get; set; }//Foreign key
    public int MenteeId { get; set; }////Foreign key

    public Mentor Mentor { get; set; }//Navigation property
    public Mentee Mentee { get; set; }////Navigation property
    public string Notes { get; set; }
    public Session(int mentorId, int menteeId, DateTime scheduledAt, string status, string notes, string topic)
    {
        ScheduledAt = scheduledAt;
        Status = status;
        Notes = notes;
        Topic = topic;
        MentorId = mentorId;
        MenteeId = menteeId;
    }
    public Session() { }
}
