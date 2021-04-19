namespace FinancieraCore2020.Dominio.Entidades
{
    /// <summary>
    /// Clase que representa 
    /// </summary>
    public class TipoMovimiento
    {
        /// <summary>
        /// Representa el identificador del tipo de movimiento
        /// </summary>
        public int IdTipo { get; private set; }
        /// <summary>
        /// Representa la descripcion del tipo de movimiento
        /// </summary>
        public string DescripcionTipo { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_descripcion"></param>
        /// <returns></returns>
        public static TipoMovimiento Registrar(string _descripcion)
        {
            return new TipoMovimiento(){
                DescripcionTipo = _descripcion
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_descripcion"></param>
        /// <returns></returns>
        public static TipoMovimiento Crear(int _id, string _descripcion)
        {
            return new TipoMovimiento(){
                IdTipo = _id,
                DescripcionTipo = _descripcion
            };
        }
    }
}