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
    class GenLightController
    {
        private iTextSharp.text.Font Times = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
        private iTextSharp.text.Font WhiteTimes = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
        private iTextSharp.text.Font Title = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 20, iTextSharp.text.Font.BOLD);
        private iTextSharp.text.Font ReportHeader = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16, iTextSharp.text.Font.BOLD);
        private iTextSharp.text.Font Header = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD);
       
        Document document;
        PdfPTable table;
        public GenLightController()
        {
            document = new Document(PageSize.LETTER);
        }

        public void open(string FILE)
        {
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(FILE, FileMode.Create));
            document.Open();
        }

        public void addTitle(String address)
        {
            Paragraph preface = new Paragraph();

            preface.Add(new Paragraph("Inspection/Test Report", Title));
            addEmptyLine(preface, 1);
            preface.Add(new Paragraph("Light Report", ReportHeader));
            addEmptyLine(preface, 1);
            preface.Add(new Paragraph("Report generated on: " + DateTime.Now, Header));
            addEmptyLine(preface, 1);

            preface.Add(new Paragraph("Property: " + address, Header));
            addEmptyLine(preface, 1);

            document.Add(preface);
        }

        private void addEmptyLine(Paragraph paragraph, int p)
        {
            for (int i = 0; i < p; i++)
            {
                paragraph.Add(new Paragraph(" "));
            }
        }

        public void addTable(Report r)
        {
            table = new PdfPTable(9);
            table.HorizontalAlignment = 0;
            table.TotalWidth = 530f;
            table.LockedWidth = true;
            float[] widths = new float[] { 35f, 35f, 50f, 20f, 15f, 40f, 25f, 15f, 15f};
            table.SetWidths(widths);

            createHeader(table);

            List<Lights> LL;
            LL = r.getLightsRep();

            for (int i = 0; i < LL.Count; i++)
            {
                addDataRow(LL.ElementAt<Lights>(i).getEquipID(),
                           LL.ElementAt<Lights>(i).getModel(),
                           LL.ElementAt<Lights>(i).getLocation(),
                           LL.ElementAt<Lights>(i).getVoltage(),
                           LL.ElementAt<Lights>(i).getPower(),
                           LL.ElementAt<Lights>(i).getNumHeads(),
                           LL.ElementAt<Lights>(i).getMake(),
                           LL.ElementAt<Lights>(i).getReqServRep(),
                           LL.ElementAt<Lights>(i).getOprConf());
            }
            document.Add(table);
        }

        private void createHeader(PdfPTable table)
        {
            addCell(table, "Equip ID", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Model", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Location", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Voltage", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Total Power", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Number of Heads", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Make", 2, 1, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Inspection - Service", 1, 2, 0, BaseColor.RED, WhiteTimes);
            addCell(table, "Repair Service", 1, 1, 90, BaseColor.RED, WhiteTimes);
            addCell(table, "Operation Confirmed", 1, 1, 90, BaseColor.RED, WhiteTimes);



        }

        private void addDataRow(int equipID,
                                int model,
                                String location,
                                String voltage,
                                String totalPower,
                                int numHeads,
                                String make,
                                String reqServ,
                                String oprConf)
        {
            String EID = equipID.ToString();
            String mod = model.ToString();
            String NH = numHeads.ToString();
            addCell(table, EID, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, mod, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, location, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, voltage, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, totalPower, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, NH, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, make, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, reqServ, 1, 1, 0, BaseColor.WHITE, Times);
            addCell(table, oprConf, 1, 1, 0, BaseColor.WHITE, Times);

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
