using System;
using System.IO;

namespace P008_LearningFileSystem
{
    public class FileSystem
    {
        public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, bool recursive)
        {
            var directory = new DirectoryInfo(sourceDirectoryName);

            if (!directory.Exists)
            {
                throw new FileSystemException(
                    FileSystemExceptionMessages.DIRECTORY_NOT_FOUND_ERROR
                    .Args(sourceDirectoryName));
            }

            var directories = directory.GetDirectories();
            CreateDirectory(destinationDirectoryName);

            var files = directory.GetFiles();
            foreach (var file in files)
            {
                var tempPath = Path.Combine(destinationDirectoryName, file.Name);
                file.CopyTo(tempPath, false);
            }

            if (recursive)
            {
                foreach (var subDirectory in directories)
                {
                    var tempPath = Path.Combine(destinationDirectoryName, subDirectory.Name);
                    CopyDirectory(subDirectory.FullName, tempPath, recursive);
                }
            }
        }

        public void CopyFile(string sourceFileName, string destinationFileName, bool overwrite)
        {
            try
            {
                File.Copy(sourceFileName, destinationFileName, overwrite);
            }
            catch (Exception)
            {
                throw new FileSystemException(
                    FileSystemExceptionMessages.COPY_ERROR
                    .Args(sourceFileName, destinationFileName));
            }
        }

        public DirectoryInfo CreateDirectory(string path)
        {
            try
            {
                return Directory.CreateDirectory(path);
            }
            catch (Exception)
            {
                throw new FileSystemException(
                    FileSystemExceptionMessages.CREATE_DIRECTORY_ERROR
                    .Args(path));
            }
        }

        public FileStream CreateFile(string path)
        {
            try
            {
                return File.Create(path);
            }
            catch (Exception)
            {
                throw new FileSystemException(
                    FileSystemExceptionMessages.CREATE_FILE_ERROR
                    .Args(path));
            }
        }

        public void DeleteDirectory(string path, bool recursive)
        {
            try
            {
                Directory.Delete(path, recursive);
            }
            catch (Exception)
            {
                throw new FileSystemException(
                    FileSystemExceptionMessages.DELETE_DIRECTORY_ERROR
                    .Args(path));
            }
        }

        public void DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception)
            {
                throw new FileSystemException(
                    FileSystemExceptionMessages.DELETE_FILE_ERROR
                    .Args(path));
            }
        }

        public bool DirectoryExist(string path)
        {
            return Directory.Exists(path);
        }

        public bool FileExist(string path)
        {
            return File.Exists(path);
        }

        public void MergeDirectories(string sourcePath, string destinationPath)
        {
            var sourceDirectory = new DirectoryInfo(sourcePath);

            if (!sourceDirectory.Exists)
            {
                throw new FileSystemException(
                    FileSystemExceptionMessages.DIRECTORY_NOT_FOUND_ERROR
                    .Args(sourcePath));
            }

            var destinationDirectory = new DirectoryInfo(destinationPath);

            if (!destinationDirectory.Exists)
            {
                throw new FileSystemException(
                    FileSystemExceptionMessages.DIRECTORY_NOT_FOUND_ERROR
                    .Args(destinationPath));
            }

            var sourceFiles = sourceDirectory.GetFiles();
            var destinationFiles = destinationDirectory.GetFiles();
        }

        public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName)
        {
            try
            {
                Directory.Move(sourceDirectoryName, destinationDirectoryName);
            }
            catch (Exception)
            {
                throw new FileSystemException(
                    FileSystemExceptionMessages.MOVE_DIRECTORY_ERROR
                    .Args(sourceDirectoryName, destinationDirectoryName));
            }
        }

        public void MoveFile(string sourceFileName, string destinationFileName)
        {
            try
            {
                File.Move(sourceFileName, destinationFileName);
            }
            catch (Exception)
            {
                throw new FileSystemException(
                    FileSystemExceptionMessages.MOVE_FILE_ERROR
                    .Args(sourceFileName, destinationFileName));
            }
        }
    }
}
