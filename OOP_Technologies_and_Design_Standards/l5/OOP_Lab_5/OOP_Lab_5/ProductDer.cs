namespace OOP_Lab_4
{
    public class PrDec : IProduct
    {
        protected readonly IProduct Component;
        public PrDec(IProduct component)
        {
            Component = component;
        }
        public virtual string name
        {
            get { return Component.name; }
            set { Component.name = value; }
        }
        public virtual string id
        {
            get { return Component.id; }
            set { Component.id = value; }
        }
        public virtual string Show()
        {
            return Component.Show();
        }
    }
}
