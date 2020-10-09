using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream301
{
    class Table
    {
        double width;
        double height;
        string Color;
        string Material;
        string forma;

        public Table(double width, double height, string color, string material, string forma)
        {
            this.width = width;
            this.height = height;
            Color = color;
            
            Material = material;
            this.forma = forma;
        }


        public double SquareTable()
        {
            return width / height;
        }

        public string ReturnForm()
        {
            return forma;
        }

        public void SetColor(string color) /// Метод для установки цвета
        {
            Color = color;
        }

        public string ReturnColorTable() // Метод которы возвращает цвет
        {
            return Color;
        }
       
    }
}
