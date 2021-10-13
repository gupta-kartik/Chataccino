namespace Chataccino.Domain.Model
{
    public interface IUser
    {
        string Email { get; set; }
        string DisplayName { get; set; }
    }
}