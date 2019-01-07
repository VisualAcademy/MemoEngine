using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemoEngine.Demos.WebForms
{
    public partial class FrmDropDownListCascading : System.Web.UI.Page
    {
        private readonly ElectricityPlanRepositoryInMemory _repository;

        public FrmDropDownListCascading()
        {
            _repository = new ElectricityPlanRepositoryInMemory();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            bool isSaved = false;

            if (isSaved)
            {
                // 저장된 데이터를 읽어오기 

            }
            else
            {
                // 처음 로드할 때 드롭다운리스트 기본 값 설정하기 
                if (!Page.IsPostBack)
                {
                    // 전기 용도 선택
                    ReadElectricUses();
                    // 요금 유형 선택
                    ddlElectricUses_SelectedIndexChanged(null, null);
                    // 세부 요금 선택
                    ddlRateType_SelectedIndexChanged(null, null);
                }
            }
        }

        private void ReadElectricUses()
        {
            var electricUsesItems = _repository.GetElectricUses();
            
            ddlElectricUses.DataSource = electricUsesItems;
            ddlElectricUses.DataTextField = "Key";
            ddlElectricUses.DataValueField = "Value";
            ddlElectricUses.DataBind();
        }

        protected void ddlElectricUses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ddlElectricUses.SelectedValue; 
            if (selectedValue == ElectricUsesType.Home.ToFriendlyString())
            {
                // 주택용(Home)
                BindRateType(ElectricUsesType.Home, selectedValue);
                // 세부 요금 선택 드롭다운리스트가 필요없음
                //ddlRateDetails.Visible = false; 
            }
            else
            {
                // 산업용(Industry)
                BindRateType(ElectricUsesType.Industry, selectedValue);
                ddlRateDetails.Visible = true;
            }

            ddlRateType_SelectedIndexChanged(null, null); // 3단계 드롭다운리스트 업데이트 
        }

        /// <summary>
        /// 요금 유형 선택 드롭다운리스트 표시 및 선태
        /// </summary>
        private void BindRateType(ElectricUsesType electricUsesType, string selectedValue = "")
        {
            this.ddlRateType.Items.Clear(); // 항목 초기화 
            switch (electricUsesType)
            {
                case ElectricUsesType.Home:

                    ddlRateDetails.Items.Clear(); 

                    // 수작업
                    //var homeItems = new ListItem[] { new ListItem("고압", "HighPressure"), new ListItem("저압", "LowPressure") } ;
                    //ddlRateType.Items.AddRange(homeItems); 
                    // 리포지토리 사용
                    var homeItems = _repository.GetRateTypeByElectricUses(ElectricUsesType.Home);
                    foreach (var item in homeItems)
                    {
                        ddlRateType.Items.Add(new ListItem { Text = item.Key, Value = item.Value });
                        ddlRateDetails.Items.Add(new ListItem { Text = item.Key, Value = item.Value });
                    }

                    break;
                case ElectricUsesType.Industry:
                    //var industryItems = new ListItem[] { new ListItem("갑", "HighPressure"), new ListItem("을", "LowPressure") };
                    //ddlRateType.Items.AddRange(industryItems);
                    var industryItem = _repository.GetRateTypeByElectricUses(ElectricUsesType.Industry);
                    ddlRateType.DataSource = industryItem;
                    ddlRateType.DataTextField = "Key";
                    ddlRateType.DataValueField = "Value";
                    ddlRateType.DataBind(); 
                    break;
                default:
                    break;
            }
        }

        protected void ddlRateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seletedRateType = ddlRateType.SelectedValue; 
            if (seletedRateType == RateTypeOption.First.ToFriendlyString())
            {
                ddlRateDetails.Items.Clear();

                var first = _repository.GetRateDetailsByRateType(RateTypeOption.First);
                ddlRateDetails.DataSource = first;
                ddlRateDetails.DataTextField = "Key";
                ddlRateDetails.DataValueField = "Value";
                ddlRateDetails.DataBind(); 
            }
            else if (seletedRateType == RateTypeOption.Second.ToFriendlyString())
            {
                ddlRateDetails.Items.Clear();

                var second = _repository.GetRateDetailsByRateType(RateTypeOption.Second);
                ddlRateDetails.DataSource = second;
                ddlRateDetails.DataTextField = "Key";
                ddlRateDetails.DataValueField = "Value";
                ddlRateDetails.DataBind();
            }
            else
            {
                // 주택용: 상세 드롭다운리스트는 요금 유형과 동일
                ddlRateDetails.SelectedValue = ddlRateType.SelectedValue; 
            }
        }

        protected void btnGetValueFromUserControl_Click(object sender, EventArgs e)
        {
            var electricityPlansUserControl = ElectricityPlansUserControl as UserControl;
            var ddlElectricUses = electricityPlansUserControl.FindControl("ddlElectricUses") as DropDownList;
            var ddlRateType = electricityPlansUserControl.FindControl("ddlRateType") as DropDownList;
            var ddlRateDetails = electricityPlansUserControl.FindControl("ddlRateDetails") as DropDownList;

            lblSelectedValue.Text = $"{ddlElectricUses.SelectedValue}, {ddlRateType.SelectedValue}, {ddlRateDetails.SelectedValue}";
            lblSelectedValue.Text += "<br />";
            lblSelectedValue.Text += 
                $"{ElectricityPlansUserControl.ElectricUses}, {ElectricityPlansUserControl.RateType}, {ElectricityPlansUserControl.RateDetails}";
        }
    }
}
