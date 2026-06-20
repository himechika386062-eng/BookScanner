using Postgrest.Attributes;
using Postgrest.Models;

namespace BarcodeAlertApp
{
    [Table("barcodes")]
    public class BarcodeModel : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("code")]
        public string Code { get; set; } = "";

        [Column("title")]
        public string Title { get; set; } = "";

        [Column("author")]
        public string Author { get; set; } = "";

        [Column("publisher")]
        public string Publisher { get; set; } = "";

        [Column("pubdate")]
        public string PubDate { get; set; } = "";
    }
}