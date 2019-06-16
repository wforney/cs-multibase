﻿using System;

namespace Multiformats.Base
{
    internal class Base32HexLower : Base32
    {
        private static readonly char[] _alphabet = "0123456789abcdefghijklmnopqrstuv".ToCharArray();

        protected override string Name => "base32hex";
        protected override char Prefix => 'v';
        protected override char[] Alphabet => _alphabet;

        public override byte[] Decode(string input) => Decode(input.AsSpan(), false, LetterCasing.Lower).ToArray();
        public override ReadOnlySpan<byte> Decode(ReadOnlySpan<char> input) => Decode(input, false, LetterCasing.Lower);
        public override string Encode(byte[] bytes) => Encode(bytes.AsSpan(), false).ToString();
        public override ReadOnlySpan<char> Encode(ReadOnlySpan<byte> bytes) => Encode(bytes, false);
    }
}