using System;
using NUnit.Framework;
using IAR;
using System.Collections.Generic;

namespace IAR.Tests
{
    [TestFixture]
    public class CLITests
    {
        
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        // Test case where user provides no arguments.
        public void CLI_Run_Test_Returns1() 
        {
            string[] arguments = new string[] { };
            var _CLI = new CLI(arguments);
            int result = _CLI.Run();
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        // Test case where user provides validate-json command and another string as arguments.
        public void CLI_Run_Test_Returns2() 
        {
            string[] arguments = new string[] { "validate-json", "path" };
            var _CLI = new CLI(arguments);
            int result = _CLI.Run();
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        // Test case where user provides validate-json command, another string, --input-schema option,
        // and another string as arguments.
        public void CLI_Run_Test_Returns3() 
        {
            string[] arguments = new string[] { "validate-json", "path", "--input-schema", "filepath" };
            var _CLI = new CLI(arguments);
            int result = _CLI.Run();
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        // Test case where user provides validate-json command, another string, --input-schema option,
        // and no other string as arguments.
        public void CLI_Run_Test_Returns3_NoFilePath() 
        {
            string[] arguments = new string[] { "validate-json", "path", "--input-schema" };
            var _CLI = new CLI(arguments);
            Assert.Throws<ArgumentOutOfRangeException>(() => _CLI.Run());
        }

        [Test]
        // Test case where user provides validate-json command, another string, --input-schema option,
        // another string, and an extra string as arguments.
        public void CLI_Run_Test_Returns3_ExtraArgumentsShouldBeIgnored() 
        {
            string[] arguments = new string[] { "validate-json", "path", "--input-schema", "filepath", "extraArg" };
            var _CLI = new CLI(arguments);
            int result = _CLI.Run();
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        // Test case where user provides validate-json command, another string, and an invalid option
        // as arguments.
        public void CLI_Run_Test_Returns4() {
            string[] arguments = new string[] { "validate-json", "path", "--inppute-schema" };
            var _CLI = new CLI(arguments);
            int result = _CLI.Run();
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        // Test case where user provides invalid command as an argument.
        public void CLI_Run_Test_Returns5() 
        {
            string[] arguments = new string[] { "vaalidate-json" };
            var _CLI = new CLI(arguments);
            int result = _CLI.Run();
            Assert.That(result, Is.EqualTo(5));
        }
    }
}