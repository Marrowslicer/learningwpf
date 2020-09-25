using System.IO;

namespace P008_LearningFileSystem
{
    public interface IFileSystem
    {
        void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, bool recursive);
        void CopyFile(string sourceFileName, string destinationFileName, bool overwrite);
        DirectoryInfo CreateDirectory(string path);
        FileStream CreateFile(string path);
        void DeleteDirectory(string path, bool recursive);
        void DeleteFile(string path);
        bool DirectoryExist(string path);
        bool FileExist(string path);
        void MergeDirectories(string sourcePath, string destinationPath);
        void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName);
        void MoveFile(string sourceFileName, string destinationFileName);
    }
}
