using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ParticlesDemo
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {
            MessageBox.Show("Singleton Deseni Uygulandı..............");
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }
    }
}
