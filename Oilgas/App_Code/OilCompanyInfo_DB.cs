using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

/// <summary>
/// OilCompanyInfo_DB 的摘要描述
/// </summary>
public class OilCompanyInfo_DB
{
	string KeyWord = string.Empty;
	public string _KeyWord { set { KeyWord = value; } }
	#region private
	string id = string.Empty;
	string guid = string.Empty;
	string 父層guid = string.Empty;
	int 排序編號;
	string 公司名稱 = string.Empty;
	string 處 = string.Empty;
	string 事業部 = string.Empty;
	string 營業處廠 = string.Empty;
	string 組 = string.Empty;
	string 中心庫區儲運課工場 = string.Empty;
	string 石油組織階層 = string.Empty;
	string 電話 = string.Empty;
	string 地址 = string.Empty;
	string 儲槽數量 = string.Empty;
	string 管線數量 = string.Empty;
	string 維運計畫書及成果報告 = string.Empty;
	string 曾執行過查核日期 = string.Empty;
	string 建立者 = string.Empty;
	DateTime 建立日期;
	string 修改者 = string.Empty;
	DateTime 修改日期;
	string 資料狀態 = string.Empty;
	#endregion
	#region public
	public string _id { set { id = value; } }
	public string _guid { set { guid = value; } }
	public string _父層guid { set { 父層guid = value; } }
	public int _排序編號 { set { 排序編號 = value; } }
	public string _公司名稱 { set { 公司名稱 = value; } }
	public string _處 { set { 處 = value; } }
	public string _事業部 { set { 事業部 = value; } }
	public string _營業處廠 { set { 營業處廠 = value; } }
	public string _組 { set { 組 = value; } }
	public string _中心庫區儲運課工場 { set { 中心庫區儲運課工場 = value; } }
	public string _石油組織階層 { set { 石油組織階層 = value; } }
	public string _電話 { set { 電話 = value; } }
	public string _地址 { set { 地址 = value; } }
	public string _儲槽數量 { set { 儲槽數量 = value; } }
	public string _管線數量 { set { 管線數量 = value; } }
	public string _維運計畫書及成果報告 { set { 維運計畫書及成果報告 = value; } }
	public string _曾執行過查核日期 { set { 曾執行過查核日期 = value; } }
	public string _建立者 { set { 建立者 = value; } }
	public DateTime _建立日期 { set { 建立日期 = value; } }
	public string _修改者 { set { 修改者 = value; } }
	public DateTime _修改日期 { set { 修改日期 = value; } }
	public string _資料狀態 { set { 資料狀態 = value; } }
	#endregion

	public DataTable GetInfo()
	{
		SqlCommand oCmd = new SqlCommand();
		oCmd.Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
		StringBuilder sb = new StringBuilder();

		sb.Append(@"select * from 石油_業者基本資料 where 資料狀態='A' and guid=@guid ");

		oCmd.CommandText = sb.ToString();
		oCmd.CommandType = CommandType.Text;
		SqlDataAdapter oda = new SqlDataAdapter(oCmd);
		DataTable ds = new DataTable();

		oCmd.Parameters.AddWithValue("@guid", guid);

		oda.Fill(ds);
		return ds;
	}

    //在列表點選檢視重新更新業者guid用
    public DataTable GetCompany()
    {
        HttpContext.Current.Session["companyGuid"] = null;
        HttpContext.Current.Session.Remove("companyGuid");
        SqlCommand oCmd = new SqlCommand();
        oCmd.Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        StringBuilder sb = new StringBuilder();

        sb.Append(@"select * from 石油_業者基本資料 where guid=@guid ");

        oCmd.CommandText = sb.ToString();
        oCmd.CommandType = CommandType.Text;
        SqlDataAdapter oda = new SqlDataAdapter(oCmd);
        DataTable ds = new DataTable();
        oCmd.Parameters.AddWithValue("@guid", guid);
        oda.Fill(ds);

        if (ds.Rows.Count > 0)
        {
            LogInfo.companyGuid = ds.Rows[0]["guid"].ToString();
        }

        return ds;
    }

    public DataTable GetCompanyList()
	{
		SqlCommand oCmd = new SqlCommand();
		oCmd.Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
		StringBuilder sb = new StringBuilder();

		sb.Append(@"select * from 石油_業者基本資料 where 列表是否顯示='Y' ");
        if (!string.IsNullOrEmpty(guid))
            sb.Append(@"and guid=@guid ");

		oCmd.CommandText = sb.ToString();
		oCmd.CommandType = CommandType.Text;
		SqlDataAdapter oda = new SqlDataAdapter(oCmd);
		DataTable ds = new DataTable();
        oCmd.Parameters.AddWithValue("@guid", guid);
        oda.Fill(ds);
		return ds;
	}
}