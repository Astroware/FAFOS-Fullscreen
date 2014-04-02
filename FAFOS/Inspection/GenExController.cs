using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Data;

using iTextSharp.text;
using iTextSharp.text.pdf;
using FAFOS.Inspection;

namespace FAFOS
{
    class GenExController
    {
        private iTextSharp.text.Font Times = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
        private iTextSharp.text.Font WhiteTimes = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
        private iTextSharp.text.Font catFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 18, iTextSharp.text.Font.BOLD);
        private iTextSharp.text.Font redFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.RED);
        private iTextSharp.text.Font subFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16, iTextSharp.text.Font.BOLD);
        private iTextSharp.text.Font smallBold = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD);


        public Document document;
        PdfPTable table;
        public GenExController()
        {
            document = new Document(PageSize.LETTER);
        }

        public void open(string FILE)
        {
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(FILE, FileMode.Create));
            document.Open();
        }

        public void addMetaData()
        {
            document.AddTitle("Report of Inspection/Test");
            document.AddSubject("Using iText");
            document.AddKeywords("Csharp, PDF, iText");
            document.AddAuthor("Abdelkader Ouda");
            document.AddCreator("Abdelkader Ouda");
        }

        public void addTable(Report r)
        {
            table = new PdfPTable(16);
            table.HorizontalAlignment = 0;
            table.TotalWidth = 530f;
            table.LockedWidth = true;
            float[] widths = new float[] { 15f, 35f, 50f, 15f, 15f, 40f, 25f, 10f, 10f, 10f, 10f, 10f, 10f, 10f, 10f, 10f };
            table.SetWidths(widths);

            createHeader(table);

            List<Extinguisher> ExtL;
            ExtL = r.getExtRep();

            for(int i=0; i<ExtL.Count; i++)
            {
                addDataRow(ExtL.ElementAt<Extinguisher>(i).getItemNum(),
                            ExtL.ElementAt<Extinguisher>(i).getEquipID(),
                            ExtL.ElementAt<Extinguisher>(i).getLocation(),
                            ExtL.ElementAt<Extinguisher>(i).getSize(),
                            ExtL.ElementAt<Extinguisher>(i).getType(),
                            ExtL.ElementAt<Extinguisher>(i).getManfModel(),
                            ExtL.ElementAt<Extinguisher>(i).getSerialNo(),
                            ExtL.ElementAt<Extinguisher>(i).getHydroTest(),
                            ExtL.ElementAt<Extinguisher>(i).getSixYrInsp(),
                            ExtL.ElementAt<Extinguisher>(i).getWeight(),
                            ExtL.ElementAt<Extinguisher>(i).getBracket(),
                            ExtL.ElementAt<Extinguisher>(i).getGuage(),
                            ExtL.ElementAt<Extinguisher>(i).getPullPin(),
                            ExtL.ElementAt<Extinguisher>(i).getSignage(),
                            ExtL.ElementAt<Extinguisher>(i).getCollar(),
                            ExtL.ElementAt<Extinguisher>(i).getHose());
            }
            document.Add(table);
        }

        private void createHeader(PdfPTable table)
        {
            addCell(table, "Item\n#", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Equip ID", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Location", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Size", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Type", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Manufacturer\nModel", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Serial #", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Inspection - Service", 1, 9, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Hydro Test", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "6 Year Insep", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "Weight", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "Bracket", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "Gauge", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "Pull Pin", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "Signage", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "Collar", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "Hose", 1, 1, 90, BaseColor.RED, WhiteTimes);



        }

        public void addDataRow(int itemNum,
                               int equipID,
                               String location,
                               int size,
                               String type,
                               String manFModel,
                               String serialNum,
                               String HydroTestResult,
                               String sixYearIns,
                               String waitResult,
                               String bracketResult,
                               String gaugeResult,
                               String pullPinResult,
                               String signageResult,
                               String collarResult,
                               String hoseResult)
        {

            String INum = itemNum.ToString();
            String eID = equipID.ToString();
            String Size = size.ToString();
            addCell(table, INum, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, eID, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, location, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, Size, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, type, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, manFModel, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, serialNum, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, HydroTestResult, 1, 1, 90, BaseColor.WHITE, Times);
            addCell(table, sixYearIns, 1, 1, 90, BaseColor.WHITE, Times);
            addCell(table, waitResult, 1, 1, 90, BaseColor.WHITE, Times);
            addCell(table, bracketResult, 1, 1, 90, BaseColor.WHITE, Times);
            addCell(table, gaugeResult, 1, 1, 90, BaseColor.WHITE, Times);
            addCell(table, pullPinResult, 1, 1, 90, BaseColor.WHITE, Times);
            addCell(table, signageResult, 1, 1, 90, BaseColor.WHITE, Times);
            addCell(table, collarResult, 1, 1, 90, BaseColor.WHITE, Times);
            addCell(table, hoseResult, 1, 1, 90, BaseColor.WHITE, Times);

        }


        private void addCell(PdfPTable table, string text, int rowspan, int colpan, int rotate, BaseColor backgroundColor, iTextSharp.text.Font font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Rowspan = rowspan;
            cell.Colspan = colpan;
            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.Rotation = rotate;
            cell.BackgroundColor = backgroundColor;
            //cell.BorderColor = BaseColor.GRAY;
            table.AddCell(cell);
        }

        public void close()
        {
            document.Close();
        }
    }
}
