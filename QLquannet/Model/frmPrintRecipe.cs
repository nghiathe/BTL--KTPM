using DAL;
using System;
using System.Data;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QLquannet.Model
{
    public partial class frmPrintRecipe : Form
    {

        private PrintRecipeDAL prDAL;
        public frmPrintRecipe()
        {

            prDAL = new PrintRecipeDAL();
            InitializeComponent();
            LoadBillingData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadBillingData()
        {
            DataTable billingData = prDAL.GetAllBillings();
            dgvBilling.DataSource = billingData;
        }

        private void btnPrintRecipe_Click(object sender, EventArgs e)
        {

            if (dgvBilling.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DataGridViewRow selectedRow = dgvBilling.SelectedRows[0];
            int billingID = Convert.ToInt32(selectedRow.Cells["BillingID"].Value.ToString());


            DataTable billingInfo = prDAL.GetBillingInfo(billingID);

            DataTable foodDetails = prDAL.GetFoodDetails(billingID);


            if (billingInfo.Rows.Count == 0)
            {
                MessageBox.Show("No data found for the selected BillingID.");
                return;
            }

            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];


            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "6MA Cyber";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Đống Đa - Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0338962222";

            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3;
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN";


            DataRow row = billingInfo.Rows[0];
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = row["BillingID"].ToString();
            exRange.Range["C6:E6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["B7:B7"].Value = "Ngày lập:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = Convert.ToDateTime(row["BillingDate"]).ToString("dd/MM/yyyy");
            exRange.Range["C7:E7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["B8:B8"].Value = "Nhân viên:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = row["LastName"].ToString();
            exRange.Range["C8:E8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;

            exRange.Range["B10:F10"].Font.Bold = true;
            exRange.Range["B10:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B10:F11"].Borders.LineStyle = COMExcel.XlLineStyle.xlContinuous;
            exRange.Range["C10:F10"].ColumnWidth = 12;
            exRange.Range["B10:B10"].Value = "Mã máy tính";
            exRange.Range["C10:C10"].Value = "Zone";
            exRange.Range["D10:D10"].Value = "Đơn giá/ h";
            exRange.Range["E10:E10"].Value = "Thời gian";
            exRange.Range["F10:F10"].Value = "Thành tiền";



            exSheet.Cells[2][11] = billingInfo.Rows[0]["ComputerID"].ToString();
            exSheet.Cells[3][11] = billingInfo.Rows[0]["ZoneName"].ToString();
            exSheet.Cells[4][11] = billingInfo.Rows[0]["PricePerHour"].ToString();
            exSheet.Cells[5][11] = billingInfo.Rows[0]["Duration"].ToString();
            exSheet.Cells[6][11] = billingInfo.Rows[0]["Cost"].ToString();

            exRange.Range["B13:F13"].Font.Bold = true;
            exRange.Range["B13:F13"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C13:F13"].ColumnWidth = 12;
            exRange.Range["B13:B13"].Value = "STT";
            exRange.Range["C13:C13"].Value = "Tên món";
            exRange.Range["D13:D13"].Value = "Số lượng";
            exRange.Range["E13:E13"].Value = "Đơn giá";
            exRange.Range["F13:F13"].Value = "Thành tiền";

            for (int i = 0; i < foodDetails.Rows.Count; i++)
            {
                exSheet.Cells[2][i + 14, 1] = i + 1;
                exSheet.Cells[2][i + 14, 2] = foodDetails.Rows[i]["FoodName"].ToString(); // Tên món
                exSheet.Cells[2][i + 14, 3] = foodDetails.Rows[i]["Count"].ToString(); // Số lượng
                exSheet.Cells[2][i + 14, 4] = foodDetails.Rows[i]["Price"].ToString(); // Đơn giá
                exSheet.Cells[2][i + 14, 5] = foodDetails.Rows[i]["Cost"].ToString(); // Thành tiền

            }
            int totalRowIndex = foodDetails.Rows.Count + 14;
            exSheet.Cells[totalRowIndex, 5] = "Tổng tiền:";
            exSheet.Cells[totalRowIndex, 5].Font.Bold = true;
            exSheet.Cells[totalRowIndex, 6] = billingInfo.Rows[0]["Amount"].ToString();
            exSheet.Cells[totalRowIndex, 6].Font.Bold = true;

            int employeeSignatureRowIndex = totalRowIndex + 3;
            exSheet.Cells[employeeSignatureRowIndex, 6] = "Nhân viên:";
            exSheet.Cells[employeeSignatureRowIndex + 1, 6] = ""; // Leave space for signature
            exSheet.Cells[employeeSignatureRowIndex + 2, 6] = billingInfo.Rows[0]["LastName"].ToString(); // Replace "Tên nhân viên" with actual employee name

            exRange = exSheet.Range["B13", "F" + (13 + foodDetails.Rows.Count)];
            exRange.Borders.LineStyle = COMExcel.XlLineStyle.xlContinuous;

            exRange.HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            exRange = exSheet.Range["A1", "G" + (employeeSignatureRowIndex + 7)];
            exRange.Borders[COMExcel.XlBordersIndex.xlEdgeLeft].LineStyle = COMExcel.XlLineStyle.xlContinuous;
            exRange.Borders[COMExcel.XlBordersIndex.xlEdgeRight].LineStyle = COMExcel.XlLineStyle.xlContinuous;
            exRange.Borders[COMExcel.XlBordersIndex.xlEdgeTop].LineStyle = COMExcel.XlLineStyle.xlContinuous;
            exRange.Borders[COMExcel.XlBordersIndex.xlEdgeBottom].LineStyle = COMExcel.XlLineStyle.xlContinuous;

            exApp.Visible = true;

        }
    }
}
