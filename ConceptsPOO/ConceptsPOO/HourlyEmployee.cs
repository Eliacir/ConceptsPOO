namespace ConceptsPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HouerValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HouerValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours................: {$"{Hours:N2}",18}" +
                $"\n\tHours Value..........: {$"{HouerValue:C2}",18}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
