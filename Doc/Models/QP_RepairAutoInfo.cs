using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_RepairAutoInfo
    {
        public string TypeID { get; set; }
        public string ParID { get; set; }
        public int Leveal { get; set; }
        public int SonCount { get; set; }
        public int SonNum { get; set; }
        public string PlateNumber { get; set; }
        public string EngineNumber { get; set; }
        public string BTypeID { get; set; }
        public string RepairAutoTypeID { get; set; }
        public string FrameNumber { get; set; }
        public string TransmissionNumber { get; set; }
        public string VIN { get; set; }
        public string Color { get; set; }
        public Nullable<System.DateTime> RecordDate { get; set; }
        public Nullable<System.DateTime> ForceMaintainDate { get; set; }
        public string ForceMaintainMileage { get; set; }
        public Nullable<System.DateTime> FirstMaintainDate { get; set; }
        public string FirstMaintainMileage { get; set; }
        public string Comment { get; set; }
        public string LeaveFactoryNum { get; set; }
        public Nullable<System.DateTime> LeaveFactoryDate { get; set; }
        public string Driver { get; set; }
        public string DriverMobilePhone { get; set; }
        public string CardNumber { get; set; }
        public int ChargingStandardsID { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public string PYCode { get; set; }
        public string BaoxianBtypeid { get; set; }
    }
}
