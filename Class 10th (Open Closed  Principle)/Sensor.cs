
    internal class Sensor
    {
        public void Detect(Product product)
        {
            Console.WriteLine("It has been detected");
            Console.WriteLine();
            product.Describe();
        }
    }

