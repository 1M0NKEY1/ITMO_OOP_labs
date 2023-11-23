﻿using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Addresse;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Moqs;

public class MoqUser : IUser
{
    public IList<IMessage> ListOfReadMessage { get; } = new List<IMessage>();
    public IList<IMessage> ListOfUnreadMessages { get; } = new List<IMessage>();

    public void SaveMessage(IMessage message)
    {
        ListOfUnreadMessages.Add(message);
    }

    public void ChangeStatus(IMessage message)
    {
        if (ListOfReadMessage.Contains(message))
        {
            ListOfReadMessage.Remove(message);
            ListOfUnreadMessages.Add(message);
        }
        else if (ListOfUnreadMessages.Contains(message))
        {
            ListOfUnreadMessages.Remove(message);
            ListOfReadMessage.Add(message);
        }
    }
}