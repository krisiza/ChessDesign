using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace chessnew
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Figuren figuren = new Figuren();
        DispatcherTimer gameTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();


            gameTimer.Tick += GameTimerEvent;
            gameTimer.Interval = TimeSpan.FromMilliseconds(40);
            gameTimer.Start();
        }
        private void GameTimerEvent(object sender, EventArgs e)
        {  
           
        }
        public void MoveFigur(object sender, MouseEventArgs e, Rectangle figur)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(figur, new DataObject(DataFormats.Serializable, figur), DragDropEffects.Move);
            }
        }

        // Figur bewegen
        private void Pawn1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn1);
        }
        private void Pawn2_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn2);
        }
        private void Pawn3_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn3);
        }
        private void Pawn4_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn4);
        }
        private void Pawn5_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn5);
        }
        private void Pawn6_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn6);
        }
        private void Pawn7_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn7);

        }
        private void Pawn8_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn8);
        }
        private void Rook_Move(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Rook1Black);
        }
        private void Knight1Black_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Knight1Black);
        }
        private void BiShop1Black_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, BiShop1Black);
        }
        private void QueenBlack_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, QueenBlack);
        }
        private void KingBlack_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, KingBlack);
        }
        private void BiShop2Black_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, BiShop2Black);
        }
        private void Knight2Black_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Knight2Black);
        }
        private void Rook2Black_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Rook2Black);
        }
        private void Pawn1White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn1White);
        }
        private void Pawn2White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn2White);
        }
        private void Pawn3White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn3White);
        }
        private void Pawn4White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn4White);
        }
        private void Pawn5White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn5White);
        }
        private void Pawn6White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn6White);
        }
        private void Pawn7White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn7White);
        }
        private void Pawn8White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Pawn8White);
        }
        private void Rook1White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Rook1White);
        }
        private void Knight1White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Knight1White);
        }
        private void Bishop1White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Bishop1White);
        }
        private void QueenWhite_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, QueenWhite);
        }
        private void KingWhite_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, KingWhite);
        }
        private void Bishop2White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Bishop2White);
        }
        private void Knight2White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Knight2White);
        }
        private void Rook_2White_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFigur(sender, e, Rook2White);
        }

        // Figur löschen
        private void A8_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                A8.Children.Remove(element);
            }
        }
        private void B8_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                B8.Children.Remove(element);
            }
        }
        private void C8_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                C8.Children.Remove(element);
            }
        }
        private void D8_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                D8.Children.Remove(element);
            }
        }
        private void E8_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                E8.Children.Remove(element);
            }
        }
        private void F8_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                F8.Children.Remove(element);
            }
        }
        private void G8_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                G8.Children.Remove(element);
            }
        }
        private void H8_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                H8.Children.Remove(element);
            }
        }
        private void A7_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                A7.Children.Remove(element);
            }
        }
        private void B7_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                B7.Children.Remove(element);
            }
        }
        private void C7_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                C7.Children.Remove(element);
            }
        }
        private void D7_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                D7.Children.Remove(element);
            }
        }
        private void E7_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                E7.Children.Remove(element);
            }
        }
        private void F7_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                F7.Children.Remove(element);
            }
        }
        private void G7_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                G7.Children.Remove(element);
            }
        }
        private void H7_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                H7.Children.Remove(element);
            }
        }
        private void A6_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                A6.Children.Remove(element);
            }
        }
        private void B6_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                B6.Children.Remove(element);
            }
        }
        private void C6_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                C6.Children.Remove(element);
            }
        }
        private void D6_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                D6.Children.Remove(element);
            }
        }
        private void E6_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                E6.Children.Remove(element);
            }
        }
        private void F6_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                F6.Children.Remove(element);
            }
        }
        private void G6_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                G6.Children.Remove(element);
            }
        }
        private void H6_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                H6.Children.Remove(element);
            }
        }
        private void A5_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                A5.Children.Remove(element);
            }
        }
        private void B5_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                B5.Children.Remove(element);
            }
        }
        private void C5_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                C5.Children.Remove(element);
            }
        }
        private void D5_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                D5.Children.Remove(element);
            }
        }
        private void E5_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                E5.Children.Remove(element);
            }
        }
        private void F5_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                F5.Children.Remove(element);
            }
        }
        private void G5_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                G5.Children.Remove(element);
            }
        }
        private void H5_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                H5.Children.Remove(element);
            }
        }
        private void A4_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                A4.Children.Remove(element);
            }
        }
        private void B4_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                B4.Children.Remove(element);
            }
        }
        private void C4_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                C4.Children.Remove(element);
            }
        }
        private void D4_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                D4.Children.Remove(element);
            }
        }
        private void E4_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                E4.Children.Remove(element);
            }
        }
        private void F4_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                F4.Children.Remove(element);
            }
        }
        private void G4_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                G4.Children.Remove(element);
            }
        }
        private void H4_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                H4.Children.Remove(element);
            }
        }
        private void A3_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                A3.Children.Remove(element);
            }
        }
        private void B3_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                B3.Children.Remove(element);
            }
        }
        private void C3_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                C3.Children.Remove(element);
            }
        }
        private void D3_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                D3.Children.Remove(element);
            }
        }
        private void E3_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                E3.Children.Remove(element);
            }
        }
        private void F3_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                F3.Children.Remove(element);
            }
        }
        private void G3_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                G3.Children.Remove(element);
            }
        }
        private void H3_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                H3.Children.Remove(element);
            }
        }
        private void A2_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                A2.Children.Remove(element);
            }
        }
        private void B2_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                B2.Children.Remove(element);
            }
        }
        private void C2_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                C2.Children.Remove(element);
            }
        }
        private void D2_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                D2.Children.Remove(element);
            }
        }
        private void E2_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                E2.Children.Remove(element);
            }
        }
        private void F2_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                F2.Children.Remove(element);
            }
        }
        private void G2_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                G2.Children.Remove(element);
            }
        }
        private void H2_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                H2.Children.Remove(element);
            }
        }
        private void A1_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                A1.Children.Remove(element);
            }
        }
        private void B1_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                B1.Children.Remove(element);
            }
        }
        private void C1_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                C1.Children.Remove(element);
            }
        }
        private void D1_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                D1.Children.Remove(element);
            }
        }
        private void E1_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                E1.Children.Remove(element);
            }
        }
        private void F1_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                F1.Children.Remove(element);
            }
        }
        private void G1_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                G1.Children.Remove(element);
            }
        }
        private void H1_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                H1.Children.Remove(element);
            }
        }

        // Figur im Canvas einsetzen
        private void A8_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(A8);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                A8.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void B8_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(B8);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                B8.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void C8_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(C8);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                C8.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void D8_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(B8);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                D8.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void E8_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(E8);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                E8.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void F8_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(F8);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                F8.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void G8_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(G8);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                G8.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void H8_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(H8);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                H8.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void A7_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {  
                Point dropPosition = e.GetPosition(A7);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                A7.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void B7_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(B7);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                B7.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void C7_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(C7);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                C7.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void D7_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(D7);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                D7.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void E7_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(E7);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                E7.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void F7_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(F7);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                F7.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void G7_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(G7);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                G7.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void H7_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(H7);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                H7.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void A6_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(A6);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                A6.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void B6_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(B6);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                B6.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void C6_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(C6);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                C6.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void D6_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(D6);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                D6.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void E6_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(E6);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                E6.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void F6_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(F6);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                F6.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void G6_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(G6);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                G6.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void H6_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(H6);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                H6.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void A5_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(A5);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                A5.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void B5_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(B5);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                B5.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void C5_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(C5);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                C5.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void D5_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(D5);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                D5.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void E5_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(E5);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                E5.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void F5_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(F5);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                F5.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void G5_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(G5);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                G5.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void H5_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(H5);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                H5.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void A4_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(A4);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                A4.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void B4_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(B4);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                B4.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void C4_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(C4);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                C4.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void D4_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(D4);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                D4.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void E4_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(E4);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                E4.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void F4_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(F4);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                F4.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void G4_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(G4);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                G4.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void H4_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(H4);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                H4.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void A3_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(A3);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                A3.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void B3_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(B3);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                B3.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void C3_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(C3);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                C3.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void D3_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(D3);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                D3.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void E3_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(E3);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                E3.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void G3_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(G3);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                G3.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void F3_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(F3);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                F3.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void H3_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(H3);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                H3.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void A2_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(A2);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                A2.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void B2_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(B2);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                B2.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void C2_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(C2);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                C2.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void D2_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(D2);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                D2.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void E2_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(E2);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                E2.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void F2_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(F2);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                F2.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void G2_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(G2);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                G2.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void H2_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(H2);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                H2.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void A1_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(A1);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                A1.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void B1_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(B1);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                B1.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void C1_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(C1);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                C1.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void D1_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(D1);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                D1.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);

            }
        }
        private void E1_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(E1);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                E1.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void F1_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(F1);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                F1.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void G1_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(G1);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                G1.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
        private void H1_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(H1);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                H1.Children.Add(element);
                Canvas.SetLeft(element, 10);
                Canvas.SetTop(element, 10);
            }
        }
    }
}
