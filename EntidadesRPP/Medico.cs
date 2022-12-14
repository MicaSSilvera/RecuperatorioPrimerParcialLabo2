using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRPP
{
    public class Medico : Personal
    {
        #region ATRIBUTOS
        protected Especialidad _especialidadMedico;
        #endregion

        #region CONTRUCTORES
        public Medico(string apellido, int legajo, DateTime ingreso, Especialidad especialidad): base(apellido, legajo, ingreso)
        {
            this._especialidadMedico = especialidad;
        }
        #endregion

        #region PROPIEDADES
        public Especialidad EspecialidadMedico { get => this._especialidadMedico; }

        public override string Info()
        {
            return base.ArmarInfo();
        }
        #endregion

        #region SOBRECARGA DE METODOS
        public override string ToString()
        {
            return this.ArmarInfo() + " ingreso: " + this.Ingreso.ToLongDateString() + " hs";
        }   
        #endregion

        #region METODOS
        protected override string ArmarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Doctor - " + this.Info());
            sb.Append(", Especialidad: " + this._especialidadMedico);

            return sb.ToString();
        }
        #endregion
        
    }
}
