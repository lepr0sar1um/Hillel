using System;
 
namespace Paymants
{
    class Program
    {
        static void Main(string[] args)
        {
            using(UserContext db = new UserContext())
            {
                // создаем два объекта User
                User user1 = new User { firstName = "Ivan", secondName = "Eremenko" };
 
                // добавляем их в бд
                db.Users.Add(user1);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");
 
                // получаем объекты из бд и выводим на консоль
                var users = db.Users;
                Console.WriteLine("Список объектов:");
                foreach(User u in users)
                {
                    Console.WriteLine("{0}.{1}.{2}", u.id, u.firstName, u.secondName);
                }
            }
            Console.Read();
        }
    }
}