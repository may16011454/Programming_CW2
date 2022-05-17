using Xunit;
using Programming_A2;
using System;

namespace UnitTests
{
    public class UnitTest1
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

        [Fact]
        public void CosmeticIssueToStringTest()
        {
            //Arrange
            Cosmetic majorIssue;

            //Act
            majorIssue = new Cosmetic("Shelf Landed on Toe", DateTime.Now);
            string? majorIssueString = majorIssue.ToString();

            //Assert
            Assert.IsType<Cosmetic>(majorIssue);
            Assert.Equal(majorIssueString, $"Description: Shelf Landed on Toe Time Stamp: {DateTime.Now}");

        }
        [Fact]
        public void BookingToStringTest()
        {
            //Arrange
            Booking bookings;

            //Act
            bookings = new Booking("Booked In", null);
            string? bookingsString = bookings.ToString();

            //Assert
            Assert.IsType<Booking>(bookings);
            Assert.Equal(bookingsString, $"Details: Booked In Booking Time: {DateTime.Now}");

        }
        [Fact]
        public void CommercialToStringTest()
        {
            //Arrange
            Commercial com;

            //Act
            com = new Commercial("123", 12);
            string? comString = com.ToString();

            //Assert
            Assert.IsType<Commercial>(com);
            Assert.Equal(comString, $"Address: 123 Size: 12");

        }       
        
        [Fact]
        public void CustomerToStringTest()
        {
            //Arrange
            Customer com;

            //Act
            com = new Customer("Barold", "Barryson", "7");
            string? comString = com.ToString();

            //Assert
            Assert.IsType<Customer>(com);
            Assert.Equal(comString, $"First Name: Barold Last Name: Barryson Contact: 7");

        }



    }
    }