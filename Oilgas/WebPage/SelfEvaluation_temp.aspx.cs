﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebPage_SelfEvaluation_temp : System.Web.UI.Page
{
	public string identity;
	protected void Page_Load(object sender, EventArgs e)
	{
		if (LogInfo.mGuid != "")
			identity = LogInfo.competence;
		else
			Response.Write("<script>alert('請重新登入'); location='SignIn.aspx';</script>");
	}
}