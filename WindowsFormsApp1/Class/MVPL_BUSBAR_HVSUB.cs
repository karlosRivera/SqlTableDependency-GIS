using System;
public class MVPL_BUSBAR_HVSUB
{
    public int OBJECTID { get; set; }
    public int? CityNID { get; set; }
    public int? HyperNID { get; set; }
    public int? HeaderNID { get; set; }
    public int? Genus { get; set; }
    public int? Dimension { get; set; }
    public decimal? Voltage { get; set; }
    public int? Install_Year { get; set; }
    public decimal? Length { get; set; }
    public decimal? px { get; set; }
    public decimal? py { get; set; }
    public decimal? cx { get; set; }
    public decimal? cy { get; set; }
    public int? U_ID { get; set; }
    public string U_Date { get; set; }
    public string U_Time { get; set; }
    public string VerID { get; set; }
    public string GUID { get; set; }
    public string HVSUB_GUID { get; set; }
    public string FeederName { get; set; }
    public Microsoft.SqlServer.Types.SqlGeometry SHAPE { get; set; }
    public int? Design { get; set; }
    public string created_user { get; set; }
    public DateTime? created_date { get; set; }
    public string last_edited_user { get; set; }
    public DateTime? last_edited_date { get; set; }
}
