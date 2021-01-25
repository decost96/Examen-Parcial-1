using System.Collections.Generic;

namespace PrimerParcial
{
    internal interface IAcciones
    {
        List<string> pasaje;
        internal void ComprarPasaje(Vuelo vuelo, int cantidad, string destino)
        {
            if (vuelo.AsientosLibres(destino) >= cantidad)
            {
                pasaje = vuelo.Descargar(destino, cantidad);
            }
        }
    }
}