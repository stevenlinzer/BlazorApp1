using System.Text.Json;
namespace BlazorApp1.Components.Data
{
    
    public class ProductDescription
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string? Unit { get; set; }
        public string? Name { get; set; }

        public static List<ProductDescription> GetProductDescriptions()
        {
            string fileName = "products.json";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Components\\Data", fileName);
            List<ProductDescription> _products;

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                _products = JsonSerializer.Deserialize<List<ProductDescription>>(json) ?? new List<ProductDescription>();
            }
            else
            {
                System.Console.WriteLine("File not found " + path + ".");
                _products = new List<ProductDescription>();
            }
            return _products;
        }
    }
}
