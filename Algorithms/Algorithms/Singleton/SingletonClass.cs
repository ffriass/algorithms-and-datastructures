using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Singleton
{
    public class SingletonClass
    {

        private static SingletonClass _instance;
        DateTime creationDate;
        
        private SingletonClass()
        {
            creationDate = DateTime.Now;
        }

        public static SingletonClass Instance
        {
            get
            {
                
                if (_instance == null)
                    _instance = new SingletonClass();
                return _instance;
            }
        }

        public DateTime CreationDate => creationDate;
    }
}
