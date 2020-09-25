﻿using System;

namespace P008_LearningFileSystem
{
    public class FileSystemException : Exception
    {
        public FileSystemException()
        {
        }

        public FileSystemException(string message)
            : base(message)
        {
        }

        public FileSystemException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
