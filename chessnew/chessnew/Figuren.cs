using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Documents;
using System.Windows.Input;

namespace chessnew
{
    internal class Figuren
    {
        public List<Rectangle> blackFigures = new List<Rectangle>();
        public List<Rectangle> whiteFigures = new List<Rectangle>();

        public void BlackFigures(MainWindow mainWindow)
        {
            blackFigures.Add(mainWindow.Pawn1);
            blackFigures.Add(mainWindow.Pawn2);
            blackFigures.Add(mainWindow.Pawn3);
            blackFigures.Add(mainWindow.Pawn4);
            blackFigures.Add(mainWindow.Pawn5);
            blackFigures.Add(mainWindow.Pawn6);
            blackFigures.Add(mainWindow.Pawn7);
            blackFigures.Add(mainWindow.Pawn8);
            blackFigures.Add(mainWindow.Rook1Black);
            blackFigures.Add(mainWindow.Rook2Black);
            blackFigures.Add(mainWindow.Knight1Black);
            blackFigures.Add(mainWindow.Knight2Black);
            blackFigures.Add(mainWindow.BiShop1Black);
            blackFigures.Add(mainWindow.BiShop2Black);
            blackFigures.Add(mainWindow.KingBlack);
            blackFigures.Add(mainWindow.QueenBlack);
        }
        public void WhiteFigures(MainWindow mainWindow)
        {
            whiteFigures.Add(mainWindow.Pawn1White);
            whiteFigures.Add(mainWindow.Pawn2White);
            whiteFigures.Add(mainWindow.Pawn3White);
            whiteFigures.Add(mainWindow.Pawn4White);
            whiteFigures.Add(mainWindow.Pawn5White);
            whiteFigures.Add(mainWindow.Pawn6White);
            whiteFigures.Add(mainWindow.Pawn7White);
            whiteFigures.Add(mainWindow.Pawn8White);
            whiteFigures.Add(mainWindow.Rook1White);
            whiteFigures.Add(mainWindow.Rook2White);
            whiteFigures.Add(mainWindow.Bishop1White);
            whiteFigures.Add(mainWindow.Bishop2White);
            whiteFigures.Add(mainWindow.Knight1White);
            whiteFigures.Add(mainWindow.Knight1White);
            whiteFigures.Add(mainWindow.KingWhite);
            whiteFigures.Add(mainWindow.QueenWhite);
        }
        public void WhiteFiguresMoves(MainWindow mainWindow)
        {
            for (int i = 0; i < whiteFigures.Count; i++)
            {
                Rect r1 = new Rect(Canvas.GetLeft(whiteFigures[i]), Canvas.GetTop(whiteFigures[i]), whiteFigures[i].Width, whiteFigures[i].Height);

                for (int j = 0; j < blackFigures.Count; j++)
                {
                    Rect r2 = new Rect(Canvas.GetLeft(blackFigures[j]), Canvas.GetTop(blackFigures[j]), blackFigures[j].Width, blackFigures[j].Height);

                    if (r1.IntersectsWith(r2))
                    {
                       blackFigures.RemoveAt(j);
                    }
                }
            }
        }
    }
}
