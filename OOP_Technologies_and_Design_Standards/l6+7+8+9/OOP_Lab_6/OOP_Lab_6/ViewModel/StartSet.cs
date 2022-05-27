using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_6.Model
{
    class StartSet
    {
        public static IEnumerable<TShirt> GetSet()
        {
            return new TShirt[]
            {
                new TShirt
                {
                    modelName = "Black Yellow",
                    modelID = "#01",
                    shortDescription = "T-Shirt",
                    fullDescription = "T-Shirt, that has been made with cotton, latex and love",
                    price = 22.40,
                    availability = true,
                    sale = 0,
                    sold = 12,
                    inStock = 25,
                    src = "D:\\ExtendedData\\Laboratory\\ООТПиСП\\l6+7+8+9\\OOP_Lab_6\\Images\\Black_Yellow.jpg"
                },
                new TShirt
                {
                   modelName = "Black White",
                    modelID = "#02",
                    shortDescription = "T-Shirt",
                    fullDescription = "T-Shirt, that has been made with cotton and confidence",
                    price = 29.49,
                    availability = true,
                    sale = 0,
                    sold = 10,
                    inStock = 12,
                    src = "D:\\ExtendedData\\Laboratory\\ООТПиСП\\l6+7+8+9\\OOP_Lab_6\\Images\\Black_White.jpg"
                },
                new TShirt
                {
                    modelName = "Black Blue",
                    modelID = "#03",
                    shortDescription = "T-Shirt",
                    fullDescription = "T-Shirt, that has been made with latex and sports",
                    price = 49.99,
                    availability = true,
                    sale = 12,
                    sold = 3,
                    inStock = 16,
                    src = "D:\\ExtendedData\\Laboratory\\ООТПиСП\\l6+7+8+9\\OOP_Lab_6\\Images\\Black_Blue.jpg"
                }
            };
        }
    }
}
