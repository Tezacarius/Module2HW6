namespace Module2HW6.Models.CarWithoutTrunk
{
    public abstract class CarWithoutTrunk : Car
    {
        public CarWithoutTrunk()
        {
            HasTrunk = false;
        }
    }
}
