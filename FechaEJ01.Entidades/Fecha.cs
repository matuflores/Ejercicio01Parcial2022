using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaEJ01.Entidades
{
    public class Fecha
    {
        private int Dia;
        private int Mes;
        private int Anio;

        public Fecha(int dia, int mes, int anio)
        {
            this.Dia = dia;
            this.Mes = mes;
            this.Anio = anio;
        }

        public Fecha()
        {
            Dia = DateTime.Now.Day;
            Mes = DateTime.Now.Month;
            Anio = DateTime.Now.Year;
        }
        public bool Validar()
        {
            if (Dia > 0 && Mes >= 1 && Mes <= 12)
            {
                if (Mes == 1 || Mes == 3 || Mes == 5 || Mes == 7 || Mes == 8 || Mes == 10 || Mes == 12)
                {
                    return Dia <= 31;
                }

                if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
                {
                    return Dia <= 30;
                }
                if (Mes == 2)
                {
                    return Dia <= 29;
                }
            }
            return false;
        }


        public override string ToString()
        {
            return $"{Dia.ToString().PadLeft(2, '0')}/{Mes.ToString().PadLeft(2, '0')}/{Anio.ToString().PadLeft(4, '0')}";
        }

        
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Fecha))
            {
                return false;
            }

            return this.Dia == ((Fecha)obj).Dia &&
                   this.Mes == ((Fecha)obj).Mes &&
                   this.Anio == ((Fecha)obj).Anio;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Fecha f1, Fecha f2)
        {
            return f1.Equals(f2);
        }

        public static bool operator !=(Fecha f1, Fecha f2)
        {
            return !(f1 == f2);
        }

        public static implicit operator Fecha(string hoy)
        {
            int dia, mes, anio;
            var campos = hoy.Split('/');
            dia = int.Parse(campos[0]);
            mes = int.Parse(campos[1]);
            anio = int.Parse(campos[2]);

            return new Fecha(dia, mes, anio);
        }
    }
}
