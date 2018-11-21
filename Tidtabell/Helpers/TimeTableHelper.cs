using System;
using RestSharp;

namespace Tidtabell.Helpers
{
    public class TimeTableHelper
    {
       

        private const string baseApiUrl =
            "http://api.sl.se/api2/realtimedeparturesv4.json?key=68b275af407e433cb9ceb94aaf47a9a4&siteid=9305&timewindow=15";
        public string GetTimeTable()
        {
            var restClient = new RestClient(baseApiUrl);
            var response = RestRequestHelper.Get(restClient);

            return response;
        }
    }
}