using System.Collections;
namespace AgendaContactos
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //declaro e instancio la clase Contacto
            Contacto javier = new Contacto("JAvier", "Perez", "15-4432-5543");
            Contacto flavia = new Contacto("Flavia", "Diaz", "15-9922-0023");
            Contacto pablo = new Contacto("Pablo", "Solario", "15-3321-4532");
            Contacto angel = new Contacto("Angel","Fernandez", "15-2311-0098");
            Contacto ana = new Contacto("Ana Maria", "Diaz", "15-4328-8556");
            
            //declaro clase agenda
            Agenda misContactos = new Agenda();
            
            misContactos.agregarContacto(javier);
            misContactos.agregarContacto(flavia);
            misContactos.agregarContacto(pablo);
            misContactos.agregarContacto(angel);
            misContactos.agregarContacto(ana);

            misContactos.mostrarContactos();

            Console.WriteLine("Ingrese el apellido del contacto que busca: ");
            string apellido = Console.ReadLine();

            misContactos.buscarContacto(apellido);            

        }
    }
    class Contacto
    {
        //agrego campo apellido para poder buscar un contacto a partir del mismo
        private string nombre;
        private string apellido;
        private string telefono;

        //metodo constructor
        public Contacto(string nombre, string apellido, string telefono)
        {
            this.nombre = nombre;            
            this.apellido = apellido;
            this.telefono = telefono;
        }
        //propiedades
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
        public string Apellido
        {
            set
            {
                apellido = value;
            }
            get
            {
                return apellido;
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

        //metodo para agregar contactos a lista vacia
        public void agregarContacto(Contacto contacto)
        {
            lista_contactos.Add(contacto);
        }
        //metodo que recorre la lista e imprime uno por uno los contactos
        public void mostrarContactos()
        {
            foreach (Contacto contacto in lista_contactos)
            {
                Console.WriteLine($"{contacto.Nombre} {contacto.Apellido} {contacto.Telefono}");
            }
        }
        //metodo para buscar contactos a partir del campo apellido
        public void buscarContacto(string apellido)
        {
            foreach(Contacto contacto in lista_contactos)
            {
                if (contacto.Apellido.ToUpper() == apellido.ToUpper())
                {
                    Console.WriteLine($"{contacto.Nombre} {contacto.Apellido}----------{contacto.Telefono}");
                }

            }
        }
    }
        
}
//Buscar un contacto
//eliminar contacto
//Editar contacto
//email sea unico