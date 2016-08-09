using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class clockRadio
    {
        string color;
        string station;
        bool isOn;
        int percentageVolumne = 0;
        public clockRadio(string Color, bool IsOn, int PercentageVolumne)
        {
            color = Color;
            isOn = IsOn;
            percentageVolumne = PercentageVolumne;
        }

        public void On(){
            isOn = true;
        }
        public int TurnUp(){
            return percentageVolumne += 5;
        }
    }
}

clockRadio theFish = new clockRadio("brown", true, 50);