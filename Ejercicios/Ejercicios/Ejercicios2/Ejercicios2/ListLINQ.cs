using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class ListLINQ
    {
        #region Classes
        public class People
        {
            #region Propierties
            public string Name { get; set; }

            public int Age { get; set; }

            public eGender Gender { get; set; } //Femenino(F) o masculino(M)
            #endregion

            #region Constructors
            public People() { }

            public People(string name, int age, eGender gender)
            {
                Name = name;
                Age = age;
                Gender = gender;
            }
            #endregion

            #region Methods
            public override string ToString()
            {
                return $"Nombre: {Name}, Edad: {Age}, Genero: {this.GetStringGender(Gender)}";
            }
            private string GetStringGender(eGender gender)
            {
                //string genderString;
                //if(gender ==eGender.Undefined)
                //{
                //    genderString = "";
                //}

                #region Switch lambda
                string genderString = gender switch
                {
                    eGender.Undefined => "Indefinido",
                    eGender.Female => "Mujer",
                    eGender.Male => "Hombre"
                };
                #endregion

                return genderString;
            }
            #endregion

        }
        #endregion


        #region Enums
        public enum eGender
        {
            Undefined,
            Female,
            Male
        }
        #endregion

        static void Main2(string[] args)
        {
            List<People> employeers = new()
            {
                new People
                {
                    Name = "Maria",
                    Age = 18,
                    Gender = eGender.Female
                },
                new People
                {
                    Name = "Luis",
                    Age = 20,
                    Gender = eGender.Male
                },
            };

            if (employeers != null)
            {
                employeers.Add(new("Ricardo", 33, eGender.Male));
                employeers.Add(new("Jazmin", 15, eGender.Female));
                employeers.Add(new("Vicente", 33, eGender.Male));
                employeers.Add(new("Luisa", 34, eGender.Female));
                employeers.Add(new("Jose", 68, eGender.Male));
            }

            List<People> students = new()
            {
                new("Iris", 23, eGender.Female),
                new("Jesus", 26, eGender.Male),
                new("Andrea", 33, eGender.Female),
                new("Paola", 22, eGender.Female),
                new("Christian", 22, eGender.Male),
            };

            #region Where
            //1: Filtrar nombres que comiencen con la letra 'A'
            Console.WriteLine("\nWHERE - Filtrar nomrbes que comiencen con al letra 'A'");
            List<People> filteredEmployeers = employeers.Where(employeer => employeer.Name.StartsWith("A")).ToList();
            WriteLine(filteredEmployeers);

            Console.WriteLine("\nWHERE - Filtrar empleador maoyroes a 30 años");
            filteredEmployeers = employeers.Where(employeers => employeers.Age > 30).ToList();
            foreach (People filteredEmployer in filteredEmployeers)
            {
                Console.WriteLine(filteredEmployeers.ToString());
            }
            #endregion

            #region Select
            Console.WriteLine("\nWHERE - Tomar el nombre(sirve para seleccionar una propipedad en especifico).");
            List<string> filteredEmployeersNames = employeers.Select(employeer => employeer.Name).ToList();
            foreach (string name in filteredEmployeersNames)
                Console.WriteLine(name);
            #endregion

            #region OrderBy & OrderByDescending
            Console.WriteLine("\nOrderBy - Ordenamiento por nombre vs la diferencia de la lista original");
            List<People> filteredStudents = students.OrderBy(student => student.Name).ToList();
            int i = 0;
            People originalStudent = null;
            foreach(var filteredStudent in filteredStudents)
            {
                originalStudent = students[i];
                Console.WriteLine($"{filteredStudent.Name} - {originalStudent.Name}");
                i++;
            }
            #endregion

            //#region OrderByDescending
            //Console.WriteLine("\nOrderByDescending - Ordenamiento por nombre vs la diferencia de la lista original");
            //var filteredStudents = students.OrderByDescending(student => student.Age).ToList();
            //#endregion

            #region GropuBy
            Console.WriteLine("\nGroupBy - Agrupamiento por género");
            var groupedByGender = students.GroupBy(student => student.Gender);
            foreach(var group in groupedByGender)
            {
                Console.WriteLine($"Genero (grupo):{group.Key}");
                foreach(var person in group)
                {
                    Console.WriteLine($"{person}");
                }
            }

            Console.WriteLine("\nGROUPBY - Agrupamiento por edades");
            var groupedByAge = employeers.GroupBy(employeer => employeer.Age);
            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"Edades (grupo): {group.Key} - Total: {group.Count()}");
                foreach (var person in group)
                {
                    Console.WriteLine($"{person.Name}");
                }
            }
            #endregion

            #region Any
            Console.WriteLine("\nAny - Verifica si hay valores o no dentro de la lista");
            Console.WriteLine($"Existen valores en 'employeers': {employeers.Any()}");
            Console.WriteLine($"Existen empleados mayores de 30: {employeers.Any(i => i.Age > 30)}");

            #endregion
            //foreach (People employeer in employeers)
            //{
            //    Console.WriteLine($"Nombre: {employeer.Name}");
            //}
        }

        private static void WriteLine(List<People> peopleList)
        {
            foreach (People people in peopleList)
            {
                Console.WriteLine(people.ToString());
            }
        }
    }
}
