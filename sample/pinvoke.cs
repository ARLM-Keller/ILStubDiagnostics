///////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation. All rights reserved.
///////////////////////////////////////////////////////////////////////////////

using System.Runtime.InteropServices;
using System;
using System.Reflection;
using System.Text;

/// <summary>
/// ETW Test for PInvoke
/// Try to test the ILStubGenerated and ILStubCacheHit Event
/// </summary>
class ETWTest
{
    [DllImport(@"Server.dll")]
    private static extern int Marshal_String_In(string s);

    [DllImport(@"Server.dll")]
    private static extern int Marshal_String_In2(string s);

    public static void Main(string[] args)
    {
        //PInvoke for  ILStubGenerated Event
        Console.WriteLine("PInvoke:Marshal_String_In");
        string strManaged = "Managed";
        Marshal_String_In(strManaged);

        //PInvoke for ILStubCacheHit Event
        Console.WriteLine("PInvoke:Marshal_String_In2");
        Marshal_String_In2(strManaged);

        Marshal_String_In(strManaged);

    }
}
