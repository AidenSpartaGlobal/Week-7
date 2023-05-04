﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialistaionApp
{
    public interface ISerialise
    {
        void SerialiseToFile<T>(string filePath, T item);
        T DeserialiseFromFile<T>(string filePath);
    }
}
