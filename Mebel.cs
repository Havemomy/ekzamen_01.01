using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mebl

{
    internal class mebel
    {
        private string _name;
        

        public string Name
        {
            get { return _name; }
        }

        public mebel(string name, string location, int ostatok)
        {
            _name = name;
            
        }

        public mebel() {
        }

        internal void InInitialize() {
            throw new NotImplementedException();
        }
    }
}
