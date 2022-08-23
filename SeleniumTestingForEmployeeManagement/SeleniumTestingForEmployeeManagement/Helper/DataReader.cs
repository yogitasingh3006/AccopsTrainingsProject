using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SeleniumTestingForEmployeeManagement.Helper
{
    public static class DataReader
    {
        public static T Read<T>(string filePath)
        {
            using StreamReader reader = new StreamReader(filePath);
            string text = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<T>(text);
        }
    }
}
