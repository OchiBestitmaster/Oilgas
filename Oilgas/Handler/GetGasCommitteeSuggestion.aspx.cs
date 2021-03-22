﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Xml;

public partial class Handler_GasCommitteeSuggestion : System.Web.UI.Page
{
    GasCommitteeSuggestion_DB gcs_db = new GasCommitteeSuggestion_DB();
    OilCommitteeSuggestion_DB ocs_db = new OilCommitteeSuggestion_DB();
    protected void Page_Load(object sender, EventArgs e)
    {
        ///-----------------------------------------------------
        ///功    能: 取得天然氣自評表委員意見log列表
        ///說    明:
        /// * Request["qid"]: 題目Guid
        /// * Request["type"]: 網站類別
        ///-----------------------------------------------------

        XmlDocument xDoc = new XmlDocument();
        try
        {
            //string SearchStr = (string.IsNullOrEmpty(Request["SearchStr"])) ? "" : Request["SearchStr"].ToString().Trim();
            string qid = (string.IsNullOrEmpty(Request["qid"])) ? "" : Request["qid"].ToString().Trim();
            string type = (string.IsNullOrEmpty(Request["type"])) ? "" : Request["type"].ToString().Trim();
            string xmlstr = string.Empty;
            DataTable dt = new DataTable();

            if(type == "gas")
            {
                gcs_db._題目guid = qid;
                gcs_db._業者guid = LogInfo.companyGuid;
                gcs_db._年度 = "110";

                //db._KeyWord = SearchStr;
                dt = gcs_db.GetList();
                xmlstr = DataTableToXml.ConvertDatatableToXML(dt, "dataList", "data_item");
                xmlstr = "<?xml version='1.0' encoding='utf-8'?><root>" + xmlstr + "</root>";
                xDoc.LoadXml(xmlstr);
            }
            else
            {
                ocs_db._題目guid = qid;
                ocs_db._業者guid = LogInfo.companyGuid;
                ocs_db._年度 = "110";

                //db._KeyWord = SearchStr;
                dt = ocs_db.GetList();
                xmlstr = DataTableToXml.ConvertDatatableToXML(dt, "dataList", "data_item");
                xmlstr = "<?xml version='1.0' encoding='utf-8'?><root>" + xmlstr + "</root>";
                xDoc.LoadXml(xmlstr);
            }
        }
        catch (Exception ex)
        {
            xDoc = ExceptionUtil.GetExceptionDocument(ex);
        }
        Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Xml;
        xDoc.Save(Response.Output);
    }
}