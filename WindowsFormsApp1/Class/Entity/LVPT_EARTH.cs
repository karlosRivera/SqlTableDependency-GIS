//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GIS.Class
{
    using System;
    using System.Collections.Generic;
    
    public partial class LVPT_EARTH
    {
        public int OBJECTID { get; set; }
        public Nullable<int> CityNID { get; set; }
        public Nullable<int> HyperNID { get; set; }
        public Nullable<int> HeaderNID { get; set; }
        public string HPLID { get; set; }
        public string HDLID { get; set; }
        public Nullable<int> Kind { get; set; }
        public Nullable<int> ElectrodKind { get; set; }
        public Nullable<int> ExecYear { get; set; }
        public Nullable<int> ExecWay { get; set; }
        public Nullable<decimal> Deep { get; set; }
        public Nullable<decimal> Resistance { get; set; }
        public string MeasureDate { get; set; }
        public Nullable<decimal> x { get; set; }
        public Nullable<decimal> y { get; set; }
        public Nullable<int> U_ID { get; set; }
        public string U_Date { get; set; }
        public string U_Time { get; set; }
        public string VerID { get; set; }
        public Nullable<decimal> Angel { get; set; }
        public string GUID { get; set; }
        public string FeederName { get; set; }
        public System.Data.Entity.Spatial.DbGeometry SHAPE { get; set; }
        public Nullable<int> Design { get; set; }
        public string created_user { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string last_edited_user { get; set; }
        public Nullable<System.DateTime> last_edited_date { get; set; }
    }
}
