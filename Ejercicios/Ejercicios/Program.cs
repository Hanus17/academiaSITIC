using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string courseName = "Academia SITIC";
            string courseName2 = "Academia SITIC 2";

            int studentsCount = 28;
            bool isStartingNow = true;

            int? age = null;
            age = 28;

            //Solucion 1
            Console.WriteLine(age != null ? age : 0);

            //Solucion 2
            if (age != null)
                Console.WriteLine(age);
            else
                Console.WriteLine(0);

            //Solucion 3
            Console.WriteLine(age.GetValueOrDefault());
            Console.WriteLine("Tu edad es de: " + age);
            Console.ReadKey();
            Employer emp = new();


        }

        public class User
        {
            private string _name;

            //Forma corta
            public int IdUser { get; set; }

            //Forma media
            private string _password;

            public string Password
            {
                get
                {
                    return _password;
                }
                set
                {
                    _password = value;
                }
            }

            //Forma larga
            public string GetName()
            {
                return _name;
            }

            public string SetName(string name)
            {
                _name = name;
            }
        }

        public class User2
        {
            private int _idUser;
            private string _name;
            private string _password;

            public string Password { get => _password; set => _password = value; }
        }

        public class Person
        {
            public int PersonId { get; set; }
        }

        public int Employed:Person()
        {

        }
     
    }
}
