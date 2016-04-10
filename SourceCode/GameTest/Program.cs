using GameTest.WindowsForms;
using GameTest.WindowsForms.GameBuilderForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace GameTest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            QuickStartForm menu = new QuickStartForm();
            if(menu.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(menu.Customize)
                {
                    var customizeMenu = new GameBuilderForm();
                    if(customizeMenu.ShowDialog() == DialogResult.OK)
                    {
                        WindowsForms.GameForm GameFrame = customizeMenu.ChosenGame;
                        System.Windows.Forms.Application.Run(GameFrame);
                    }
                }
                else
                {
                    WindowsForms.GameForm GameFrame = menu.QuickGame;
                    System.Windows.Forms.Application.Run(GameFrame);
                }
            }
        }
    }
}
