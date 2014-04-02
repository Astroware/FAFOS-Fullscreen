using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAFOS.Inspection
{
    public class Report
    {
        private String serviceAddress;
        private List<Extinguisher> extRep;
        private List<Hose> hoseRep;
        private List<Lights> lightsRep;

        public Report(String SA)
        {
            serviceAddress = SA;
            extRep = new List<Extinguisher>();
            hoseRep = new List<Hose>();
            lightsRep = new List<Lights>();
        }

        public String getSA()
        {
            return serviceAddress;
        }

        public List<Extinguisher> getExtRep()
        {
            return extRep;
        }

        public List<Hose> getHoseRep()
        {
            return hoseRep;
        }

        public List<Lights> getLightsRep()
        {
            return lightsRep;
        }
    }
}
