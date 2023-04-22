using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mebelnoye bezumie
{
    public class MebelDataBase
    {
        internal List<MebelDataBase> mebels { get; private set; }

        public void InInitialize()
        {
            mebels = new List<MebelDataBase>
            {
                new Mebel("Стул"),
                new Mebel("Стол"),
                new Mebel("Шкаф")

            };

        }
    }
}
