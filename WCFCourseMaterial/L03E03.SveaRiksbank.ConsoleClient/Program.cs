using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03E03.SveaRiksbank.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.SearchRequestParameters pa = new ServiceReference.SearchRequestParameters();
            pa.datefrom = new DateTime(1999, 03, 20);
            pa.dateto = new DateTime(2000, 03, 20);
            pa.avg = true;
            pa.aggregateMethod = ServiceReference.AggregateMethodType.M; // montly
            pa.languageid = ServiceReference.LanguageType.en;
            pa.max = false;
            pa.min = false;
            pa.ultimo = false;

            ServiceReference.SearchGroupSeries[] groupseries = new ServiceReference.SearchGroupSeries[1];
            groupseries[0].groupid = "130";
            groupseries[0].seriesid = "SEKBEFPMI";
            pa.searchGroupSeries = groupseries;


            ServiceReference.getInterestAndExchangeRatesResponse resp = new ServiceReference.getInterestAndExchangeRatesResponse();

            new ServiceReference.getInterestAndExchangeRatesRequest(pa);
        }
    }
}
