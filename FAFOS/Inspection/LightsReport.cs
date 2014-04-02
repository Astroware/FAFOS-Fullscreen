using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAFOS.Inspection
{
    class LightsReport
    {
        private int equipID;
        private int model;
        private String location;
        private String voltage;
        private String totalPower;
        private int numHeads;
        private String make;

        private String reqServRepRslt;
        private String oprConfRslt;

        //may need to store the test notes as well

        //----------------------------------------------------------------------------------

        //SETS

        public LightsReport()
        {
        }

        public void setEquipID(int x)
        {
            equipID = x;
        }

        public void setModel(int x)
        {
            model = x;
        }

        public void setLocation(String x)
        {
            location = x;
        }

        public void setVoltage(String x)
        {
            voltage = x;
        }

        public void setPower(String x)
        {
            totalPower = x;
        }

        public void setNumHeads(int x)
        {
            numHeads = x;
        }

        public void setMake(String x)
        {
            make = x;
        }

        //The sets for the inspection elements could be expanded to include the corresponding test notes

        public void setReqServRep(String x)
        {
            reqServRepRslt = x;
        }

        public void setOprConf(String x)
        {
            oprConfRslt = x;
        }

        //----------------------------------------------------------------------------------

        //GETS

        public int getEquipID()
        {
            return equipID;
        }

        public int getModel()
        {
            return model;
        }

        public String getLocation()
        {
            return location;
        }

        public String getVoltage()
        {
            return voltage;
        }

        public String getPower()
        {
            return totalPower;
        }

        public int getNumHeads()
        {
            return numHeads;
        }

        public String getMake()
        {
            return make;
        }
    }
}
