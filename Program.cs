using System.Collections;
namespace AgendaContactos
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            
            Contacto javier = new Contacto("JAvier Perez", "15-4432-5543");
            Contacto flavia = new Contacto("Flavia Diaz", "15-9922-0023");
            Contacto pablo = new Contacto("Pablo Solario", "15-3321-4532");
            Contacto prueba = new Contacto("Fernanadez", "15-2311-0098");
            
            
            Agenda misContactos = new Agenda();
            
            misContactos.agregarContacto(javier);
            misContactos.agregarContacto(flavia);
            misContactos.agregarContacto(pablo);
            misContactos.agregarContacto(prueba);

            misContactos.mostrarContactos();

            Console.WriteLine("Ingrese el apellido del contacto que busca: ");
            string apellido = Console.ReadLine();

            misContactos.buscarContacto(apellido);
            

        }
    }
    class Contacto
    {
        private string nombre;
        private string telefono;

        public Contacto(string nombre, string telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public string Telefono
        {
            set
            {
                telefono = value;
            }
            get
            {
                return telefono;
            }
        }





    }
    class Agenda
    {
        private ArrayList lista_contactos = new ArrayList();

        

        public void agregarContacto(Contacto contacto)
        {
            lista_contactos.Add(contacto);
        }
        
        public void mostrarContactos()
        {
            foreach (Contacto contacto in lista_contactos)
            {
                Console.WriteLine(contacto.Nombre +  "  " + contacto.Telefono);
            }
        }

        public void buscarContacto(string apellido)
        {
            foreach(Contacto contacto in lista_contactos)
            {
                if (contacto.Nombre == apellido)
                {
                    Console.WriteLine(contacto.Nombre + "   " + contacto.Telefono);
                }

            }
        }
    }
        
}
//Buscar un contacto
//eliminar contacto
//Editar contacto
//email sea unico