namespace InheritanceDemoCSharp
{
    //Parent - Base
    class Electrical_Device
    {
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }

        public Electrical_Device(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }
    }
}
