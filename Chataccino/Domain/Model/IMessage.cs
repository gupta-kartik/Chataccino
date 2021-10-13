using System;

namespace Chataccino.Domain.Model
{
    public interface IMessage
    {
        IUser SentBy { get; set; }
        DateTime TimeSent { get; set; }
        IRoom SentIn { get; set; } 
    }
}