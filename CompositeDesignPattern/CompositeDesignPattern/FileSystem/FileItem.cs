using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.FileSystem
{
    public class FileItem : FileSystemItem
    {
        public FileItem(string fileName , decimal fileSize) : base(fileName)
        {
            FileSize = fileSize;
        }

        public decimal FileSize { get; }

        public override decimal GetSizeInByte()
        {
            return decimal.Divide(this.FileSize, 1000); ;   
        }
    }
}
