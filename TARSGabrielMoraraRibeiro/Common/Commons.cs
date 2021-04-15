using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TARSGabrielMoraraRibeiro.Common
{
    public class Commons
    {
        // Retorna DataHora atual de Brasilia
        public static DateTime HourBrasilia
        {
            get
            {
                DateTime dateTime = DateTime.UtcNow;
                TimeZoneInfo hrBrasilia = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
                return TimeZoneInfo.ConvertTimeFromUtc(dateTime, hrBrasilia);
            }
        }

    }
}
