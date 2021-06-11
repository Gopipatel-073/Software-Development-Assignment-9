namespace EmployeeSearch
{
    public class Employee
    {
        public bool IsNew { get; set; } = true;

        private float? id;
        public float? Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string position;
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        private decimal? hourlyPay;
        public decimal? HourlyPay
        {
            get { return hourlyPay; }
            set { hourlyPay = value; }
        }
    }
}
