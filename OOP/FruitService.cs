namespace OOP
{
    public class FruitService
    {
        private List<Fruit> _fruits = new List<Fruit>();
        public Action<string, int> create;
        public Action<int> delete;
        public Action getAll;
        public Action<int> get;
        public FruitService()
        {
            create = (name, id) =>
            {
                var fruit = new Fruit()
                {
                    Id = id,
                    Name = name
                };
                _fruits.Add(fruit);
            };

            delete = (id) =>
            {
                var fruit = _fruits.FirstOrDefault(x => x.Id == id);
                if (fruit == null) Console.Write("Fruit was not found");
                _fruits.Remove(fruit);
            };

            getAll = () =>
            {
                foreach (var fruit in _fruits)
                {
                    Console.WriteLine($"{fruit.Id} - {fruit.Name}");
                }
            };

            get = (id) =>
            {
                var fruit = _fruits.FirstOrDefault(x => x.Id == id);
                if (fruit == null) Console.Write("Fruit was not found");
                Console.WriteLine($"{fruit.Id} - {fruit.Name}");
            };
        }
    }
}
