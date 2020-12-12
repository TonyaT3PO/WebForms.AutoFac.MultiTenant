using Autofac.Integration.Web.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms.AutoFac.MultiTenant.Core.Repositories;

namespace WebForms.AutoFac.MultiTenant.Web
{
    [InjectProperties]
    public partial class _Default : Page
    {
        public ITenantRepository _tenantRepository { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            tenantsGrid.DataSource = _tenantRepository.List().ToList();
            tenantsGrid.DataBind();
        }
    }
}