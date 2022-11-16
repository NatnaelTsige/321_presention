namespace InClassEX
{
    public class Car
    {
        public string brand;
        public string model;
        public int year;
        public double MSRPPrice;
        public string LoanAgreement;
        public double salesTax = 0.104;
        public double DestinationCharg = 2000;
        public double titleFee = 75;
        public double DocumantionFee = 550;
        public double DSRU = 20000;

        public Car(string brand, string model, int year, int MSRPPrice)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.MSRPPrice = MSRPPrice;
        }

        public double CalculateSales(Car car) 
        {
            return car.salesTax * car.MSRPPrice;
        }

        public double CaclulateOTP(Car car) 
        {
            return car.MSRPPrice + (car.MSRPPrice * salesTax) + car.DestinationCharg + car.DocumantionFee
                + car.DSRU + car.titleFee;
        }

        public void printLoanAgreement() 
        {
            Console.WriteLine("Loan Agreement");

        }

        public void printOTP(Car car) 
        {
            double OTP = car.CaclulateOTP(car);
            Console.WriteLine("The out the door price is " + OTP);
        }

        public void mailLoanAgreement(Car car) 
        {
            File.WriteAllText("Agreement.txt", car.LoanAgreement);
            File.WriteAllText("Price.txt", car.LoanAgreement);
        }

    }
}