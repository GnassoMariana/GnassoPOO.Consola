using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnassoPOO.Entidades
{
    public class Cono
    {
        public double Altura { get; private set; }
        public double RadioGiro { get; private set; }
        public double Generatriz { get; private set; }

        public Cono(double altura, double radio)
        {
            Altura = ValidarAltura(altura);
            RadioGiro = ValidarRadio(radio);
            Generatriz = GetGeneratriz(radio, altura);
            
        }

        private double ValidarRadio(double radio)
        {
            if (radio <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return radio;
            }
        }

        private double ValidarAltura(double altura)
        {
            if (altura <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return altura;
            }
        }

        public double GetArea(double radio, double generatriz)
        {
            return Math.PI * radio * (generatriz + radio);
        }

        public double GetVolumen(double altura, double radio)
        {
            return (Math.PI * Math.Pow(radio, 2) * altura) / 3;
        }

        public double GetGeneratriz(double radio, double altura)
        {
            return Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(radio, 2));
        }

        public override string ToString()
        {
            return $" La generatriz del cono es: {Generatriz}" +
                 $"   Su altura: {Altura}" +
                 $"   Su radio de giro: {RadioGiro}";

        }

    }
}
