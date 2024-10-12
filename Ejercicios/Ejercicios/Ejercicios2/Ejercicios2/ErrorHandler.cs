using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class ErrorHandler
    {

        #region Propierties
        private static List<User> UserList { get; set; } = GetUsers();
        #endregion

        #region Variables
        private const int MIN_AGE = 10;
        private const int MAX_AGE = 100;
        #endregion

        #region Classes
        public class User
        {
            #region Propierties
            public int UserId { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            #endregion

            #region Constructors
            public User() { }

            public User(int userId, string userName, string password) 
            {
                UserId = userId;
                Username = userName;
                Password = password;
            }

            public User(string userName, string password)
            {
                Username = userName;
                Password = password;
            }
            #endregion
            

        }

        public class CustomAppException : Exception
        {
            private eErrorTipo ErrorResponseEx { get; set; } = eErrorTipo.Ninguno;

            public CustomAppException() : base() { }

            public CustomAppException(string message, eErrorTipo error) : base(message) 
            {
                ErrorResponseEx = error;
            }

        }

        public enum eErrorTipo
        {
            Ninguno = 0,
            Validacion,
            Conexion,
            InformacionDuplicada,
            Auntenticacion,
            Desconocido = 99
        }
        #endregion

        private static List<User> GetUsers()
        {
            return new()
            {
                new(1, "admin", "admin"),
                new(2, "sa", "12345"),
                new(2, "johndoe", "contraseña"),
                new(2, "miguelon", "2933737")
            };
        }

        public static void Main(string[] args)
        {
            const string username = "Pavel";
            const string password = "admin";
            Console.ReadKey();
        }



        public static int RegisterUserWithoutValidations(string username, string password, string ageInput)
        {
            int userId, age;
            Console.WriteLine("Conexion a la base de datos");
            Console.WriteLine("Abrimos transiccion");

            age = Convert.ToInt32(ageInput);

            Console.WriteLine("Ejecutamos la conexion en la base de datos");

            if (!IsExistingUser(username))
                InsertUser(new(username, password));

            return 0;
        }

        public static void RegistrerUserWithValidations(string username, string password, string ageInput)
        {
            Console.WriteLine("Iniciamos el proceso de registro de clientes");

            try
            {
                Console.WriteLine("Abrimos transacción");
                int age = Convert.ToInt32(ageInput);

                age = Convert.ToInt32(ageInput);

                Console.WriteLine("Ejecutamos la conexion en la base de datos");

                if (!IsExistingUser(username))
                    InsertUser(new(username, password));

                Console.WriteLine("Confirmo los datos");
            }
            catch(CustomAppException ex)
            {   
                Console.WriteLine(ex.Message);
                Console.WriteLine("Rollback");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Rollback");
            }

        }

        private static int ValidateAge(string ageInput)
        {
            if (!int.TryParse(ageInput, out int age))
               throw new CustomAppException("La edad viene en un formato incorrecto.", eErrorTipo.Validacion);

            if (age < MIN_AGE || age > MAX_AGE)
                throw new CustomAppException("La edad viene en un formato incorrecto.", eErrorTipo.Validacion);

            return age;
        }

        public static bool IsExistingUser(string username)
        {
            return UserList != null & UserList.Any(user => user.Username == username);
        }

        public static bool InsertUser(User user)
        {
            user.UserId = UserList != null ? (UserList.Max(user => user.UserId) + 1) : 1;

            if(UserList == null)
                UserList = new();

            UserList.Add(user);
            


            #region Comment
            
            #endregion
            
                
            UserList.Add(user);
            Console.WriteLine("Acción ejecutada en base de datos => Usuario insertsdo exitosamente");
            return true;

        }
    }
}
