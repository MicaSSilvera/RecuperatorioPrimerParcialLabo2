using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRPP
{
    public class Hospital
    {
        #region ATRIBUTOS
        private string _nombre;
        private List<Personal> _personal;
        #endregion

        #region CONSTRUCTORES
        private Hospital() 
        {
            if(this._personal == null)
            {
                this._personal = new List<Personal>();
            }
        }

        private Hospital(string nombre) 
        {
            this._nombre = nombre;
        }
        #endregion

        #region PROPIEDADES
        public int CantidadPersonal()
        {
            return this._personal.Count;
        }
        #endregion

        #region SOBRECARGA DE METODOS
        public static Hospital operator +(Hospital h1, Personal p1)
        {
            if(h1._personal.IndexOf(p1) == -1)
            {
                h1._personal.Add(p1);
            }
            else
            {
                Console.WriteLine("El personal ya se encuentra en el hospital");
            }

            return h1;
        }
        public static Hospital operator -(Hospital h1, Personal p1)
        {
            if (h1._personal.IndexOf(p1) > -1)
            {
                int indice = h1._personal.IndexOf(p1);

                h1._personal.RemoveAt(indice);
            }
            else
            {
                Console.WriteLine("El personal no se encuentra en el hospital");
            }

            return h1;
        }
        #endregion

    }
}
