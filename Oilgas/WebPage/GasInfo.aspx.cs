using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebPage_GasInfo : System.Web.UI.Page
{
	public string username;
	protected void Page_Load(object sender, EventArgs e)
	{
		if (LogInfo.mGuid == "")
			Response.Write("<script>alert('請重新登入'); location='SignIn.aspx';</script>");
		else
		{
			username = LogInfo.name;

			string nowCompany = LogInfo.companyGuid;

            if (LogInfo.competence != "02")
            {
                //if (string.IsNullOrEmpty(Request["cp"]))
                //	Response.Write("<script>alert('參數錯誤!'); location='GasCompanyList.aspx';</script>");
                //else
                //{
                //	// for 3/16
                //	if (Request["cp"].ToString().Trim() == "A11B680E-4A42-45E0-BCE2-3B16679C0606")
                //                {

                //                }
                //                else if(Request["cp"].ToString().Trim() == "FE80EC82-2F88-4FBD-A136-D5E9D3233CD9")
                //                {
                //                    Response.Redirect("~/DemoHtml/gas-firmB001.html");
                //                }
                //                else
                //                {
                //                    Response.Redirect("~/DemoHtml/gas-firmTemplate001.html");
                //                }						
                //}		

                //if (nowCompany == "FE80EC82-2F88-4FBD-A136-D5E9D3233CD9")
                //{
                //    Response.Redirect("~/DemoHtml/gas-firmB001.html");
                //}
                //else if (nowCompany == "A11B680E-4A42-45E0-BCE2-3B16679C0606")
                //{

                //}
                //else
                //{
                //    Response.Redirect("~/DemoHtml/gas-firmTemplate001.html");
                //}                
            }
		}
	}
}