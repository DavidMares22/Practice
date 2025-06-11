using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Singleton
    {

        private static readonly Lazy<Singleton> _instance = new(() => new Singleton());

        private Guid _guid;

        private Singleton() { 
            _guid = Guid.NewGuid();
        }



        public static Singleton Instance => _instance.Value;

        public Guid Guid => _guid;


    }
}
