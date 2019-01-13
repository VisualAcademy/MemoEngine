using MemoEngine.Models;
using System;
using System.Configuration;

namespace MemoEngine
{
    public partial class DescriptionsUserControl : System.Web.UI.UserControl
    {
        private readonly IDescriptionRepository _repository;

        /// <summary>
        /// SiteName, SiteDescription, UserGuide
        /// </summary>
        public string FieldName { get; set; }
        
        public DescriptionsUserControl()
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
                if (FieldName == nameof(model.SiteName))
                {
                    strDisplay.Text = model.SiteName;
                }
                else if (FieldName == nameof(model.SiteDescription))
                {
                    strDisplay.Text = model.SiteDescription;
                }
                else if (FieldName == nameof(model.UserGuide))
                {
                    strDisplay.Text = model.UserGuide;
                }
                else
                {
                    strDisplay.Text = model.SiteName;
                }
            }
        }
    }
}
