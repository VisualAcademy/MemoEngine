using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemoEngine.Demos.WebForms
{
    public partial class FrmGridViewWithRadioButtonCheckedChanged : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            List<Province> provinces = new List<Province>()
            {
                new Province { Id = 1, Name = "서울" },
                new Province { Id = 2, Name = "인천" },
                new Province { Id = 3, Name = "대전" }
            };
            ctlSelectWeather.DataSource = provinces;
            ctlSelectWeather.DataBind(); 
        }

        protected void optId_CheckedChanged(object sender, EventArgs e)
        {
            string id = "";
            // 전체 라디오버튼 선택 해제
            foreach (GridViewRow row in ctlSelectWeather.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    RadioButton opt = (row.FindControl("optId") as RadioButton);
                    opt.Checked = false;
                }
            }

            // 현재 체크 이벤트를 발생시킨 라디오버튼만 체크
            RadioButton current = sender as RadioButton;
            current.Checked = true;
            foreach (GridViewRow row in ctlSelectWeather.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    RadioButton opt = (row.FindControl("optId") as RadioButton);
                    if (opt.Checked)
                    {
                        HiddenField hidden = row.FindControl("hdnId") as HiddenField;
                        id = hidden.Value; 
                    }
                }
            }

            lblId.Text = id; 
        }
    }

    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}