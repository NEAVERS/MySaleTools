using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_DeliveryAddress
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string TelPhone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public Nullable<int> CreatorId { get; set; }
        public string CreatorName { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifierId { get; set; }
        public string ModifierName { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public Nullable<bool> IsDefault { get; set; }
    }
}
