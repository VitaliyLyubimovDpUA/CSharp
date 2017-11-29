﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public interface IMessage
    {
        string Message { get; set; }
        LevelMsg Level { get; set; }
        int SourceLineNumber { get; set; }
        string SouceFilePath { get; set; }
    }
}
