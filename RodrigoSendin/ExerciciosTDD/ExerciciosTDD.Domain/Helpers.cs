using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosTDD.Domain
{
    public static class Helpers
    {
        public static Exception? ConvertStringListToException(List<string> mensagens)
        {
            if (mensagens == null || mensagens.Count == 0) return null;

            var exceptionMessage = string.Join(Environment.NewLine, mensagens);

            return new Exception(exceptionMessage.Trim());
        }
    }
}
