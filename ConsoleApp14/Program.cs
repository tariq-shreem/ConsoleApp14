namespace ConsoleApp14
{
    internal class Program
    {
        public enum Gender
        {
            Male, Female
        }
        public enum Role
        {
            Admin,User,Hr
        }
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Gender gender { get; set; }
            public Role role { get; set; }
        }
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            Console.WriteLine("Id : ");

           if(int.TryParse(Console.ReadLine(), out int id))
            {
                emp.Id = id;
           }else
            {
               Console.WriteLine("invalid id");
                return;
            }

            Console.WriteLine("Name : ");

            emp.Name = Console.ReadLine();

            Console.WriteLine("Gender :");

           if(Enum.TryParse(Console.ReadLine(),out Gender gender))
            {
                emp.gender  = gender;
            }else
            {
                Console.WriteLine("invalid Gender");
                return;
            }
            Console.WriteLine("Role :");


            if (Enum.TryParse(Console.ReadLine(), out Role role))
            {
                emp.role = role;
            }
            else
            {
                Console.WriteLine("invalid role");
                return;
            }


            Console.WriteLine($"{emp.Id} .. {emp.Name} ... {emp.gender}... {emp.role}");



        }
    }
}
