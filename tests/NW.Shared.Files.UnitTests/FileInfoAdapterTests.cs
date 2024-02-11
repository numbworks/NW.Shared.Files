using System;
using NUnit.Framework;

namespace NW.Shared.Files.UnitTests
{
    [TestFixture]
    public class FileInfoAdapterTests
    {

        #region Fields

        private static TestCaseData[] fileInfoAdapterExceptionTestCases =
        {

            new TestCaseData(
                new TestDelegate( () => new FileInfoAdapter(fileInfo: null) ),
                typeof(ArgumentNullException),
                new ArgumentNullException("fileInfo").Message
                ).SetArgDisplayNames($"{nameof(fileInfoAdapterExceptionTestCases)}_01"),

        };

        #endregion

        #region Tests

        [TestCaseSource(nameof(fileInfoAdapterExceptionTestCases))]
        public void FileInfoAdapter_ShouldThrowACertainException_WhenUnproperArguments
            (TestDelegate del, Type expectedType, string expectedMessage)
                => ObjectMother.Method_ShouldThrowACertainException_WhenUnproperArguments(del, expectedType, expectedMessage);

        #endregion

    }
}

/*
    Author: numbworks@gmail.com
    Last Update: 11.02.2024
*/