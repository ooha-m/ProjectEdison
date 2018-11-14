﻿using Edison.Core.Common.Models;
using System;

namespace Edison.Common.Messages.Interfaces
{
    public interface IActionNotificationEvent : IMessage, IActionBaseEvent
    {
        string PhoneNumber { get; set; }
        string Message { get; set; }
        bool IsSilent { get; set; }
    }
}