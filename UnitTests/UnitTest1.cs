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
            Customer cus;

            //Act
            cus = new Customer("Barold", "Barryson", "7");
            string? cusString = cus.ToString();

            //Assert
            Assert.IsType<Customer>(cus);
            Assert.Equal(cusString, $"First Name: Barold Last Name: Barryson Contact: 7");

        }

        [Fact]
        public void DomesticToStringTest()
        {
            //Arrange
            Domestic dom;

            //Act
            dom = new Domestic("1234",null, Enums.DomesticType.HOUSE, 8);
            string? domString = dom.ToString();

            //Assert
            Assert.IsType<Domestic>(dom);
            Assert.Equal(domString, $"Address: 1234 Number of Rooms: 8 Type: HOUSE");

        }
        [Fact]
        public void PurchaseToStringTest()
        {
            //Arrange
            Purchases dom;

            //Act
            dom = new Purchases("Mop", 9.99, null);
            string? domString = dom.ToString();

            //Assert
            Assert.IsType<Purchases>(dom);
            Assert.Equal(domString, $"Description: Mop Cost: £9.99 Date Purchased: {DateTime.Now}");

        }
        [Fact]
        public void SerivicesToStringTest()
        {
            //Arrange
            Services dom;

            //Act
            dom = new Services("Clean", true);
            string? domString = dom.ToString();

            //Assert
            Assert.IsType<Services>(dom);
            Assert.Equal(domString, $"Details: Clean Is Service Open: False Time Started: {DateTime.Now} Time Finished: {DateTime.Now}");

        }
        [Fact]
        public void StaffMemberToStringTest()
        {
            //Arrange
            StaffMember dom;

            //Act
            dom = new StaffMember("Barold II", "Barryson","BaroldB",null, Enums.StaffType.CLEANER);
            string? domString = dom.ToString();

            //Assert
            Assert.IsType<StaffMember>(dom);
            Assert.Equal(domString, $"First Name: Barold II Last Name: Barryson Username: BaroldB Type: CLEANER");

        }
    }
    }