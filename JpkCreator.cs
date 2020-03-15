using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using JPK_generator.Model;

namespace JPK_generator
{
    class JpkCreator
    {

        public IList<string> GenerateJpk(IList<invoice> invoices, config config, DateTime dateFrom, DateTime dateTo)
        {
            JPK jpk = new JPK();

            jpk.Naglowek = new TNaglowek();
            jpk.Naglowek.KodFormularza = new TNaglowekKodFormularza();
            //jpk.Naglowek.KodFormularza.kodSystemowy = "JPK_VAT (3)";
            //jpk.Naglowek.KodFormularza.wersjaSchemy = "1-1";
            jpk.Naglowek.WariantFormularza = 3; //config.form_variant
            //jpk.Naglowek.CelZlozenia = config.purpose_of_submission; //0
            jpk.Naglowek.DataWytworzeniaJPK = DateTime.Now;
            jpk.Naglowek.DataOd = dateFrom;
            jpk.Naglowek.DataDo = dateTo;
            jpk.Naglowek.NazwaSystemu = config.system_name;


            jpk.Podmiot1 = new JPKPodmiot1();
            jpk.Podmiot1.NIP = config.my_nip;
            jpk.Podmiot1.PelnaNazwa = config.my_name;
            jpk.Podmiot1.Email = config.my_email;

            var incomeInvoices = invoices.Where(a => a.income == true).ToArray();
            decimal incomeSum = 0;
            jpk.SprzedazWiersz = new JPKSprzedazWiersz[incomeInvoices.Count()];
            for (var i = 0; i < incomeInvoices.Count(); i++)
            {
                var currentInvoice = incomeInvoices[i];
                JPKSprzedazWiersz item = new JPKSprzedazWiersz();
                item.LpSprzedazy = (i + 1).ToString();
                item.NrKontrahenta = currentInvoice.contractor_nip;
                item.NazwaKontrahenta = currentInvoice.contractor_name;
                item.AdresKontrahenta = currentInvoice.contractor_address;
                item.DowodSprzedazy = currentInvoice.invoice_number;
                item.DataWystawienia = currentInvoice.date_of_issue;
                item.DataSprzedazy = currentInvoice.date_of_sale;
                item.DataSprzedazySpecified = true;
                item.K_19 = currentInvoice.amount_net;
                item.K_20 = currentInvoice.amount_vat;
                jpk.SprzedazWiersz[i] = item;
                incomeSum = incomeSum + currentInvoice.amount_vat;
            }

            jpk.SprzedazCtrl = new JPKSprzedazCtrl();
            jpk.SprzedazCtrl.LiczbaWierszySprzedazy = incomeInvoices.Count().ToString();
            jpk.SprzedazCtrl.PodatekNalezny = incomeSum;

            var outcomeInvoices = invoices.Where(a => a.income == false).ToArray();
            decimal outcomeSum = 0;
            jpk.ZakupWiersz = new JPKZakupWiersz[outcomeInvoices.Count()];
            for (var i = 0; i < outcomeInvoices.Count(); i++)
            {
                var currentInvoice = outcomeInvoices[i];
                JPKZakupWiersz item = new JPKZakupWiersz();
                item.LpZakupu = (i + 1).ToString();
                item.NrDostawcy = currentInvoice.contractor_nip;
                item.NazwaDostawcy = currentInvoice.contractor_name;
                item.AdresDostawcy = currentInvoice.contractor_address;
                item.DowodZakupu = currentInvoice.invoice_number;
                item.DataZakupu = currentInvoice.date_of_issue; //być może zamieniona kolejność
                item.DataWplywu = currentInvoice.date_of_sale; //być może zamieniona kolejność
                item.K_45 = currentInvoice.amount_net;
                item.K_46 = currentInvoice.amount_vat;
                jpk.ZakupWiersz[i] = item;
                outcomeSum = outcomeSum + currentInvoice.amount_vat;
            }

            jpk.ZakupCtrl = new JPKZakupCtrl();
            jpk.ZakupCtrl.LiczbaWierszyZakupow = outcomeInvoices.Count().ToString();
            jpk.ZakupCtrl.PodatekNaliczony = outcomeSum;

            XmlSerializer serializer = new XmlSerializer(typeof(JPK));
            string jpkFileName = "JPK_" + new DateTime().Month + "_" + new DateTime().Year + ".xml";
            string path = config.path_for_jpk + "\\" + jpkFileName;

            using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(path, false, System.Text.Encoding.UTF8))
            {
                serializer.Serialize(writer, jpk);
            }
            return null;
        }

    }
}
