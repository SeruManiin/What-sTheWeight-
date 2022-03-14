using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesoEmOutrosPlanetas
{
    public class WeightTranslator
    {
        float oneNewton = 0.102f;
        public void HowMuchIWeightAt(float gravity, float weight)
        {
            float WeightAtOtherPlanet = ((oneNewton * gravity) * weight);
            Console.WriteLine("The Weight is " + WeightAtOtherPlanet + " Kilograms ");
        }
    }
}
