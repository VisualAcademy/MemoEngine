using MemoEngine.Models;
using System;
using System.Configuration;

namespace MemoEngine
{
    /// <summary>
    /// .NET Standard 프로젝트와 ASP.NET 프로젝트에 System.Data.SqlClient.dll 파일 추가(Dul.dll, Dapper.dll)
    /// </summary>
    public partial class Descriptions : System.Web.UI.Page
    {
        private readonly IDescriptionRepository _repository;

        public Descriptions()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _repository = new DescriptionRepository(connectionString);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            var model = _repository.GetDescription();

            if (model != null)
            {
                txtSiteName.Text = model.SiteName;
                txtSiteDescription.Text = model.SiteDescription; 
                txtUserGuide.Text = model.UserGuide;
                // TODO: 추가되는 컬럼 정의 
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var model = new Description();
            model.SiteName = txtSiteName.Text;
            model.SiteDescription = txtSiteDescription.Text;
            model.UserGuide= txtUserGuide.Text;

            _repository.PostDescription(model);

            Response.Redirect(Request.RawUrl);
        }
    }
}
