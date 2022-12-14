using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRPP
{
    public class MedicoEgresado : Medico
    {
        #region ATRIBUTOS
        protected DateTime _horarioSalida;
        #endregion

        #region CONTRUCTORES
        public MedicoEgresado(Medico medico): base (medico.Apellido, medico.Legajo, medico.Ingreso, medico.EspecialidadMedico)
        {
            this._horarioSalida = DateTime.Now;
        }
        #endregion

        #region PROPIEDADES
        public DateTime Egreso { get => this._horarioSalida; }

        public double Jornal { get => this.CalcularJornal(); }
        public override string Info()
        {
            return base.ToString();
        }
        #endregion

        #region SOBRECARGA DE METODOS
        public override string ToString()
        {
            return this.ArmarInfo() + " ingreso: " + this.Ingreso.ToLongDateString() + " hs. - egreso: " + this.Egreso.ToLongDateString();
        }
        #endregion

        #region METODOS
        protected override string ArmarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.Info());
            sb.Append(" - JORNAL: " + this.Jornal);

            return sb.ToString();
        }

        private double CalcularJornal()
        {
            double jornal = 0;

            TimeSpan diff = base.Ingreso - this.Egreso;

            if(base.EspecialidadMedico == Especialidad.Cirujano)
            {
                jornal = diff.TotalSeconds * 90;

            }else if(base.EspecialidadMedico == Especialidad.Clinico)
            {
                jornal = diff.TotalSeconds * 70;
            }
            else
            {
                jornal = diff.TotalSeconds * 40;
            }

            return jornal;
        }
        #endregion
    }
}
