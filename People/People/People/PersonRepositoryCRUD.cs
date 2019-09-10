using People.Models;
using SQLite;


namespace People
{
    public class PersonRepositoryCRUD
    {
        SQLiteConnection conn;

        //conn=new SqliteConnection
        public string StatusMessage { get; set; }

        //Constructor
        public PersonRepositoryCRUD(string dbPath)
        {
            // Creamos la conexión
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Person>();

            /*PersonRepositoryCRUD Repo = 
              new PersonRepositoryCRUD ("c\EL\datos");*/

        }

        //CRUD OPERATION o métodos
        //CREAR
        public void CreatePerson(Person newPerson)
        {
            int result = 0;
            result = conn.Insert(newPerson);
            if (result == 1)
            {

                StatusMessage =
                        $"{result} registro agregado [Nombre:" +
                        $"{newPerson.Name}, ID:{newPerson.Id}]";
            }
            else
            {
                StatusMessage =
                    "¡Registro no insertado!";
            }
        }
    }
}
