namespace FinancieraCore2020.Dominio.Entidades
{
    /// <summary>
    /// Entidad de dominio que representa al Cliente
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Identificador único del cliente
        /// </summary>
        public int IdCliente { get; private set; }
        /// <summary>
        /// Nombre completo del cliente
        /// </summary>
        public string NombreCliente { get; private set; }
        
        /// <summary>
        /// Permite registrar a un nuevo cliente
        /// </summary>
        /// <param name="_nombre">Nombre completo del cliente</param>
        /// <returns>Instancia nueva de la clase Cliente</returns>
        public static Cliente Registrar(string _nombre)
        {
            return new Cliente(){
                NombreCliente = _nombre
            };
        }
        /// <summary>
        /// Permite modificar el nombre del cliente
        /// </summary>
        /// <param name="_nombre"></param>
        public void ModificarNombre(string _nombre)
        {
            NombreCliente = _nombre;
        }
    
    }
}