namespace CareerMentoringNetwork.API.Models;

public class Student
{
    // prop ....your tab key twice
    public string FirstName { get; set; } //properties .....
    public string LastName { get; set; }
    public string Fullname => $"{FirstName} {LastName}"; ///Its only a getter
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Major { get; set; }
    public string? LinkedInProfile { get; set; } //? means it can be null...so ideally you would say  linked in profile is nullable
    //nullable properties have to be at the end of our constructor parameters
    public Student() { }

    public Student(string firstName, string lastName, string email,string phoneNumber,string major, string? linkedInProfile)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Major = major;
        LinkedInProfile = linkedInProfile;
    }

    public static Student CreateStudent(string firstName, string lastName, string email, string phoneNumber, string major, string? linkedInProfile)
    {
        return new Student(firstName, lastName, email, phoneNumber, major, linkedInProfile);
    }

}
