using System;

namespace NW.Shared.Files.Validation
{
    ///<summary>Collects all the messages used for logging and exceptions for <see cref="Validation"/>.</summary>
    public static class MessageCollection
    {

        public static Func<IFileInfoAdapter, string> ProvidedPathDoesntExist
            = (file) => $"The provided path doesn't exist: '{file.FullName}'.";

    }
}

/*
    Author: numbworks@gmail.com
    Last Update: 11.02.2024
*/