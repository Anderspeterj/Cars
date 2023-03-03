namespace Cars
{
    public class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public double Price { get; set; }
        public string? LicensePlate { get; set; }


        public void ValidateId()
        {
            if (Id < 0)
            {
                throw new ArgumentOutOfRangeException("Id cant be lower than 0" + Id);
            }
        }

        public void ValidateModel()
        {
            if (Model.Length <= 4)
            {
                throw new ArgumentException("Model must be atleast 5 char long" + Model);
            }
        }

        public void ValidatePrice()
        {
            if (Price < 0)
            {
                throw new ArgumentException("Price Cant be negative" + Price);

            }
        }

        public void ValidateLicensePlate()
        {
            if (LicensePlate.Length <= 2 || LicensePlate.Length >= 7)
            {
                throw new ArgumentException("LicensePlate must be numbers/chars between" + LicensePlate);
            }
        }
    }
}