using System;

namespace CSharpSort.Data
{
    internal static class DataMapper
    {
        //.           1          2           3          4
        //.1-2345-6789.123456789-.1-234-56789.123-456789.12-3
        //42-1004-84684182000157-55-001-000000002-010804210-8
        
        //42- código do estado emissor( 42 corresponde a SC)
        //42-1004 ano/mês
        //42-1004-84684182000157 CNPJ
        //42-1004-84684182000157-55- modelo do documento
        //42-1004-84684182000157-55-001- serie da nota fiscal
        //42-1004-84684182000157-55-001-000000002- numero da nota
        //42-1004-84684182000157-55-001-000000002-010804210- numero a ser utilizado pelo contribuinte emissor da nota fiscal, sugerido fazer criptografia
        //42-1004-84684182000157-55-001-000000002-010804210-8 digito verificador base 11 Inicial 2 Final 9 reverse.

        public static int GetMonthAndYear(this string value)
        {
            var result = value[2].ToString() + 
                         value[3].ToString() + 
                         value[4].ToString() + 
                         value[5].ToString();

            return Convert.ToInt32(result);
        }
    }
}
