using System;
using System.Text.RegularExpressions;

namespace CalculaAreaTriangulo
{
    internal static class ChecaCaracteres
    {

        public static string ChecaVirgula(string expressao)
        {
            string expressaoCorrigida = expressao.Contains(",") ? expressao.Replace(",", ".") : expressao;

            return expressaoCorrigida;

        }

    }
}
