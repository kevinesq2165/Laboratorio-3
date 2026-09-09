using System;
using System.Text.RegularExpressions;

namespace Lab_3
{
    public static class Utilidades
    {
        public static bool EsCorreoValido(string email)
        {
            if (Blanco(email))
            {
                return false;
            }

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, patron);
        }

        public static bool Blanco(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }
    }
}