using System;

namespace NW.Shared.Files.Validation
{
    /// <summary>Collects all the library-specific validation methods.</summary>
    public static class FilesValidator
    {

        #region Methods_private

        private static TException CreateException<TException>(string message) where TException : Exception
            => (TException)Activator.CreateInstance(typeof(TException), message);

        #endregion

        #region ValidateFileExistance

        /// <summary>Throws an exception of type TException when <paramref name="file"/> doesn't exist.</summary>
        public static void ValidateFileExistance<TException>(IFileInfoAdapter file) where TException : Exception
        {

            if (!file.Exists)
                throw CreateException<TException>(MessageCollection.ProvidedPathDoesntExist(file));

        }

        /// <summary>Throws an exception of type <see cref="ArgumentException"/> when <paramref name="file"/> doesn't exist.</summary>      
        public static void ValidateFileExistance(IFileInfoAdapter file)
            => ValidateFileExistance<ArgumentException>(file);

        #endregion

    }
}

/*
    Author: numbworks@gmail.com
    Last Update: 11.02.2024
*/