﻿namespace Multiformats.Base;

using System;
using System.Linq;

internal class Identity : Multibase
{
    protected override string Name => "identity";
    protected override char Prefix => '\0';
    protected override char[] Alphabet => Array.Empty<char>();

    protected override bool IsValid(string value) => true;
    public override byte[] Decode(string input) => input.Select(Convert.ToByte).ToArray();
    public override string Encode(byte[] bytes) => new(bytes.Select(Convert.ToChar).ToArray());
}
