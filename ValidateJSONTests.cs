using System;
using NUnit.Framework;
using IAR;
using System.IO;

namespace IAR.Tests
{
    [TestFixture]
    public class ValidateJSONTests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void filePathValid_ReturnFalse()
        {
            var path = @"";
            var _validateJSON = new ValidateJSON(path);
            var result = _validateJSON.filePathValid();
            Assert.That(result, Is.Not.True);
        }

        [Test]
        public void filePathValid_ReturnTrue()
        {
            string cwd = Directory.GetCurrentDirectory();
            string target = "\\IAR.dll";
            string path = Path.Combine(cwd, target);
            Console.WriteLine(path);
            var _validateJSON = new ValidateJSON(target);
            var result = _validateJSON.filePathValid();
            Assert.That(result, Is.True);
        }
    }
}