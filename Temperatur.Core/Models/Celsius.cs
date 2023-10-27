
namespace Temperatur.Core.Models
{
    public class Celsius 
    {
        public double Degree { get; set; }
        public Celsius(double degree)
        {
            Degree= degree;
        }
        public static implicit operator Celsius(Kelvin kelvin)
        {
            return new Celsius(kelvin.Degree-273);
        }
    }
}
