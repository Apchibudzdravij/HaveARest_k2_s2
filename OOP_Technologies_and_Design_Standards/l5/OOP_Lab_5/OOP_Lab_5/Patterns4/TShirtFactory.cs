namespace OOP_Lab_4
{
    class TShirtFactory : IFactory
    {
        public Product CreateTShirt()
        {
            Storekeeper storekeeper = new Storekeeper("Ivan", 4, "ul.Pervaja, 14-2");
            return new Product(storekeeper);
        }
    }
}
