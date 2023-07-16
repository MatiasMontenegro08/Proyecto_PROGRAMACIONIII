using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class VentaNegocio
    {
        public List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("SELECT Id, Fecha, Detalle, Total FROM Ventas;");
                conectar.ejecutarLectura();

                while (conectar.Lector.Read())
                {
                    Venta temporal = new Venta();
                    temporal.Id = (int)conectar.Lector["Id"];
                    temporal.Fecha = (string)conectar.Lector["Fecha"];
                    temporal.Detalle = (string)conectar.Lector["Detalle"];
                    temporal.Monto = (decimal)conectar.Lector["Total"];

                    lista.Add(temporal);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarFijo(int registro)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("DELETE FROM Ventas WHERE Id = @id");
                conectar.setearParametro("@id", registro);
                conectar.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conectar.cerrarConexion();
            }
        }
        public void Agregar(Venta nuevo)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("INSERT INTO Ventas (Fecha, Detalle, Total) VALUES (@Fecha, @Detalle, @Total);");
                conectar.setearParametro("@Fecha", nuevo.Fecha);
                conectar.setearParametro("@Detalle", nuevo.Detalle);
                conectar.setearParametro("@Total", nuevo.Monto);
                conectar.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conectar.cerrarConexion();
            }
        }
        public void Modificar(Venta selecionado)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("UPDATE Ventas SET Fecha = @Fecha, Detalle = @Detalle, Total = @Total WHERE Id = @Id;");
                conectar.setearParametro("@Fecha", selecionado.Fecha);
                conectar.setearParametro("@Detalle", selecionado.Detalle);
                conectar.setearParametro("@Total", selecionado.Monto);
                conectar.setearParametro("@Id", selecionado.Id);
                conectar.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conectar.cerrarConexion();
            }
        }
        public decimal ObtenerTotal()
        {
            AccesoDato conectar = new AccesoDato();
            decimal total = 0;
            try
            {
                conectar.setearConsulta("SELECT COALESCE(SUM(Total), 0) AS Total FROM Ventas;");
                conectar.ejecutarLectura();

                while (conectar.Lector.Read())
                {
                    IngEgr temporal = new IngEgr();
                    temporal.Total = (decimal)conectar.Lector["Total"];
                    total += temporal.Total;
                }
                return total;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Venta> FiltroDesdeHasta(string fecha1, string fecha2)
        {
            AccesoDato conectar = new AccesoDato();
            List<Venta> filtro = new List<Venta>();
            try
            {
                string f1 = fecha1, f2 = fecha2;
                conectar.setearConsulta("SELECT Id, Fecha, Detalle, Total FROM Ventas WHERE CONVERT(date, Fecha, 103) BETWEEN @Fecha1 AND @Fecha2;");
                conectar.setearParametro("@Fecha1", f1);
                conectar.setearParametro("@Fecha2", f2);
                conectar.ejecutarLectura();
                while (conectar.Lector.Read())
                {
                    Venta temporal = new Venta();
                    temporal.Id = (int)conectar.Lector["Id"];
                    temporal.Fecha = (string)conectar.Lector["Fecha"];
                    temporal.Detalle = (string)conectar.Lector["Detalle"];
                    temporal.Monto = (decimal)conectar.Lector["Total"];
                    filtro.Add(temporal);
                }
                return filtro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
