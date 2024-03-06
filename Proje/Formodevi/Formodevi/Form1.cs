using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** PROGRAMLAMAYA GİRİŞİ DERSİ
**
** ÖDEV NUMARASI…...:G211210035
** ÖĞRENCİ ADI......:ASUDE YURT
** ÖĞRENCİ NUMARASI.:
** DERS GRUBU…………:2C
YOUTUBE LİNKİ… …:https://youtu.be/ENcBl5vxut4 
****************************************************************************/


namespace Formodevi
{
    public partial class Form1 : Form
    {
        private Random random = new Random(); // Random sayı atamak için
        private int shapeIndex = 0;  // Seçtiğimiz şekili tutan değişken 
        
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Point"); // Combobox' a şekiller eklendi
            comboBox1.Items.Add("Circle");
            comboBox1.Items.Add("Rectangle");
            comboBox1.Items.Add("Rectangle Prism");

            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            shapeIndex = comboBox1.SelectedIndex;  // Seçtiğimiz şekli takip eden metot

            Invalidate();

        }
     private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawShape(e.Graphics);
        }
       private void DrawShape(Graphics g)
        {
            switch (shapeIndex)
            {
                case 0:   // Nokta oluşturma
                    int pointX = random.Next(0, Width);  // Point sınıfını, oluşturulan noktanın koordinatlarını tutmak için kullandım.
                    int pointY = random.Next(0, Height);
                    Point point = new Point(pointX, pointY); 
                    g.FillRectangle(Brushes.Black, pointX, pointY,3,3);


                    break;

                case 1:
                    int circle_X = random.Next(0, Width - 50);  // Çember oluşturma
                    int circle_Y = random.Next(0, Height - 50); // Ekranın dışına taşmasın diye böyle yazdım
                    int circleWidth = random.Next(10, 50);
                    int circleHeight = circleWidth;
                    Pen pen = new Pen(Color.Red, 2f); // Kalem oluşturdum.
                    Rectangle circle = new Rectangle(circle_X, circle_Y, circleWidth, circleHeight);//Dikdörtgen sınıfından çember oluşturdum.
                    g.DrawEllipse(pen, circle);


                    break;


                case 2:
                    int rect_X = random.Next(0, Width - 50);  // Dikdörtgen oluşturma
                    int rect_y = random.Next(0, Height - 50);
                    int rectWidth = random.Next(10, 50);
                    int rectHeight = random.Next(10, 50);
                    Pen pen1 = new Pen(Color.Green, 2f);
                    Rectangle rectangle = new Rectangle(rect_X, rect_y, rectWidth, rectHeight);
                    g.DrawRectangle(pen1, rectangle);
                    break;


                case 3:

                    int object_X = random.Next(0, Width - 50); // Dikdörtgen prizma oluşturma
                    int object_Y = random.Next(0, Height - 50);
                    int object_Width = random.Next(10, 50);
                    int object_Length = random.Next(10, 50);
                    int object_Height = random.Next(10, 50);
                    Pen pen3 = new Pen(Color.Red, 2f);
                    Rectangle prism = new Rectangle(object_X, object_Y, object_Width, object_Height);
                    g.DrawRectangle(pen3, prism);
                   
                    g.DrawLine(pen3, object_X, object_Y, object_X + object_Length, object_Y - object_Length);// sol üst kenar
                    g.DrawLine(pen3, object_X + object_Length, object_Y - object_Length, object_X + object_Width + object_Length, object_Y - object_Length);//  üst arka genişliği
                    g.DrawLine(pen3, object_X + object_Width + object_Length, object_Y - object_Length, object_X + object_Width, object_Y);// sağ üst kenar
                    g.DrawLine(pen3, object_X + object_Width + object_Length, object_Y - object_Length, object_X + object_Width + object_Length, object_Y - object_Length + object_Height);// Sağ arka kenar
                    g.DrawLine(pen3, object_X + object_Width + object_Length, object_Y - object_Length + object_Height, object_X + object_Width, object_Y + object_Height);// sAĞ ALT KENAR 

                    break;


                default:

                    break;





            }




        }

       
    }
}
