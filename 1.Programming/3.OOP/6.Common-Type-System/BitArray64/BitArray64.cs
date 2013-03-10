﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BitArray64: IEnumerable<int>
{
    private ulong bits;

    public BitArray64(ulong bits = 0)
    {
        this.bits = bits;
    }

    public int this[int index]
    {
        get
        {
            if (index < 0 || index > 63)
            {
                throw new IndexOutOfRangeException("Index must be in range [0, 63].");
            }

            return (bits & ((ulong)1 << index)) != 0 ? 1 : 0;
        }
        set
        {
            if (index < 0 || index > 63)
            {
                throw new IndexOutOfRangeException("Index must be in range [0, 63].");
            }

            if (value != 0 && value != 1)
            {
                throw new ArgumentOutOfRangeException("value", "Value must be 0 or 1.");
            }


            if (value == 1)
            {
                this.bits = this.bits | ((ulong)1 << index);
            }
            else
            {
                this.bits = this.bits & (~((ulong)1 << index));
            }
        }
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 64; i++)
        {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new BitArray64Enumerator(bits);
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        BitArray64 arr = obj as BitArray64;
        if ((object)arr == null)
        {
            return false;
        }

        return this.bits == arr.bits;
    }

    public override int GetHashCode()
    {
        return this.bits.GetHashCode();
    }

    public static bool operator ==(BitArray64 first, BitArray64 second) 
    {
        return first.Equals(second);
    }

    public static bool operator !=(BitArray64 first, BitArray64 second)
    {
        return !(first == second);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 64; i++)
        {
            sb.AppendFormat("[{0}] = {1} \n", i, this[i]);
        }
        return sb.ToString();
        //return Convert.ToString((long)this.bits, 2).PadLeft(64, '0');
    }

    private class BitArray64Enumerator : IEnumerator
    {
        private int index;
        private ulong bits;

        public BitArray64Enumerator(ulong bits)
        {
            this.bits = bits;
        }

        public object Current
        {
            get 
            {
                return (bits & ((ulong)1 << index)) != 0 ? 1 : 0;
            }
        }

        public bool MoveNext()
        {
            index++;
            return (index < 64);
        }

        public void Reset()
        {
            index = 0;
        }
    }
}

