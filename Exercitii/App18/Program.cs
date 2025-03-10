namespace App18
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IRepository<DateTime>repository1 = new Repository<DateTime>();
            repository1.Add(DateTime.Now);
            Caine dog = new Caine();
            int valoareInt = 5;
            float valoareFloat = 10.01f;
            bool valoareBool = false;
            UtilityClass.Output<int>(valoareInt);
            UtilityClass.Output<Caine>(dog);
            UtilityClass.Output(dog);
            UtilityClass.Output2(valoareInt, dog, valoareBool);
            UtilityClass.OutputCaine(new Caine());
            UtilityClass.OutputString("cacacel");
            Console.WriteLine(UtilityClass.ReturnItem<int>());
            Caine dog2 = UtilityClass.ReturnItem<Caine>();
            Console.WriteLine("dog2: " + dog2);
            Caine dog3 =  UtilityClass.ReturnItemCaine<Akita>();
            Caine dog4 = UtilityClass.ReturnItemCaine<Caine>();
            Caine dog5 = UtilityClass.ReturnItemCaine<Chiuahua>();
            Console.WriteLine(dog3);
            Console.WriteLine(dog4);
            Console.WriteLine(dog5);
            Application18 app = new();
            IRepository<string> repository = new Repository();
            repository.Add("caciulita mica");
            repository.Add("Hello!");
            ((IDsiplayCollection)repository).Display();
            //if (repository is IDisplayCollection dc) dc.Display();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(app.Cerinta);
            Console.ForegroundColor = ConsoleColor.White;
            app.Launch();
        }
    }

    interface IRepository<T>
    {
        void Add(T item);
    }

    class Repository<T> : IRepository<T>
    {
        private List <T> _repo = new List <T>();
        public void Add(T item)
        {
            _repo.Add(item);
        }
    }

    interface IDsiplayCollection
    {
        void Display();
    }

    class Repository : IRepository<string>, IDsiplayCollection
    {
        private List<string> _repo = new List<string>();
        public void Add(string item)
        {
            _repo.Add(item);
        }

        public void Display() 
        {
            for (int i = 0; i < _repo.Count; i++) 
            { 
                Console.WriteLine(_repo[i]);
            }
        }

    }
}

