using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Data;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace FAFOS
{
    class GenExController
    {
        private iTextSharp.text.Font Times = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
        private iTextSharp.text.Font WhiteTimes = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE);

        Document document;

        public GenExController()
        {
            document = new Document(PageSize.LETTER);
        }

        public void addTable()
        {
            PdfPTable table = new PdfPTable(16);
            table.HorizontalAlignment = 0;
            table.TotalWidth = 530f;
            table.LockedWidth = true;
            float[] widths = new float[] { 15f, 35f, 50f, 15f, 15f, 40f, 25f, 10f, 10f, 10f, 10f, 10f, 10f, 10f, 10f, 10f };
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
