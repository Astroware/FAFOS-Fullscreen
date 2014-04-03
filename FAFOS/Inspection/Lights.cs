using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FAFOS.Inspection
{
    public class Lights
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

        public DataTable getExTable()
        {
            DataTable ExtinguisherTable = new DataTable();
            ExtinguisherTable.Columns.Add("equipID", typeof(int));
            ExtinguisherTable.Columns.Add("model", typeof(int));
            ExtinguisherTable.Columns.Add("location", typeof(String));
            ExtinguisherTable.Columns.Add("voltage", typeof(String));
            ExtinguisherTable.Columns.Add("totalPower", typeof(String));
            ExtinguisherTable.Columns.Add("numHeads", typeof(int));
            ExtinguisherTable.Columns.Add("make", typeof(String));

            ExtinguisherTable.Columns.Add("reqServRepRslt", typeof(String));
            ExtinguisherTable.Columns.Add("oprConfRslt", typeof(String));



            return ExtinguisherTable;
        }
        //SETS

        public Lights()
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

        public String getReqServRep()
        {
            return reqServRepRslt;
        }

        public String getOprConf()
        {
            return oprConfRslt;
        }
    }
}
