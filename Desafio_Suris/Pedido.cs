using System.Text.RegularExpressions;

namespace Desafio_Suris
{
    public class Pedido
    {
        public float precio { get; set; }

        public List<Articulo> articulos { get; set; } = new List<Articulo>();

        public string estado { get; set; } = string.Empty;

        public string descripcion { get; set; } = string.Empty;

        public Pedido(List<Articulo> articulos)
        {
            this.articulos = articulos;
            this.Validar();
        }

        public void Validar()
        {
            validarArticulos();
        }

        public void validarArticulos()
        {
            var specialChars = new Regex (@"\|!#$%&/()=?»«@£§€{}.-;'<>_,");
            foreach (var articulo in articulos)
            {
                precio += articulo.precio;
                if(articulo.deposito != 1)
                {
                    this.estado = "No Valido";
                    this.descripcion = "No se permite la carga de articulos no pertenecientes al desposito 1";
                    return;
                }
                else
                {
                    if (specialChars.IsMatch(articulo.descripcion))
                    {
                        this.estado = "No Valido";
                        this.descripcion = "La descripcion del articulo " + articulo.descripcion + " posee caracteres no validos";
                        return;
                    }
                    else
                    {
                        this.estado = "Valido";
                        this.descripcion = "Todas las validaciones han sido correctas";
                    }
                }
            }
            if(this.precio == 0)
            {
                this.estado = "No Valido";
                this.descripcion = "El precio de compra no puede ser 0";
                return;
            }

        }
    }
}
