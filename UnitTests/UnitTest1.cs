using Xunit;
using Programming_A2;
using System;

namespace UnitTests
{
    public class UnitTest1
    {
        public class UnitTestsIssues
        {
            [Fact]
            public void MajorIssueToStringTest()
            {
                //Arrange
                Major majorIssue;

                //Act
                majorIssue = new Major("Water Damage", DateTime.Now, Enums.IssueSeverity.BAD);
                string? majorIssueString = majorIssue.ToString();

                //Assert
                Assert.IsType<Major>(majorIssue);
                Assert.Equal(majorIssueString, $"Description: Water Damage Date: {DateTime.Now} Severity of Issue: BAD");

            }

        }
    }}