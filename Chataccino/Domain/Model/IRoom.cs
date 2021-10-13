namespace Chataccino.Domain.Model
{
    public interface IRoom
    {
        string Name { get; set; }
        IUser[] Participants { get; set; }
        bool IsPublic { get; set; }
    }
}