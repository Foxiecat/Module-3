using System;
using System.ComponentModel.Design;
using System.Net.Http;

namespace SodaMachine
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool showMenu = true;
            
            while (showMenu)
            {
                showMenu = ControlPanel.MainPanel();
            }
        }
    }
}