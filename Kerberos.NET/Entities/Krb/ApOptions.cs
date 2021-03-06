﻿using System;

namespace Kerberos.NET.Entities
{
    [Flags]
    public enum ApOptions
    {
        Reserved = 0,
        ChannelBindingSupported = 1 << 14,
        UseSessionKey = 1 << 30,
        MutualRequired = 1 << 29
    }
}
