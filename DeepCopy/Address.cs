namespace DeepCopy
{
    public class Address
    {
        public string AddressValue { get; set; }

        public Address GetClone()
        {
            return (Address) MemberwiseClone();
        }
    }
}