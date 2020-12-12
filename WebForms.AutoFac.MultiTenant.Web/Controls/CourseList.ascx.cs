using Autofac.Integration.Web.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms.AutoFac.MultiTenant.Core.Repositories;

namespace WebForms.AutoFac.MultiTenant.Web.Controls
{
    [InjectProperties]
    public partial class CourseList : System.Web.UI.UserControl
    {
        public ICourseRepository _courseRepository { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            courseGrid.DataSource = _courseRepository.List().ToList();
            courseGrid.DataBind();
        }
    }
}