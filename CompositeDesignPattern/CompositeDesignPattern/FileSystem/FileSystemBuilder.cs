using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.FileSystem
{
    public class FileSystemBuilder
    {
        private FileDirectory CurrentDirectory;
        public FileSystemBuilder(string rootName)
        {
            RootDirectory = new FileDirectory(rootName);
            CurrentDirectory = RootDirectory;
        }

        public FileDirectory RootDirectory { get; }

        public void AddDirectory(string directoryName)
        {
            var directory = new FileDirectory(directoryName);
            this.CurrentDirectory.AddItem(directory);
            this.CurrentDirectory = directory;
        }

        public void AddFile(string fileName , decimal fileSize)
        {
            this.CurrentDirectory.AddItem(new FileItem(fileName, fileSize));
        }

        public void SetCurrentDirectory(string directoryName)
        {
             
            var directoryStack = new Stack<FileDirectory>();
            directoryStack.Push(this.RootDirectory);

            while (directoryStack.Any())
            {
                var currentStackDirectory = directoryStack.Pop();
                if (currentStackDirectory.FileName == directoryName)
                {
                    this.CurrentDirectory = currentStackDirectory;
                    return;
                }
                foreach (var item in currentStackDirectory.FileSystemItems.OfType<FileDirectory>())
                {
                    directoryStack.Push(item);
                }
            }
            throw new InvalidOperationException($"Shape name '{directoryName}' not found!");
        }
    }
}
