namespace WebApp_HW_13.Models
{
    public class QureryModelLibrary
    {
        public int id { get; set; }
        public string LibraryName { get; set; }
        public string LibraryCity { get; set; }
        public string LibraryAddress { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Writer { get; set; }
        public int CountBook { get; set; }
        public string MemberName { get; internal set; }
        public int MemberCodemeli { get; internal set; }
        public string MemberTel { get; internal set; }
    }
}
