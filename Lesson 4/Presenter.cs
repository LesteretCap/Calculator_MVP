using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    internal class Presenter
    {
        Model model;
        MainWindow mainWindow;

        public Presenter(MainWindow mainWind)
        {
            model = new Model();
            mainWindow = mainWind;
            
            mainWindow.AddEvent += MainWindow_AddEvent;
            mainWindow.SubEvent += MainWindow_SubEvent;
            mainWindow.MulEvent += MainWindow_MulEvent;
            mainWindow.DivEvent += MainWindow_DivEvent;
        }

        private void MainWindow_AddEvent(object sender, EventArgs e)
        {
            string result = model.Add(Convert.ToInt32(mainWindow.textBoxA.Text),
                                      Convert.ToInt32(mainWindow.textBoxB.Text));
            mainWindow.textBoxResult.Text = result;
        }

        private void MainWindow_SubEvent(object sender, EventArgs e)
        {
            string result = model.Sub(Convert.ToInt32(mainWindow.textBoxA.Text), 
                                      Convert.ToInt32(mainWindow.textBoxB.Text));
            mainWindow.textBoxResult.Text = result;
        }

        private void MainWindow_MulEvent(object sender, EventArgs e)
        {
            string result = model.Mul(Convert.ToInt32(mainWindow.textBoxA.Text), 
                                      Convert.ToInt32(mainWindow.textBoxB.Text));
            mainWindow.textBoxResult.Text = result;
        }

        private void MainWindow_DivEvent(object sender, EventArgs e)
        {
            string result = model.Div(Convert.ToInt32(mainWindow.textBoxA.Text), 
                                      Convert.ToInt32(mainWindow.textBoxB.Text));
            mainWindow.textBoxResult.Text = result;
        }
    }
}
