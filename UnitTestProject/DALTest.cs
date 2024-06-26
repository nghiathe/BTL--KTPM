using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using DTO;
using Moq;
using System.Collections.Generic;
using System.Data;

namespace UnitTestProject
{
    [TestClass]
    public class FoodDALTests
    {
        private Mock<IDatabase> mockDatabase;
        private FoodDAL foodDAL;

        [TestInitialize]
        public void Setup()
        {
            mockDatabase = new Mock<IDatabase>();
            Database.SetInstance(mockDatabase.Object);
            foodDAL = FoodDAL.Instance;
        }

        //[TestMethod]
        //public void GetFoodDetail_ValidComputerID_ReturnsFoodList()
        //{
        //    // Arrange
        //    byte comid = 1;
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("FoodID", typeof(byte));
        //    dt.Columns.Add("FoodName", typeof(string));
        //    dt.Rows.Add(1, "Cơm rang");

        //    mockDatabase.Setup(db => db.ExecuteQuery("GetFoodDetailsByComputerID @ComputerID ", new object[] { comid }))
        //                .Returns(dt);

        //    // Act
        //    List<Food> result = foodDAL.GetFoodDetail(comid);

        //    // Assert
        //    Assert.AreEqual(1, result.Count);
        //    Assert.AreEqual(1, result[0].FoodID);
        //    Assert.AreEqual("Cơm rang", result[0].FoodName);
        //}


        [TestMethod]
        public void GetCategories_ReturnsCategoryList()
        {
            // Arrange
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Rows.Add("Beverages");

            mockDatabase.Setup(db => db.ExecuteQuery("SELECT CategoryName FROM Category"))
                        .Returns(dt);

            // Act
            DataTable result = foodDAL.GetCategories();

            // Assert
            Assert.AreEqual(1, result.Rows.Count);
            Assert.AreEqual("Beverages", result.Rows[0]["CategoryName"]);
        }

        [TestMethod]
        public void GetUncheckBillingID_ValidComputerID_ReturnsBillingID()
        {
            // Arrange
            byte comid = 1;
            object billingID = 123;

            mockDatabase.Setup(db => db.ExecuteScalar("SELECT BillingID FROM UsageSession WHERE ComputerID = @ComID and endtime is null", new object[] { comid }))
                        .Returns(billingID);

            // Act
            int result = foodDAL.GetUncheckBillingID(comid);

            // Assert
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void GetUncheckBillingID_InvalidComputerID_ReturnsMinusOne()
        {
            // Arrange
            byte comid = 1;

            mockDatabase.Setup(db => db.ExecuteScalar("SELECT BillingID FROM UsageSession WHERE ComputerID = @ComID and endtime is null", new object[] { comid }))
                        .Returns(null);

            // Act
            int result = foodDAL.GetUncheckBillingID(comid);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void FoodDetailsExist_ValidData_ReturnsTrue()
        {
            // Arrange
            int billingID = 1;
            int foodID = 1;

            mockDatabase.Setup(db => db.ExecuteScalar("SELECT 1 FROM FoodDetail WHERE BillingID = @BillingID AND FoodID = @FoodID ", new object[] { billingID, foodID }))
                        .Returns(1);

            // Act
            bool result = foodDAL.FoodDetailsExist(billingID, foodID);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void FoodDetailsExist_InvalidData_ReturnsFalse()
        {
            // Arrange
            int billingID = 1;
            int foodID = 1;

            mockDatabase.Setup(db => db.ExecuteScalar("SELECT 1 FROM FoodDetail WHERE BillingID = @BillingID AND FoodID = @FoodID", new object[] { billingID, foodID }))
                        .Returns(null);

            // Act
            bool result = foodDAL.FoodDetailsExist(billingID, foodID);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SaveFoodDetails_ValidData_ExecutesNonQuery()
        {
            // Arrange
            int billingID = 1;
            int foodID = 1;
            int count = 4;

            mockDatabase.Setup(db => db.ExecuteNonQuery("Exec ProcFoodDetailINIT @BillingID , @FoodID , @Count ", new object[] { billingID, foodID, count }))
                        .Verifiable();

            // Act
            foodDAL.SaveFoodDetails(billingID, foodID, count);

            // Assert
            mockDatabase.Verify();
        }

        [TestMethod]
        public void UpdateFoodDetails_ValidData_ExecutesNonQuery()
        {
            // Arrange
            int billingID = 1;
            int foodID = 1;
            int count = 10;

            mockDatabase.Setup(db => db.ExecuteNonQuery("Update FoodDetail set count = @count where billingid = @BillingID and foodid = @FoodID ", new object[] { count, billingID, foodID }))
                        .Verifiable();

            // Act
            foodDAL.UpdateFoodDetails(billingID, foodID, count);

            // Assert
            mockDatabase.Verify();
        }
    }
    [TestClass]
    public class ComputerDALTests
    {
        private Mock<IDatabase> mockDatabase;
        private DataTable mockDataTable;

        [TestInitialize]
        public void Setup()
        {
            // Thiết lập mock Database và DataTable
            mockDatabase = new Mock<IDatabase>();
            mockDataTable = new DataTable();
            mockDataTable.Columns.Add("computerid", typeof(int));
            mockDataTable.Columns.Add("computername", typeof(string));
            mockDataTable.Columns.Add("computerstatus", typeof(byte));

            // Thêm các hàng vào mock DataTable
            mockDataTable.Rows.Add(1, "Máy 01", 1);
            mockDataTable.Rows.Add(2, "Máy 02", 0);

            // Thiết lập mock ExecuteQuery trả về mock DataTable
            mockDatabase.Setup(db => db.ExecuteQuery(It.IsAny<string>())).Returns(mockDataTable);
            Database.SetInstance(mockDatabase.Object);
        }

        [TestMethod]
        public void LoadFullCom_ShouldReturnListOfComputers()
        {
            // Arrange
            var computerDAL = ComputerDAL.Instance;

            // Act
            List<Computer> computers = computerDAL.LoadFullCom();

            // Assert
            Assert.AreEqual(40, computers.Count);
            Assert.AreEqual(1, computers[0].comId);
            Assert.AreEqual("Máy 01", computers[0].comName);
            Assert.AreEqual(1, computers[0].comStatus);
        }

        [TestMethod]
        public void GetComs_ShouldReturnDataTable()
        {
            // Arrange
            var computerDAL = ComputerDAL.Instance;

            // Act
            DataTable result = computerDAL.GetComs(1);

            // Assert
            Assert.AreEqual(2, result.Rows.Count);
            Assert.AreEqual(1, result.Rows[0]["ComputerID"]);
            Assert.AreEqual("Máy 01", result.Rows[0]["ComputerName"]);
        }
    }

}
