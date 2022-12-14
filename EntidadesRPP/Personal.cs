using System;
using System.Text;

namespace EntidadesRPP
{
    public abstract class Personal
    {
        #region ATRIBUTOS
        protected string _apellido;
        protected DateTime _horarioEntrada;
        protected int _legajo;
        #endregion

        #region CONSTRUCTOR
        public Personal(string apellido, int legajo) 
        {
            this._apellido = apellido;
            this._legajo = legajo;
            this._horarioEntrada = DateTime.Now;
        }

        public Personal(string apellido, int legajo, DateTime ingreso)
        {
            this._apellido = apellido;
            this._legajo = legajo;
            this._horarioEntrada = ingreso;
        }
        #endregion

        #region PROPIEDADES
        public string Apellido { get => this._apellido; }
        public DateTime Ingreso { get => this._horarioEntrada; }
        public int Legajo { get => this._legajo;  }
        public abstract string Info();
        #endregion

        #region SOBRECARGA DE METODOS
        public override string ToString()
        {
            return this.ArmarInfo() + " ingreso: " + this.Ingreso.ToLongDateString() + " hs";
        }
        public override bool Equals(object obj)
        {
            bool ok = false;
            if (obj is Personal)
            {
                if (this == ((Personal)obj))
                {
                    ok = true;
                }
            }
            return ok;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(Personal p1, Personal p2)
        {
            return p1.Apellido == p2.Apellido && p1.Legajo == p2.Legajo;
        }
        public static bool operator !=(Personal p1, Personal p2)
        {
            return !(p1.Apellido == p2.Apellido && p1.Legajo == p2.Legajo);
        }
        
        public static explicit operator string(Personal p1)
        {
            string legajo;

            legajo = "" + p1.Legajo;

            return legajo;
        }
        #endregion

        #region METODOS
        protected virtual string ArmarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this._apellido);
            sb.Append(", Legajo: " + this._legajo);

            return sb.ToString();
        }

        /*
        public int OrdenarPorLegajoASC(Personal p1, Personal p2)
        {
            
        }

        public int OrdenarPorLegajoDESC(Personal p1, Personal p2)
        {

        }
        */
        #endregion
    }
}
