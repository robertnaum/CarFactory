namespace Common.Manufacturers
{
    public abstract class Manufacturer
    {
        public string Name { get; }


        protected abstract int SecondsToManufacturer { get; set;}

        protected Manufacturer(string name)
        {
            Name = name;
        }
    }
}
