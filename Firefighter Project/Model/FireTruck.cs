//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Firefighter_Project.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class FireTruck
    {
        public int FiretruckId { get; set; }
        public bool IsOnShift { get; set; }
        public int YearlyWorkHours { get; set; }
        public int IncidentNumber { get; set; }
        public System.TimeSpan MinIncidentDuration { get; set; }
        public System.TimeSpan MaxIncidentDuration { get; set; }
        public int LitersOfWaterUsed { get; set; }
        public int FireFighterId { get; set; }
    
        public virtual FireFighter FireFighter { get; set; }
    }
}
