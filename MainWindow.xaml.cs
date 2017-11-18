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

namespace Braille
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public void DrawBrailleChar(char c, ref int pos, int prev = -1)
		{
			if (c == ' ')
			{
				pos++;
				return;
			}

			int lead = getLead(c);
			int medial = getMedial(c);
			int tail = getTail(c);

			if (false) { }
			else if (lead == 0)
			{
				DrawCharacter(ref pos, new List<int> { 4 });
			}
			else if (lead == 1)
			{
				DrawCharacter(ref pos, new List<int> { 6 });
				DrawCharacter(ref pos, new List<int> { 4 });
			}
			else if (lead == 2)
			{
				DrawCharacter(ref pos, new List<int> { 1, 4 });
			}
			else if (lead == 3)
			{
				DrawCharacter(ref pos, new List<int> { 2, 4 });
			}
			else if (lead == 4)
			{
				DrawCharacter(ref pos, new List<int> { 6 });
				DrawCharacter(ref pos, new List<int> { 2, 4 });
			}
			else if (lead == 5)
			{
				DrawCharacter(ref pos, new List<int> { 5 });
			}
			else if (lead == 6)
			{
				DrawCharacter(ref pos, new List<int> { 1, 5 });
			}
			else if (lead == 7)
			{
				DrawCharacter(ref pos, new List<int> { 4, 5 });
			}
			else if (lead == 8)
			{
				DrawCharacter(ref pos, new List<int> { 6 });
				DrawCharacter(ref pos, new List<int> { 4, 5 });
			}
			else if (lead == 9)
			{
				DrawCharacter(ref pos, new List<int> { 6 });
			}
			else if (lead == 10)
			{
				DrawCharacter(ref pos, new List<int> { 6 });
				DrawCharacter(ref pos, new List<int> { 6 });
			}
			else if (lead == 11)
			{
				//DrawCharacter(ref pos, new List<int> { 1, 2, 4, 5 });
			}
			else if (lead == 12)
			{
				DrawCharacter(ref pos, new List<int> { 4, 6 });
			}
			else if (lead == 13)
			{
				DrawCharacter(ref pos, new List<int> { 6 });
				DrawCharacter(ref pos, new List<int> { 4, 6 });
			}
			else if (lead == 14)
			{
				DrawCharacter(ref pos, new List<int> { 5, 6 });
			}
			else if (lead == 15)
			{
				DrawCharacter(ref pos, new List<int> { 1, 2, 4 });
			}
			else if (lead == 16)
			{
				DrawCharacter(ref pos, new List<int> { 1, 2, 5 });
			}
			else if (lead == 17)
			{
				DrawCharacter(ref pos, new List<int> { 1, 4, 5 });
			}
			else if (lead == 18)
			{
				DrawCharacter(ref pos, new List<int> { 2, 4, 5 });
			}

			if (false) { }
			else if (medial == 0)
			{
				DrawCharacter(ref pos, new List<int> { 1, 2, 6 });
			}
			else if (medial == 1)
			{
				int prevMedial = getMedial(c);
				if (getTail(prev) == 0 && (prevMedial == 2 || prevMedial == 9 || prevMedial == 13 || prevMedial == 15))
				{
					DrawCharacter(ref pos, new List<int> { 3, 6 });
				}
				DrawCharacter(ref pos, new List<int> { 1, 2, 3, 5 });
			}
			else if (medial == 2)
			{
				DrawCharacter(ref pos, new List<int> { 3, 4, 5 });
			}
			else if (medial == 3)
			{
				DrawCharacter(ref pos, new List<int> { 3, 4, 5 });
				DrawCharacter(ref pos, new List<int> { 1, 2, 3, 5 });
			}
			else if (medial == 4)
			{
				DrawCharacter(ref pos, new List<int> { 2, 3, 4 });
			}
			else if (medial == 5)
			{
				DrawCharacter(ref pos, new List<int> { 1, 3, 4, 5 });
			}
			else if (medial == 6)
			{
				DrawCharacter(ref pos, new List<int> { 1, 5, 6 });
			}
			else if (medial == 7)
			{
				if (getTail(prev) == 0)
				{
					DrawCharacter(ref pos, new List<int> { 3, 6 });
				}
				DrawCharacter(ref pos, new List<int> { 3, 4 });
			}
			else if (medial == 8)
			{
				DrawCharacter(ref pos, new List<int> { 1, 3, 6 });
			}
			else if (medial == 9)
			{
				DrawCharacter(ref pos, new List<int> { 1, 2, 3, 6 });
			}
			else if (medial == 10)
			{
				DrawCharacter(ref pos, new List<int> { 1, 2, 3, 6 });
				DrawCharacter(ref pos, new List<int> { 1, 2, 3, 5 });
			}
			else if (medial == 11)
			{
				DrawCharacter(ref pos, new List<int> { 1, 3, 4, 5, 6 });
			}
			else if (medial == 12)
			{
				DrawCharacter(ref pos, new List<int> { 3, 4, 6 });
			}
			else if (medial == 13)
			{
				DrawCharacter(ref pos, new List<int> { 1, 3, 4 });
			}
			else if (medial == 14)
			{
				DrawCharacter(ref pos, new List<int> { 1, 2, 3, 4 });
			}
			else if (medial == 15)
			{
				DrawCharacter(ref pos, new List<int> { 1, 2, 3, 4 });
				DrawCharacter(ref pos, new List<int> { 1, 2, 3, 5 });
			}
			else if (medial == 16)
			{
				DrawCharacter(ref pos, new List<int> { 1, 3, 4 });
				DrawCharacter(ref pos, new List<int> { 1, 2, 3, 5 });
			}
			else if (medial == 17)
			{
				DrawCharacter(ref pos, new List<int> { 1, 4, 6 });
			}
			else if (medial == 18)
			{
				DrawCharacter(ref pos, new List<int> { 2, 4, 6 });
			}
			else if (medial == 19)
			{
				DrawCharacter(ref pos, new List<int> { 2, 4, 5, 6 });
			}
			else if (medial == 20)
			{
				DrawCharacter(ref pos, new List<int> { 1, 3, 5 });
			}

			if (false) { }
			else if (tail == 0)
			{
			}
			else if (tail == 1)
			{
				DrawCharacter(ref pos, new List<int> { 1 });
			}
			else if (tail == 2)
			{
				DrawCharacter(ref pos, new List<int> { 1 });
				DrawCharacter(ref pos, new List<int> { 1 });
			}
			else if (tail == 3)
			{
				DrawCharacter(ref pos, new List<int> { 1 });
				DrawCharacter(ref pos, new List<int> { 6 });
			}
			else if (tail == 4)
			{
				DrawCharacter(ref pos, new List<int> { 2, 5 });
			}
			else if (tail == 5)
			{
				DrawCharacter(ref pos, new List<int> { 2, 5 });
				DrawCharacter(ref pos, new List<int> { 1, 3 });
			}
			else if (tail == 6)
			{
				DrawCharacter(ref pos, new List<int> { 2, 5 });
				DrawCharacter(ref pos, new List<int> { 3, 5, 6 });
			}
			else if (tail == 7)
			{
				DrawCharacter(ref pos, new List<int> { 3, 5 });
			}
			else if (tail == 8)
			{
				DrawCharacter(ref pos, new List<int> { 2 });
			}
			else if (tail == 9)
			{
				DrawCharacter(ref pos, new List<int> { 2 });
				DrawCharacter(ref pos, new List<int> { 1 });
			}
			else if (tail == 10)
			{
				DrawCharacter(ref pos, new List<int> { 2 });
				DrawCharacter(ref pos, new List<int> { 2, 6 });
			}
			else if (tail == 11)
			{
				DrawCharacter(ref pos, new List<int> { 2 });
				DrawCharacter(ref pos, new List<int> { 1, 2 });
			}
			else if (tail == 12)
			{
				DrawCharacter(ref pos, new List<int> { 2 });
				DrawCharacter(ref pos, new List<int> { 3 });
			}
			else if (tail == 13)
			{
				DrawCharacter(ref pos, new List<int> { 2 });
				DrawCharacter(ref pos, new List<int> { 2, 3, 6 });
			}
			else if (tail == 14)
			{
				DrawCharacter(ref pos, new List<int> { 2 });
				DrawCharacter(ref pos, new List<int> { 2, 5, 6 });
			}
			else if (tail == 15)
			{
				DrawCharacter(ref pos, new List<int> { 2 });
				DrawCharacter(ref pos, new List<int> { 3, 5, 6 });
			}
			else if (tail == 16)
			{
				DrawCharacter(ref pos, new List<int> { 2, 6 });
			}
			else if (tail == 17)
			{
				DrawCharacter(ref pos, new List<int> { 1, 2 });
			}
			else if (tail == 18)
			{
				DrawCharacter(ref pos, new List<int> { 1, 2 });
				DrawCharacter(ref pos, new List<int> { 3 });
			}
			else if (tail == 19)
			{
				DrawCharacter(ref pos, new List<int> { 3 });
			}
			else if (tail == 20)
			{
				DrawCharacter(ref pos, new List<int> { 3, 4 });
			}
			else if (tail == 21)
			{
				DrawCharacter(ref pos, new List<int> { 2, 3, 5, 6 });
			}
			else if (tail == 22)
			{
				DrawCharacter(ref pos, new List<int> { 1, 3 });
			}
			else if (tail == 23)
			{
				DrawCharacter(ref pos, new List<int> { 2, 3 });
			}
			else if (tail == 24)
			{
				DrawCharacter(ref pos, new List<int> { 2, 3, 5 });
			}
			else if (tail == 25)
			{
				DrawCharacter(ref pos, new List<int> { 2, 3, 6 });
			}
			else if (tail == 26)
			{
				DrawCharacter(ref pos, new List<int> { 2, 5, 6 });
			}
			else if (tail == 27)
			{
				DrawCharacter(ref pos, new List<int> { 3, 5, 6 });
			}
		}

		private int getLead(int c)
		{
			return ((c - 44032) / 588);
		}

		private int getMedial(int c)
		{
			return ((c - 44032 - getTail(c)) % 588) / 28;
		}

		private int getTail(int c)
		{
			return (c - 44032) % 28;
		}

		private void DrawCharacter(ref int pos, List<int> posLst)
		{
			DrawTopLeft(pos, posLst.Contains(1));
			DrawMidLeft(pos, posLst.Contains(2));
			DrawBotLeft(pos, posLst.Contains(3));
			DrawTopRight(pos, posLst.Contains(4));
			DrawMidRight(pos, posLst.Contains(5));
			DrawBotRight(pos, posLst.Contains(6));
			pos++;
		}

		private void DrawTopLeft(int pos, bool fill = true)
		{
			Ellipse circle = new Ellipse();
			circle.Width = 15;
			circle.Height = 15;
			circle.Fill = fill ? Brushes.Black : Brushes.White;
			circle.StrokeThickness = 1;
			circle.Stroke = Brushes.Black;
			circle.Margin = new Thickness(5);
			Canvas.SetLeft(circle, (2 * pos) * (circle.Width + circle.Margin.Left + circle.Margin.Right));
			Canvas.SetTop(circle, 0);

			outputBox.Children.Add(circle);
		}
		private void DrawTopRight(int pos, bool fill = true)
		{
			Ellipse circle = new Ellipse();
			circle.Width = 15;
			circle.Height = 15;
			circle.Fill = fill ? Brushes.Black : Brushes.White;
			circle.StrokeThickness = 1;
			circle.Stroke = Brushes.Black;
			circle.Margin = new Thickness(5);
			Canvas.SetLeft(circle, (2 * pos + 1) * (circle.Width + circle.Margin.Left + circle.Margin.Right));
			Canvas.SetTop(circle, 0);

			outputBox.Children.Add(circle);
		}
		private void DrawMidLeft(int pos, bool fill = true)
		{
			Ellipse circle = new Ellipse();
			circle.Width = 15;
			circle.Height = 15;
			circle.Fill = fill ? Brushes.Black : Brushes.White;
			circle.StrokeThickness = 1;
			circle.Stroke = Brushes.Black;
			circle.Margin = new Thickness(5);
			Canvas.SetLeft(circle, (2 * pos) * (circle.Width + circle.Margin.Left + circle.Margin.Right));
			Canvas.SetTop(circle, circle.Height + circle.Margin.Top + circle.Margin.Bottom);

			outputBox.Children.Add(circle);
		}
		private void DrawMidRight(int pos, bool fill = true)
		{
			Ellipse circle = new Ellipse();
			circle.Width = 15;
			circle.Height = 15;
			circle.Fill = fill ? Brushes.Black : Brushes.White;
			circle.StrokeThickness = 1;
			circle.Stroke = Brushes.Black;
			circle.Margin = new Thickness(5);
			Canvas.SetLeft(circle, (2 * pos + 1) * (circle.Width + circle.Margin.Left + circle.Margin.Right));
			Canvas.SetTop(circle, circle.Height + circle.Margin.Top + circle.Margin.Bottom);

			outputBox.Children.Add(circle);
		}
		private void DrawBotLeft(int pos, bool fill = true)
		{
			Ellipse circle = new Ellipse();
			circle.Width = 15;
			circle.Height = 15;
			circle.Fill = fill ? Brushes.Black : Brushes.White;
			circle.StrokeThickness = 1;
			circle.Stroke = Brushes.Black;
			circle.Margin = new Thickness(5);
			Canvas.SetLeft(circle, (2 * pos) * (circle.Width + circle.Margin.Left + circle.Margin.Right));
			Canvas.SetTop(circle, 2 * (circle.Height + circle.Margin.Top + circle.Margin.Bottom));

			outputBox.Children.Add(circle);
		}
		private void DrawBotRight(int pos, bool fill = true)
		{
			Ellipse circle = new Ellipse();
			circle.Width = 15;
			circle.Height = 15;
			circle.Fill = fill ? Brushes.Black : Brushes.White;
			circle.StrokeThickness = 1;
			circle.Stroke = Brushes.Black;
			circle.Margin = new Thickness(5);
			Canvas.SetLeft(circle, (2 * pos + 1) * (circle.Width + circle.Margin.Left + circle.Margin.Right));
			Canvas.SetTop(circle, 2 * (circle.Height + circle.Margin.Top + circle.Margin.Bottom));

			outputBox.Children.Add(circle);
		}

		private void inputBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			TextBox inputBox = (TextBox)sender;
			int pos = 0;

			outputBox.Children.Clear();
			foreach (char c in inputBox.Text)
			{
				DrawBrailleChar(c, ref pos);
			}
		}
	}
}
