﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface IRebel : IBuyer
    {
        string Name { get; }
        string Group { get; }
    }
}
