﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IconSDK.Types
{
    public class PrivateKey : Bytes
    {
        public override uint Size => 32;

        public PrivateKey(IEnumerable<byte> bytes)
            : base(bytes)
        {

        }

        public PrivateKey(string hex)
            : base(hex)
        {

        }

        public PrivateKey(BigInteger value)
            : base(value)
        {

        }

        public static implicit operator PrivateKey(string hex)
        {
            return new PrivateKey(hex);
        }
    }
}
