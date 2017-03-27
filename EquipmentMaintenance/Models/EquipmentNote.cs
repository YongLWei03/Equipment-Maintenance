using System;

namespace EquipmentMaintenance
{
    public class EquipmentNote
    {
        public DateTime? Pro1 { get; internal set; }
        public string Pro1Text { get { return this.Pro1.HasValue ? this.Pro1.Value.ToString("yyyy/MM/dd HH:mm") : ":"; } } 
        public string Pro2 { get; internal set; }
    }
}