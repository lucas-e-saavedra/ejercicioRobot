using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DALRobot
{
    public class BitacoraRobot
    {
        private readonly static BitacoraRobot _instance = new BitacoraRobot();
        public static BitacoraRobot Current {
            get{
                return _instance;
            }
        }

        private BitacoraRobot()
        {
            //Implent here the initialization of your singleton
        }

        private BinaryFormatter serializador = new BinaryFormatter();
        private string rutaArchivo = ConfigurationManager.AppSettings["archivoHistorial"];
        private Stream AbrirArchivoHistorial(FileMode pModo, FileAccess pAcceso)
        {
            return new FileStream(rutaArchivo, pModo, pAcceso);
        }
        public void Grabar(object objetoAPersistir)
        {
            using (Stream datos = AbrirArchivoHistorial(FileMode.Append, FileAccess.Write))
            {
                this.serializador.Serialize(datos, objetoAPersistir);
                datos.Close();
            }
        }

        public List<object> ListarTodos()
        {
            List<object> items = new List<object>();
            Stream flujo = AbrirArchivoHistorial(FileMode.Open, FileAccess.Read);
            while (flujo.Position < flujo.Length)
            {
                object unObjeto = this.serializador.Deserialize(flujo);
                items.Add(unObjeto);
            }
            flujo.Close();
            return items;
        }

        public List<T> ListarSegunFiltroFecha<T>(string propertyName, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<T> items = new List<T>();
            Stream flujo = AbrirArchivoHistorial(FileMode.Open, FileAccess.Read);
            while (flujo.Position < flujo.Length)
            {
                object unObjeto = this.serializador.Deserialize(flujo);
                Type tipoObjeto = unObjeto.GetType();
                FieldInfo selectedProperty = tipoObjeto.GetFields().FirstOrDefault(propertyInfo => propertyInfo.Name == propertyName);
                if (typeof(T).Name == unObjeto.GetType().Name && selectedProperty != null 
                    && selectedProperty.FieldType.Name == "DateTime") {
                    DateTime eventDate = (DateTime)selectedProperty.GetValue(unObjeto);
                    if (eventDate > fechaDesde && eventDate < fechaHasta)
                    {
                        items.Add((T)unObjeto);
                    }
                }
            }
            flujo.Close();
            return items;
        }
    }
}
