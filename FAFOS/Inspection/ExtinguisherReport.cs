using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FAFOS.Inspection
{
    class ExtinguisherReport
    {
        private int itemNum;
        private int equipID;
        private String location;
        private int size;
        private String type;
        private String manfModel;
        private int serialNo;

        private String hydroTestRslt;
        private String sixYrInspRslt;
        private String weightRslt;
        private String bracketRslt;
        private String gaugeRslt;
        private String pullPinRslt;
        private String signageRslt;
        private String collarRslt;
        private String hoseRslt;

        //may need to store the test notes as well

        //----------------------------------------------------------------------------------

        public DataTable getExTable()
        {
            DataTable ExtinguisherTable = new DataTable();
            ExtinguisherTable.Columns.Add("itemNum", typeof(int));
            ExtinguisherTable.Columns.Add("equipID", typeof(int));
            ExtinguisherTable.Columns.Add("location", typeof(String));
            ExtinguisherTable.Columns.Add("size", typeof(int));
            ExtinguisherTable.Columns.Add("type", typeof(String));
            ExtinguisherTable.Columns.Add("manfModel", typeof(String));
            ExtinguisherTable.Columns.Add("serialNo", typeof(int));

            ExtinguisherTable.Columns.Add("hydroTestRslt", typeof(String));
            ExtinguisherTable.Columns.Add("sixYrInspRslt", typeof(String));
            ExtinguisherTable.Columns.Add("weightRslt", typeof(String));
            ExtinguisherTable.Columns.Add("bracketRslt", typeof(String));
            ExtinguisherTable.Columns.Add("gaugeRslt", typeof(String));
            ExtinguisherTable.Columns.Add("pullPinRslt", typeof(String));
            ExtinguisherTable.Columns.Add("signageRslt", typeof(String));
            ExtinguisherTable.Columns.Add("collarRslt", typeof(String));
            ExtinguisherTable.Columns.Add("hoseRslt", typeof(String));



            return ExtinguisherTable;
        }

        //SETS

        public ExtinguisherReport()
        {
        }

        public void setItemNum(int x)
        {
            itemNum = x;
        }

        public void setEquipID(int x)
        {
            equipID = x;
        }

        public void setLocation(String x)
        {
            location = x;
        }

        public void setSize(int x)
        {
            size = x;
        }

        public void setType(String x)
        {
            type = x;
        }

        public void setManfModel(String x)
        {
            manfModel = x;
        }

        public void setSerialNo(int x)
        {
            serialNo = x;
        }

        //The sets for the inspection elements could be expanded to include the corresponding test notes
        
        public void setHydroTest(String x)
        {
            hydroTestRslt = x;
        }

        public void setSixYrInsp(String x)
        {
            sixYrInspRslt = x;
        }

        public void setWeight(String x)
        {
            weightRslt = x;
        }

        public void setBracket(String x)
        {
            bracketRslt = x;
        }

        public void setGuage(String x)
        {
            gaugeRslt = x;
        }

        public void setPullPin(String x)
        {
            pullPinRslt = x;
        }

        public void setSignage(String x)
        {
            signageRslt = x;
        }

        public void setCollar(String x)
        {
            collarRslt = x;
        }

        public void setHose(String x)
        {
            hoseRslt = x;
        }

        //----------------------------------------------------------------------------------

        //GETS

        public int getItemNum(int x)
        {
            return itemNum;
        }

        public int getEquipID(int x)
        {
            return equipID;
        }

        public String getLocation(String x)
        {
            return location;
        }

        public int getSize(int x)
        {
            return size;
        }

        public String getType(String x)
        {
            return type;
        }

        public String getManfModel(String x)
        {
            return manfModel;
        }

        public int getSerialNo(int x)
        {
            return serialNo;
        }

        public String getHydroTest(String x)
        {
            return hydroTestRslt;
        }

        public String getSixYrInsp(String x)
        {
            return sixYrInspRslt;
        }

        public String getWeight(String x)
        {
            return weightRslt;
        }

        public String getBracket(String x)
        {
            return bracketRslt;
        }

        public String getGuage(String x)
        {
            return gaugeRslt;
        }

        public String getPullPin(String x)
        {
            return pullPinRslt;
        }

        public String getSignage(String x)
        {
            return signageRslt;
        }

        public String getCollar(String x)
        {
            return collarRslt;
        }

        public String getHose(String x)
        {
            return hoseRslt;
        }
    }
}
