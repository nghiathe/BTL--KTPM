using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Windows.Forms;
using DAL;
using DTO;
using QLquannet;
using System.Collections.Generic;
using System.Globalization;

namespace UnitTestProject
{
    [TestClass]
    public class GUITest
    {
        private frmComputer formUnderTest;
        private Mock<IZoneDAL> mockZoneDAL;
        private Mock<IUsageSessionDAL> mockUsageSessionDAL;
        private Mock<IBillingDAL> mockBillingDAL;
        private Mock<IFoodDAL> mockFoodDAL;

        [TestInitialize]
        public void Setup()
        {
            mockZoneDAL = new Mock<IZoneDAL>();
            mockUsageSessionDAL = new Mock<IUsageSessionDAL>();
            mockBillingDAL = new Mock<IBillingDAL>();
            mockFoodDAL = new Mock<IFoodDAL>();

            mockZoneDAL.Setup(dal => dal.loadCom(It.IsAny<byte>()))
                       .Returns(new List<Zone>
                       {
                           new Zone { ComName = "Máy 01", ComStatus = 0 },
                           new Zone { ComName = "Máy 02", ComStatus = 1 },
                           new Zone { ComName = "Máy 03", ComStatus = 1 },
                       });

            mockUsageSessionDAL.Setup(dal => dal.GetUsageSessionDetails(It.IsAny<byte>()))
                               .Returns(new UsageSession
                               {
                                   ComName = "Máy 01",
                                   STime = DateTime.Now.AddHours(-2),
                                   ComStatus = 1,
                                   BillId = 1
                               });

            mockFoodDAL.Setup(dal => dal.GetFoodDetail(It.IsAny<byte>()))
                       .Returns(new List<Food>
                       {
                           new Food { FoodName = "Food 1", Price = 50000, Count = 2, Cost = 100000 },
                           new Food { FoodName = "Food 2", Price = 30000, Count = 1, Cost = 30000 }
                       });
            mockUsageSessionDAL.Setup(dal => dal.GetUnCheckOutSession(It.IsAny<byte>()))
                               .Returns(1); // Assume billId exists for the test

            formUnderTest = new frmComputer(mockZoneDAL.Object, mockUsageSessionDAL.Object, mockFoodDAL.Object, mockBillingDAL.Object);

            // Mocking necessary controls for the test
            formUnderTest.lvFood = new ListView();
            formUnderTest.txtFcost = new TextBox();
            formUnderTest.txtTamtinh = new TextBox() { Text = "200000" }; // Assumed existing total cost
            formUnderTest.txtTotal = new TextBox();
            formUnderTest.txtTT = new TextBox();
            formUnderTest.gbMay = new GroupBox();
            formUnderTest.cid = 1;
            formUnderTest.txtTT.Text = "Offline";
        }

        [TestMethod]
        public void Test_LoadZone_ShouldPopulateButtonsAndControls()
        {
            byte zoneId = 1;
            formUnderTest.LoadZone(zoneId);

            Assert.AreEqual(3, formUnderTest.flpCom.Controls.Count, "Number of controls added does not match expected");
        }

        [TestMethod]
        public void Test_LoadUsageSession_ShouldPopulateFields()
        {
            byte comId = 1;
            formUnderTest.LoadUsageSession(comId);

            Assert.AreEqual("Máy 01", formUnderTest.gbMay.Text);
            Assert.AreEqual("02:00", formUnderTest.txtTime.Text);
            Assert.AreEqual("Online", formUnderTest.txtTT.Text);
        }
        [TestMethod]
        public void Test_LoadFoodDetail_ShouldPopulateListViewAndCalculateCost()
        {
            byte comId = 1;
            formUnderTest.LoadFoodDetail(comId);

            Assert.AreEqual(2, formUnderTest.lvFood.Items.Count, "Number of food items does not match expected");

            decimal expectedFcost = 130000; // 100000 + 30000
            Assert.AreEqual(expectedFcost.ToString(), formUnderTest.txtFcost.Text, "Food cost does not match expected");

            CultureInfo ct = new CultureInfo("vi-VN");
            decimal expectedTotal = 200000 + expectedFcost; // Existing total cost + food cost
            Assert.AreEqual(expectedTotal.ToString("c", ct), formUnderTest.txtTotal.Text, "Total cost does not match expected");

            foreach (ListViewItem item in formUnderTest.lvFood.Items)
            {
                Console.WriteLine($"{item.Text}: {item.SubItems[1].Text}, {item.SubItems[2].Text}, {item.SubItems[3].Text}");
            }
        }
        [TestMethod]
        public void Test_btnBatmay_Click_ShouldStartSession()
        {
            // Arrange
            formUnderTest.txtTT.Text = "Offline"; 
            formUnderTest.gbMay.Text = "Máy 01";  

            // Act
            var btnBatmay = new Button();
            formUnderTest.btnBatmay_Click(btnBatmay, EventArgs.Empty);

            // Assert
            mockUsageSessionDAL.Verify(dal => dal.StartSession(It.IsAny<byte>()), Times.Once, "StartSession was not called exactly once.");
        }

        [TestMethod]
        public void Test_btnBatmay_Click_ShouldShowMessage_WhenMachineIsOnline()
        {
            // Arrange
            formUnderTest.txtTT.Text = "Online";

            // Act
            var btnBatmay = new Button();
            formUnderTest.btnBatmay_Click(btnBatmay, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_btnBatmay_Click_ShouldShowMessage_WhenMachineIsInErrorState()
        {
            // Arrange
            formUnderTest.txtTT.Text = "Error";

            // Act
            var btnBatmay = new Button();
            formUnderTest.btnBatmay_Click(btnBatmay, EventArgs.Empty);

        }

        [TestMethod]
        public void Test_btnBatmay_Click_ShouldShowMessage_WhenNoMachineIsSelected()
        {
            // Arrange
            formUnderTest.txtTT.Text = "Offline";
            formUnderTest.gbMay.Text = "";

            // Act
            var btnBatmay = new Button();
            formUnderTest.btnBatmay_Click(btnBatmay, EventArgs.Empty);

        }

        [TestMethod]
        public void Test_btnThanhtoan_Click_ShouldCheckOutSuccessfully()
        {
            // Arrange
            formUnderTest.txtTT.Text = "Online"; 
            formUnderTest.gbMay.Text = "Máy 01";  

            // Act
            var btnThanhtoan = new Button();
            formUnderTest.btnThanhtoan_Click(btnThanhtoan, EventArgs.Empty);

            // Assert
            mockUsageSessionDAL.Verify(dal => dal.EndSession(It.IsAny<int>()), Times.Once, "EndSession was not called exactly once.");
            mockBillingDAL.Verify(dal => dal.CheckOut(It.IsAny<int>(), It.IsAny<byte>()), Times.Once, "CheckOut was not called exactly once.");
        }

        [TestMethod]
        public void Test_btnThanhtoan_Click_ShouldShowMessage_WhenNoMachineIsSelected()
        {
            // Arrange
            formUnderTest.txtTT.Text = "";
            formUnderTest.gbMay.Text = "";

            // Act
            var btnThanhtoan = new Button();
            formUnderTest.btnThanhtoan_Click(btnThanhtoan, EventArgs.Empty);

        }

        [TestMethod]
        public void Test_btnThanhtoan_Click_ShouldShowMessage_WhenMachineIsOffline()
        {
            // Arrange
            formUnderTest.txtTT.Text = "Offline";
            formUnderTest.gbMay.Text = "Máy";

            // Act
            var btnThanhtoan = new Button();
            formUnderTest.btnThanhtoan_Click(btnThanhtoan, EventArgs.Empty);

        }
    }
}

