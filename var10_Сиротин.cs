using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1ACrXX9Gcw4QhWjsbdaJLBZ5DcvxH5JZvfcD6PI8X_iY/edit?usp=sharing
    public class Var10
    {
        public string Название { get; }
        public decimal Оклад { get; }
        public Var11Подразделение Подразделение { get; }
        public Var10(string название, decimal оклад, Var11Подразделение подразделение)
        {
            Название = название;
            Оклад = оклад;
            Подразделение = подразделение;
        }
    }
}


