using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.FileSystem
{
    public class FileDirectory : FileSystemItem
    {
        public FileDirectory(string fileName) :base(fileName)
        {

        }
        public List<FileSystemItem> FileSystemItems { get; } = new List<FileSystemItem>();

        public void AddItem(FileSystemItem fileSystemItem)
        {
            FileSystemItems.Add(fileSystemItem);  
        }

        public void RemoveItem(FileSystemItem fileSystemItem)
        {
            FileSystemItems.Remove(fileSystemItem);
        }

        public override decimal GetSizeInByte()
        {
            return FileSystemItems.Sum(item => item.GetSizeInByte());
        }
    }
}
