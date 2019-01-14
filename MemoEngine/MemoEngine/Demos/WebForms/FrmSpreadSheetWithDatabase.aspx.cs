using MemoEngine.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace MemoEngine.Demos.WebForms
{
    public partial class FrmSpreadSheetWithDatabase : System.Web.UI.Page
    {
        private readonly UserPriceDataRepository _repository;

        public int ProjectId { get; set; } = 1;
        public string Labels { get; private set; }
        public string UserPrices { get; private set; }
        public string StandardPrices { get; private set; }

        public FrmSpreadSheetWithDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _repository = new UserPriceDataRepository(connectionString);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request["ProjectId"]))
            {
                txtProjectId.Text = Request["ProjectId"];
                ProjectId = Convert.ToInt32(Request["ProjectId"]); 
            }
            else
            {
                txtProjectId.Text = "-1";
                ProjectId = -1;
            }

            if (!Page.IsPostBack)
            {
                기준단가가져오기();
                DisplayInitialData();
            }
        }

        private void DisplayInitialData()
        {
            var datas = GetEmptyDatas();

            // 빈 데이터 컬렉션에 기존 DB에 저장된 데이터로 변경 
            for (int i = 0; i < datas.Count; i++)
            {
                var dbData = _repository.GetByCondition(datas[i]);
                if (dbData != null)
                {
                    datas[i].StandardPrice = dbData.StandardPrice;
                    datas[i].UserPrice = dbData.UserPrice;

                }
            }

            ctlTwentyYears.DataSource = datas;
            ctlTwentyYears.DataBind();

            PrintChartData(datas);
        }

        private void PrintChartData(List<UserPriceData> datas)
        {
            Labels = string.Join(",", datas.Select(d => d.Num).ToArray()); 
            UserPrices = string.Join(",", datas.Select(d => d.UserPrice).ToArray());
            StandardPrices = string.Join(",", datas.Select(d => d.StandardPrice).ToArray());
        }

        private void 기준단가가져오기()
        {
            txtStardPrice.Text = 1234.ToString();
        }

        List<UserPriceData> GetEmptyDatas()
        {
            List<UserPriceData> twenty = new List<UserPriceData>();
            for (int i = 0; i < 21; i++)
            {
                int now = i + DateTime.Now.Year;
                twenty.Add(new UserPriceData { Num = i, Year = now, StandardPrice = 0, UserPrice = 0, ProjectId = ProjectId });
            }
            return twenty; 
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtStardPrice.Text, out var standardPrice))
            {

            }
            else
            {
                standardPrice = 0; 
            }

            List<UserPriceData> twenty = new List<UserPriceData>();
            for (int i = 0; i < 21; i++)
            {
                int now = i + DateTime.Now.Year; 
                twenty.Add(new UserPriceData { Num = i, Year = now, StandardPrice = standardPrice, UserPrice = 0 }); 
            }

            ctlTwentyYears.DataSource = twenty;
            ctlTwentyYears.DataBind(); 
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string[] userPrices = Request.Form.GetValues("txtUserPrice");
            string[] standardPrices = Request.Form.GetValues("txtStandardPrice");
            string[] numbers = Request.Form.GetValues("hdnNum");
            string[] years = Request.Form.GetValues("hdnYear");

            List<UserPriceData> twenty = new List<UserPriceData>();
            for (int i = 0; i < 21; i++)
            {
                if (double.TryParse(userPrices[i], out var userPrice))
                {

                }
                else
                {
                    userPrice = 0;
                }
                if (int.TryParse(numbers[i], out var index))
                {

                }
                else
                {
                    index = 0;
                }
                if (double.TryParse(standardPrices[i], out var standardPrice))
                {

                }
                else
                {
                    standardPrice = 0;
                }
                if (int.TryParse(years[i], out var year))
                {

                }
                else
                {
                    year = 0;
                }

                twenty.Add(new UserPriceData { Num = index, Year = year, StandardPrice = standardPrice, UserPrice = userPrice, ProjectId = ProjectId });
            }

            _repository.AddOrUpdate(twenty);

            // 현재 페이지 다시 로드
            Response.Redirect(Request.RawUrl); 
        }
    }
}
