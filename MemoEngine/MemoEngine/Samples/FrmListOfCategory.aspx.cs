using System;
using System.Web.UI;
using MemoEngine.Models; 

namespace MemoEngine.Samples
{
    public partial class FrmListOfCategory : System.Web.UI.Page
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
            var categoryRepository = new CategoryRepositoryInMemory();

            this.ctlCategoryList.DataSource = categoryRepository.GetCategories();
            this.ctlCategoryList.DataBind();
        }
    }
}
