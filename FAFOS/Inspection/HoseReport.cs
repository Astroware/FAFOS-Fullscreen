using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAFOS.Inspection
{
    class HoseReport
    {
        private int equipID;
        private String location;
        private String manfDate;

        private String cabCondRslt;
        private String nozCondRslt;
        private String hoseReRackRslt;
        private String hydroTestRslt;

        //may need to store the test notes as well

        //----------------------------------------------------------------------------------

        //SETS

        public HoseReport()
        {
        }

        public void setEquipID(int x)
        {
            equipID = x;
        }

        public void setLocation(String x)
        {
            location = x;
        }

        public void setManfDate(String x)
        {
            manfDate = x;
        }

        //The sets for the inspection elements could be expanded to include the corresponding test notes

        public void setCabCond(String x)
        {
            cabCondRslt = x;
        }

        public void setNozCond(String x)
        {
            nozCondRslt = x;
        }

        public void setHoseReRack(String x)
        {
            hoseReRackRslt = x;
        }

        public void setHydroTest(String x)
        {
            hydroTestRslt = x;
        }

        //----------------------------------------------------------------------------------

        //GETS

        public int getEquipID()
        {
            return equipID;
        }

        public String getLocation()
        {
            return location;
        }

        public String getManfDate()
        {
            return manfDate;
        }

        public String getCabCond()
        {
            return cabCondRslt;
        }

        public String getNozCond()
        {
            return nozCondRslt;
        }

        public String getHoseReRack()
        {
            return hoseReRackRslt;
        }

        public String getHydroTest()
        {
             return hydroTestRslt;
        }
    }
}
