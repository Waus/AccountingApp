using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using AccountingApp.Model;
using System.Collections.Generic;

namespace AccountingApp.UnitTests
{
    [TestClass]
    public class JpkGeneratorTests
    {
        [TestMethod]
        public void ValidData_JpkFileCorrectlyGenerated()
        {
            IList<invoice> invoices = new List<invoice>();

            invoice invoice1 = new invoice()
            {
                invoice_id = 1,
                invoice_number = "3/2020",
                description = "Usługi informatyczne",
                amount_net = 2000,
                amount_vat = 460,
                vat_rate = 23,
                contractor_name = "Tiger Bonzo 2016",
                contractor_address = "ul. Mineralna 3, 91-601 Łódź",
                contractor_nip = "3921787841",
                date_of_issue = new DateTime(2020, 02, 29),
                date_of_sale = new DateTime(2020, 02, 29),
                income = true
            };

            invoice invoice2 = new invoice()
            {
                invoice_id = 1,
                invoice_number = "4/2020",
                description = "Usługi informatyczne",
                amount_net = 1000,
                amount_vat = 230,
                vat_rate = 23,
                contractor_name = "Tiger Bonzo 2016",
                contractor_address = "ul. Mineralna 3, 91-601 Łódź",
                contractor_nip = "3921787841",
                date_of_issue = new DateTime(2020, 02, 29),
                date_of_sale = new DateTime(2020, 02, 29),
                income = true
            };

            invoices.Add(invoice1);
            invoices.Add(invoice2);

            config config = new config()
            {
                config_id = 1,
                my_name = "Kamil Murański IT",
                my_address = "Zabłocińska 4/23, 01-697, Warszawa",
                my_nip = "1182144394",
                my_email = "muranski.kamil@gmail.com",
                form_variant = "3",
                path_for_jpk = @"C:\JPK",
                purpose_of_submission = "0",
                system_name = "Microsoft Excel"
            };

            DateTime dateFrom = new DateTime(2020, 02, 01);
            DateTime dateTo = new DateTime(2020, 02, 29);

            JpkGenerator jpkGenerator = new JpkGenerator();

            JPK jpk = jpkGenerator.GenerateJpk(invoices, config, dateFrom, dateTo);

            jpk.Should().NotBeNull();
            jpk.Naglowek.KodFormularza.kodSystemowy.Should().Be("JPK_VAT (3)");
            jpk.Naglowek.KodFormularza.Value.Should().Equals(0); //enum TKodFormularza.JPK_VAT == 0
            jpk.Naglowek.KodFormularza.wersjaSchemy.Should().Be("1-1");
            jpk.Naglowek.WariantFormularza.Should().Equals(3);
            jpk.Naglowek.CelZlozenia.Should().Be("0");
            jpk.Naglowek.DataOd.Should().Be(new DateTime(2020, 02, 01));
            jpk.Naglowek.DataDo.Should().Be(new DateTime(2020, 02, 29));
            jpk.Naglowek.NazwaSystemu.Should().Be("Microsoft Excel");

            jpk.Podmiot1.NIP.Should().Be("1182144394");
            jpk.Podmiot1.PelnaNazwa.Should().Be("Kamil Murański IT");
            jpk.Podmiot1.Email.Should().Be("muranski.kamil@gmail.com");

            jpk.SprzedazWiersz.Should().HaveCount(2);
            jpk.SprzedazWiersz[0].LpSprzedazy.Should().Be("1");
            jpk.SprzedazWiersz[0].NrKontrahenta.Should().Be("3921787841");
            jpk.SprzedazWiersz[0].NazwaKontrahenta.Should().Be("Tiger Bonzo 2016");
            jpk.SprzedazWiersz[0].AdresKontrahenta.Should().Be("ul. Mineralna 3, 91-601 Łódź");
            jpk.SprzedazWiersz[0].DowodSprzedazy.Should().Be("3/2020");
            jpk.SprzedazWiersz[0].DataWystawienia.Should().Be(new DateTime(2020, 02, 29));
            jpk.SprzedazWiersz[0].DataSprzedazy.Should().Be(new DateTime(2020, 02, 29));
            jpk.SprzedazWiersz[0].K_19.Should().Equals("2000");
            jpk.SprzedazWiersz[0].K_20.Should().Equals("460");

            jpk.SprzedazWiersz[1].LpSprzedazy.Should().Be("2");
            jpk.SprzedazWiersz[1].NrKontrahenta.Should().Be("3921787841");
            jpk.SprzedazWiersz[1].NazwaKontrahenta.Should().Be("Tiger Bonzo 2016");
            jpk.SprzedazWiersz[1].AdresKontrahenta.Should().Be("ul. Mineralna 3, 91-601 Łódź");
            jpk.SprzedazWiersz[1].DowodSprzedazy.Should().Be("4/2020");
            jpk.SprzedazWiersz[1].DataWystawienia.Should().Be(new DateTime(2020, 02, 29));
            jpk.SprzedazWiersz[1].DataSprzedazy.Should().Be(new DateTime(2020, 02, 29));
            jpk.SprzedazWiersz[1].K_19.Should().Equals("1000");
            jpk.SprzedazWiersz[1].K_20.Should().Equals("230");

            jpk.SprzedazCtrl.LiczbaWierszySprzedazy.Should().Equals("2");
            jpk.SprzedazCtrl.PodatekNalezny.Should().Equals("690");

            jpk.ZakupCtrl.LiczbaWierszyZakupow.Should().Equals("0");
            jpk.ZakupCtrl.PodatekNaliczony.Should().Equals("0");
        }
    }
}
