using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace MemoEngine.Demos.WebForms
{
    public partial class FrmExcelFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.csvFile.HasFile)
                {
                    Response.Write("<script>alert('업로드할 파일을 선택해 주세요.');</script>");
                    return;
                }

                // [!] 파일 업로드
                string rootpath = Server.MapPath("~/BoardFiles/Loads");
                string fullPath = Path.Combine(rootpath, this.csvFile.FileName);
                string name = Path.GetFileNameWithoutExtension(fullPath); 
                string ext = Path.GetExtension(fullPath);
                string newPath = Path.Combine(rootpath, $"{name}{Guid.NewGuid()}" + ext);
                this.csvFile.SaveAs(newPath);

                // [!] 업로드된 엑셀 파일 데이터 추출
                if (File.Exists(newPath))
                {
                    // [!] DocumentFormat.OpenXml.dll과 WindowsBase.dll 참조 추가 
                    using (SpreadsheetDocument document = SpreadsheetDocument.Open(newPath, false))
                    {
                        #region 공식과 같은 코드
                        WorkbookPart workbookPart = document.WorkbookPart;
                        SharedStringTablePart sstPart = workbookPart.GetPartsOfType<SharedStringTablePart>().First();
                        SharedStringTable sst = sstPart.SharedStringTable;

                        WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                        Worksheet sheet = worksheetPart.Worksheet;

                        var cells = sheet.Descendants<Cell>();
                        var rows = sheet.Descendants<Row>(); 
                        #endregion

                        DataTable table = new DataTable();
                        #region DataTable 컬럼 정의 
                        table.Columns.Add(new DataColumn("Id", System.Type.GetType("System.Int32")));
                        table.Columns.Add(new DataColumn("BuildingType", System.Type.GetType("System.String")));
                        table.Columns.Add(new DataColumn("HourNum", System.Type.GetType("System.Int32")));
                        table.Columns.Add(new DataColumn("Electricity", System.Type.GetType("System.Double")));
                        #endregion

                        #region DataTable 데이터 수집
                        foreach (Row row in rows.Skip(1))
                        {
                            DataRow tempRow = table.NewRow();

                            int i = 0;
                            foreach (Cell cell in row.Elements<Cell>())
                            {
                                if ((cell.DataType != null) && (cell.DataType == CellValues.SharedString))
                                {
                                    int ssid = int.Parse(cell.CellValue.Text);
                                    tempRow[i] = sst.ChildElements[ssid].InnerText;
                                }
                                else if (cell.CellValue != null)
                                {
                                    tempRow[i] = cell.CellValue.Text;
                                }
                                i++;
                            }

                            table.Rows.Add(tempRow);
                        }
                        #endregion

                        #region DataTable to List<Load>
                        List<Load> loads = new List<Load>();

                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow dr in table.Rows)
                            {
                                loads.Add(new Load
                                {
                                    Id = Convert.ToInt32(dr[0]),
                                    BuildingType = Convert.ToString(dr[1]),
                                    HourNum = Convert.ToInt32(dr[2]),
                                    Electricity = Convert.ToDouble(dr[3]),
                                });
                            }
                        } 
                        #endregion

                        GridView1.DataSource = loads;
                        GridView1.DataBind(); 
                    }
                }

                if (File.Exists(newPath))
                {
                    File.Delete(newPath); // 추출 완료된 엑셀 파일 제거 
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}
