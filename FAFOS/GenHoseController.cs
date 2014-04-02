using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace FAFOS
{
    class GenHoseController
    {
        private iTextSharp.text.Font Times = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
        private iTextSharp.text.Font WhiteTimes = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE);

        Document document;

        public GenHoseController()
        {
            document = new Document(PageSize.LETTER);
        }

        public void addTable()
        {
            PdfPTable table = new PdfPTable(11);
            table.HorizontalAlignment = 0;
            table.TotalWidth = 530f;
            table.LockedWidth = true;
            float[] widths = new float[] { 15f, 35f, 50f, 15f, 15f, 40f, 25f, 10f, 10f, 10f, 10f };
            table.SetWidths(widths);

            createHeader(table);
            addDataRow(table);
            addDataRow(table);
            addDataRow(table);

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
            addCell(table, "Inspection - Service", 1, 4, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Cabinet Condition", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "Nozzle Conditions", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "Hose Re-Rack", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "HydroStatic Test Due", 1, 1, 90, BaseColor.RED, WhiteTimes);



        }

        private void addDataRow(PdfPTable table)
        {
            addCell(table, " ", 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, " ", 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, " ", 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, " ", 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, " ", 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, " ", 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, " ", 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, " ", 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, " ", 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, " ", 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, " ", 1, 1, 0, BaseColor.WHITE, Times);

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
