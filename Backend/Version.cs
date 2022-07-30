﻿using System.Runtime.CompilerServices;

namespace Backend;

public static class Version
{

    private const string VERSION = "4.0.0.1";

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Get()
    {
        return VERSION;
    }

}