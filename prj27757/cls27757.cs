using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj27757
{
    static class cls27757
    {
        //Campos
        private static string _titulo;

        //Propriedades
        public static string titulo
        {
            get{ return _titulo;}
            set { _titulo = value.Replace(" ", "").Replace("/", "").Replace("-", "").Replace(".", ""); }
        }

        public static bool valido
        {
            get
            {
                if (titulo.Length == 12)
	            {
                    string verifica = titulo;
                    int[] multiplica = {2,3,4,5,6,7,8,9,7,8,9 };
                    Int64 total = 0;

                    for (int i = 0; i <= 8; i++)
                    {
                        total += int.Parse(titulo.Substring(i,1)) * multiplica[i];
                    }
                    verifica += total % 11;


                    return true;
	            }

                return false;
            }
        }
    }
}
