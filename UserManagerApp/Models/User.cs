
namespace UserManagement.Models;

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public bool Gender { get; set; }
    public bool StudyInStep { get; set; }

    public User(string name, string surname,string city, bool gender, bool studyInStep)
    {
        Name = name;
        Surname = surname;
        City = city;
        Gender = gender;
        StudyInStep = studyInStep;
    }

    public override string ToString() => $"{Name} / {Surname} / {City} / {(Gender?"Male":"Female")} / {(StudyInStep?"Yes":"No")}";

}
