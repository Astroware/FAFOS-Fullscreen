using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

using iTextSharp.text;
using iTextSharp.text.pdf;
using FAFOS.Inspection;

namespace FAFOS
{
    class GenHoseController
    {
        private iTextSharp.text.Font Times = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
        private iTextSharp.text.Font WhiteTimes = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE);

        Document document;
        PdfPTable table;
        public GenHoseController()
        {
            document = new Document(PageSize.LETTER);
        }

        public void open(string FILE)
        {
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(FILE, FileMode.Create));
            document.Open();
        }

        public void addTable(Report r)
        {
            table = new PdfPTable(7);
            table.HorizontalAlignment = 0;
            table.TotalWidth = 530f;
            table.LockedWidth = true;
            float[] widths = new float[] { 15f, 35f, 50f, 10f, 10f, 10f, 10f};
            table.SetWidths(widths);

            createHeader(table);

            List<Hose> HL;
            HL = r.getHoseRep();

            for (int i = 0; i < HL.Count; i++)
            {
                addDataRow(HL.ElementAt<Hose>(i).getEquipID(),
                           HL.ElementAt<Hose>(i).getLocation(),
                           HL.ElementAt<Hose>(i).getManfDate(),
                           HL.ElementAt<Hose>(i).getCabCond(),
                           HL.ElementAt<Hose>(i).getNozCond(),
                           HL.ElementAt<Hose>(i).getHoseReRack(),
                           HL.ElementAt<Hose>(i).getHydroTest());
            }

            document.Add(table);
        }

        private void createHeader(PdfPTable table)
        {
            addCell(table, "Equip ID", 1, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Location", 1, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Manufacturing Date", 1, 1, 0, BaseColor.RED, WhiteTimes);

            //addCell(table, "Inspection - Service", 1, 4, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Cabinet Condition", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "Nozzle Conditions", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "Hose Re-Rack", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "HydroStatic Test Due", 1, 1, 90, BaseColor.RED, WhiteTimes);



        }

        private void addDataRow(int equipID,
                                String location,
                                String manfDate,
                                String cabCond,
                                String nozCond,
                                String hoseReRack,
                                String hydroTest)
        {
            String EID = equipID.ToString();
            addCell(table, EID, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, location, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, manfDate, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, cabCond, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, nozCond, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, hoseReRack, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, hydroTest, 1, 1, 0, BaseColor.WHITE, Times);

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
