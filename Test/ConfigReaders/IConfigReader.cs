﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public interface IConfigReader
    {
        string FilesFormat { get; }
        IEnumerable<T> ReadConfigFromFile<T>(string path);
    }
}
