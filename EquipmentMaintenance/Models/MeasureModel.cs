using System;

namespace EquipmentMaintenance
{
    public class MeasureModel
    {
        public DateTime DateTime { get { return DateTime.MinValue.AddMinutes(this.Minutes); } }

        public double Minutes { get; set; }

        public double Value { get; set; }
    }
}