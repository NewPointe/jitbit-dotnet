
namespace NewPointe.JitBit.Structures
{

    public class Asset
    {
        public dynamic Tickets { get; set; } // null,
        public User[] AssignedUsers { get; set; } // [],
        public CustomFieldValue[] Fields { get; set; } // [],
        public dynamic Attachments { get; set; } // null,
        public dynamic LogEntries { get; set; } // null,
        public int ItemID { get; set; } // 240758,
        public string Manufacturer { get; set; } // "Apple",
        public string Supplier { get; set; } // "Apple Inc.",
        public string ModelName { get; set; } // "15\" Macbook Pro (2017)",
        public int? TypeID { get; set; } // 0,
        public string Type { get; set; } // "Laptop",
        public int? ManufacturerID { get; set; } // 0,
        public int? SupplierID { get; set; } // 0,
        public string SerialNumber { get; set; } // "C02V6004J925",
        public string Location { get; set; } // "Central Services",
        public string Comments { get; set; } // null,
        public int Quantity { get; set; } // 1,
        public int TicketCount { get; set; } // 0,
        public string Company { get; set; } // "NewPointe Community Church",
        public int? CompanyID { get; set; } // 1085702,
        public bool Disabled { get; set; } // false
    }

}