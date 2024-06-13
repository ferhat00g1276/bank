class Program
{
    class Worker
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string position { get; set; }
        public double salary { get; set; }
        public DateOnly startTime { get; set; }
        public DateOnly endTime { get; set; }

    }
    interface IManager
    {
        void organize();
    }
    class Manager : Worker, IManager
    {
        void IManager.organize()
        {
            Console.WriteLine($"Manager {name} organizes");
        }
        void calculateSalaries()
        {
            Console.WriteLine($"Salaries got calculated by Manager {name}");
        }
    }
    class CEO : Manager, IManager
    {
        void IManager.organize()
        {
            Console.WriteLine($"CEO {name} organizes");
        }
        void Control()
        {
            Console.WriteLine($"CEO {name} controls");
        }
        void MakeMeeting()
        {
            Console.WriteLine($"CEO {name} makes meeting");
        }
        void DecreasePercentage(double percentage)
        {
            Console.WriteLine($"CEO {name} decreased percentage {percentage}");
        }
    }

    class Operation
    {
        public Guid ID { get; set; }
        public string processName { get; set; }
        public DateTime processDate { get; set; }

    }

    class Credit
    {
        public Guid ID { get; set; }
        public Client client { get; set; }
        public double amount { get; set; }
        public double percent { get; set; }
        public int months { get; set; }
        
        public double CalculatePercent() { return percent; }
        public void Payment(double paymentAmount) { amount -= paymentAmount; }
    }
    
    class Client
    {
        public Guid ID { get; set; }
        public string name { get; set; }
        public  string surname { get; set; }
        public int age { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public double salary { get; set; }
    }
    
    class Bank
    {
        public string bankName { get; set; }
        public double budget { get; set; }
        public double  profit { get; set; }
        public CEO BankCEO { get; set; }
        Worker[] workers;
        Manager[] managers;
        Client[] clients;
        void ShowClientCredit(string name, string surname)
        {
            foreach (Client client in clients)
            {
                if (client.name == name & client.surname == surname)
                {
                    Console.WriteLine($"{client.name} {client.surname} {client.age} {client.salary}$");
                } else { Console.WriteLine("Client not found"); }
            }
        }
        void PayCredit(Client client, double amount)
        {
            Console.WriteLine($"{client.name} {client.surname} paid {amount}$ of credit");
        }

        void ShowAllCredit() { Console.WriteLine("Credits"); }

    }
}