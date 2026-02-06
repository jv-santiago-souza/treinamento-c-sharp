using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosTDD.Domain
{
    public static class Helpers
    {
        public static Exception? ConvertStringListToException(List<string> mensagens)
        {
            var exceptionMessage = "";
            foreach (var msg in mensagens)
                exceptionMessage += msg + Environment.NewLine;

            return string.IsNullOrWhiteSpace(exceptionMessage) ? null : new Exception(exceptionMessage.Trim());
        }
    }
}
