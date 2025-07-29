namespace ScribeX.BookStore.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; } = "";
        public string DOB { get; set; } = "";
        public DateTime DOJ { get; set; }
        public string Department { get; set; } = "";
    }
}
