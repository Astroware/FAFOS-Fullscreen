using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAFOS.Inspection
{
    class Report
    {
        private String serviceAddress;
        private ExtinguisherReport extRep;
        private HoseReport hoseRep;
        private LightsReport lightsRep;

        public Report(String SA)
        {
            serviceAddress = SA;
            extRep = new ExtinguisherReport();
            hoseRep = new HoseReport();
            lightsRep = new LightsReport();
        }

        public String getSA()
        {
            return serviceAddress;
        }

        public ExtinguisherReport getExtRep()
        {
            return extRep;
        }

        public HoseReport getHoseRep()
        {
            return hoseRep;
        }

        public LightsReport getLightsRep()
        {
            return lightsRep;
        }
    }
}
