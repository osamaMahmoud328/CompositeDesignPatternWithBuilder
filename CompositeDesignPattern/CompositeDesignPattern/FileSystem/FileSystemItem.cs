using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.FileSystem
{
    public abstract class FileSystemItem
    {
        public FileSystemItem(string fileName)
        {
            FileName = fileName;
        }

        public string FileName { get; }

        public abstract decimal GetSizeInByte();

    }
}
