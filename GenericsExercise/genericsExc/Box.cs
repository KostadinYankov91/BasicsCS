﻿using System;
using System.Collections.Generic;
using System.Text;

namespace genericsExc
{
    public class Box<T>
        where T: IComparable
    {
        public Box(T value)
        {
            this.Value = value;
        }
        public T Value { get; private set; }

        public override string ToString()
        {
            Type valueType = this.Value.GetType();
            string valueTypename = valueType.Name;
            string valueTypeFullName = valueType.FullName;
            return $"{valueTypeFullName}: {this.Value}"; 
        }
    }
}
