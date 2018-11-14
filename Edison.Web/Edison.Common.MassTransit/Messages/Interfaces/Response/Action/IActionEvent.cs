﻿using Edison.Core.Common.Models;
using System;

namespace Edison.Common.Messages.Interfaces
{
    public interface IActionEvent : IMessage
    {
        ActionModel Action { get; set; }
        Guid ResponseId { get; set; }
        bool IsCloseAction { get; set; }
        Geolocation Geolocation { get; set; }
        double PrimaryRadius { get; set; }
        double SecondaryRadius { get; set; }
    }
}