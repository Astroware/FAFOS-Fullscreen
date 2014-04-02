using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAFOS.Inspection
{
    class Report
    {
        private String serviceAddress;
        private List<ExtinguisherReport> extRep;
        private List<HoseReport> hoseRep;
        private List<LightsReport> lightsRep;

        public Report(String SA)
        {
            serviceAddress = SA;
            extRep = new List<ExtinguisherReport>();
            hoseRep = new List<HoseReport>();
            lightsRep = new List<LightsReport>();
        }

        public String getSA()
        {
            return serviceAddress;
        }

        public List<ExtinguisherReport> getExtRep()
        {
            return extRep;
        }

        public List<HoseReport> getHoseRep()
        {
            return hoseRep;
        }

        public List<LightsReport> getLightsRep()
        {
            return lightsRep;
        }
    }
}
