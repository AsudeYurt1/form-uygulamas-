using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** PROGRAMLAMAYA GİRİŞİ DERSİ
**
** ÖDEV NUMARASI…...:1
** ÖĞRENCİ ADI...............:ASUDE YURT
** ÖĞRENCİ NUMARASI.:G211210035
** DERS GRUBU…………:2C
YOUTUBE LİNKİ:https://youtu.be/ENcBl5vxut4 
****************************************************************************/



namespace ndpodev
{
    
    public static class Collision_test  // Statik sınıf oluşturdum.
    {

        public static void Point_Rectangle() //Nokta-dikdörtgen çarpışma kontrolü
        {
            Random random = new Random(); // Değerleri random atadım 
            int x = random.Next(0, 20);
            int y = random.Next(0, 20);

            Console.WriteLine("x :" + x);
            Console.WriteLine("y :" + y);


            Console.WriteLine("Coordinate of the point :" + "x :" + x +"  "+ " y : "  + y);
            Console.WriteLine("Coordinate of the rectangle A(2,3), B(6,3), C(2,-3) , D(6,-3) ");

            if(x==2|| x==6 && (y >=-3 && y<= 3))  // Çarpışma kontrolü
            {

                Console.WriteLine("There has been a collision ."); // Kesişim var
            }

            else if(y==-3 && y ==3 && (x>=2 && x <= 6))
            {

                Console.WriteLine("There has been a collision.");
            }

            else
            {

                Console.WriteLine("There was no collision."); // Kesişim yok 
            }




        }

        public static void Point_RectanglePrism() // Nokta-Dikdörtgen Prizma çarpışma kontrolü
        {
            Random random = new Random();
            int x = random.Next(0, 20);
            int y = random.Next(0, 20);
            int z = random.Next(0, 20);

            Console.WriteLine("x :" + x); // Noktanın koordinatları
            Console.WriteLine("y :" + y);
            Console.WriteLine("z :" + z);

            Console.WriteLine("Coordinate of the point :" + "( "+"x :" + x + "  " + " y : " + y+ " "+"z : "+ z+ ")");

            int rect_length = 10;
            int rect_width = 5; // Dikdörtgenin bilgilerini kendim verdim
            int height = 3;

            Console.WriteLine("Rectangular Prism :" + " " + "Length :" + rect_length + " "+ "Width :" + rect_width + " "+ "height :" + height);

            if(x>=0 && x<= rect_length && // Kesişim kontrolü
                x>=0 && x<= rect_width &&
                 x>=0 && x<= height)
            {

                Console.WriteLine("There has been a collision.");

            }

            else
            {
                Console.WriteLine("There was no collision ");
            }




        }
        public static void Point_Circle() // Nokta-Çember kesişim kontrolü
        {
            Random random = new Random();
            int x = random.Next(0, 20);
            int y = random.Next(0, 20);
            int radius = 5;
            Console.WriteLine("Coordinate of the point :" + "x :" + x + "  " + " y : " + y);
            Console.WriteLine("Coordinate of the center of the circle O(0,0) radius = 5 cm."); // Çemberin bilgilerini ben verdim
            double a = Math.Pow(x - 0, 2); // Noktanın çemberin merkezine olan uzaklığı
            double b = Math.Pow(y - 0, 2);

            if (Math.Sqrt(a + b) == radius)
            {
                Console.WriteLine("There has been a collision.");
            }
            else
            {
                Console.WriteLine("There was no collision ");
            }
        }

        public static void Point_Sphere() // Nokta-küre kesişim kontrolü
        {
            Random random = new Random();
            int x = random.Next(0, 20); //Noktanın koordinatları
            int y = random.Next(0, 20);
            int z = random.Next(0, 20);

            Console.WriteLine("Coordinate of the point :" + "( " + "x :" + x + "  " + " y : " + y + " " + "z : " + z + ")");
            Console.WriteLine("Coordinate of the center of the sphere O(0,0,0) radius = 10 cm"); //Kürenin bilgilerini ben verdim
            int r=10;
            double a = Math.Pow(x - 0, 2); //Noktanın kürenin merkezine olan uzaklığı
            double b = Math.Pow(y - 0, 2);
            double c = Math.Pow(z - 0, 2);
            if (Math.Sqrt(a+b+c)==r)  // Kesişim kontrolü
            {

                Console.WriteLine("There has been a collision.");


            }
            else
            {
                Console.WriteLine("There was no collision ");
            }


        }

        public static void Point_Clinder() // Nokta-Silindir kesişim kontrolü
        {
            Random random = new Random();
            int x = random.Next(0, 20); 
            int y = random.Next(0, 20);
            int z = random.Next(0, 20);

            Console.WriteLine("Coordinate of the point :" + "( " + "x :" + x + "  " + " y : " + y + " " + "z : " + z + ")");
            int r = 2;
            int h = 10; // Silindirin bilgilerini ben verdim.
            Console.WriteLine("The center of the clinder O(0,0,5), radius = 2 cm , height = 10 cm");
            double centerx = 0, centery = 0, centerz = h / 2;

            double distance = Math.Sqrt((x - centerx) * (x - centerx) + (y - centery) * (y - centery) + (z - centerz));//Noktanın silindirin merkezine olan uzaklığı

            if (distance<=r && z <= h && z >= 0)
            {

                Console.WriteLine("There has been a collision.");

            }
            else
            {
                Console.WriteLine("There was no collision ");
            }


        }

        public static void Rect_Rect() // Dikdörtgen-Dikdörtgen kesişim kontrolü
        {
            Random random = new Random();
            int rect1_x = random.Next(0, 5); // 1. dikdörtgenin sol üst köşesinin x koordinatı
            int rect1_y = random.Next(0, 5); //  1. dikdörtgenin sol üst köşesinin x koordinatı
            int rect1_width = random.Next(5, 8); // Genişliği
            int rect1_height = random.Next(8, 10); // Yüksekliği


            int rect2_x = random.Next(5, 10); // 2. dikdörtgenin sol üst köşesinin x koordinatı
            int rect2_y = random.Next(5, 10); //2. dikdörtgenin sol üst köşesinin y koordinatı
            int rect2_width = random.Next(3,5); // Genişiliği
            int rect2_height = random.Next(3, 10);// Yüksekliği
            int rect1_right = rect1_x + rect1_width; // 1.dikdörtgenin sağ x koordinatı
            int rect1_bottom = rect1_y + rect1_height; // 1. dikdörtgenin alt kenarının y koordinatı
            int rect2_right = rect2_x + rect2_width;// 2.dikdörtgenin sağ x koordinatı
            int rect2_bottom = rect2_y + rect2_width;// 2. dikdörtgenin alt kenarının y koordinatı
            Console.WriteLine("x value of the top of the corner of the first rectangle =" + rect1_x + "  y value = " + rect1_y + " width = " + rect1_width + " height = " + rect1_height);
            Console.WriteLine("x value of the top of the corner of the second rectangle  =" + rect2_x + "  y value = " + rect2_y + " width = " + rect2_width + " height = " + rect2_height);

            if (rect1_x< rect2_right&&rect1_right>rect2_x&&
                rect1_y<rect2_bottom&& rect1_bottom>rect2_y)
            {

                Console.WriteLine("There has been a collision.");


            }
            else
            {
                Console.WriteLine("There was no collision ");
            }

        }

        public static void Rect_Circle() // Dikdörtgen-Çmeber kesişim kontrolü
        {
            Random random = new Random();
            int rectx = random.Next(0, 10); // Dikdörtgenin sol üst köşesinin koordinatları
            int recty = random.Next(0, 10);
            int width = random.Next(3, 10);
            int height = random.Next(3, 10);

            int centerx = random.Next(0, 10); // Çemberin de bilgileri random atandı
            int centery = random.Next(0, 10);
            int r = random.Next(3, 8);

            Console.WriteLine("x value of the top of the corner of the first rectangle =" + rectx + "  y value = " + recty + " width = " + width + " height = " + height);
            Console.WriteLine("center of the circle :" + "(" + centerx + ", " + centery + ") " + "radius = " + r);

            // Dikdörtgenin kenarlarıyla çemberin merkezi arasındaki mesafe
            double distx = Math.Abs(centerx -rectx - width   / 2);
            double disty = Math.Abs(centery -recty - height   / 2);
            // Dikdörtgen ve çember arasındaki mesafe
            double distance = Math.Pow(distx - width / 2, 2) + Math.Pow(disty - height / 2, 2);


            if(distance < Math.Pow(r, 2)) // Eğer köşe mesafesi çember yarıçapından küçükse, dikdörtgen ve çember kesişiyor demektir.
            {
                Console.WriteLine("There has been a collision.");

            }
            else
            {

                Console.WriteLine("There was no collision ");

            }
        }

        public static void Circle_Circle() //Çember - çember kesişim kontrolü
        {
            Random random = new Random();
            int r1 = random.Next(3, 10);
            int center1_x = random.Next(0, 10);//1. çemberin merkez noktasının x koordinatı
            int center1_y = random.Next(0, 10); ///1. çemberin merkez noktasının y koordinatı

            int r2 = random.Next(3, 10);
            int center2_x = random.Next(0, 10);
            int center2_y = random.Next(0, 10);
            Console.WriteLine(" The center of the first circle :" + " x :" + center1_x + "  y value : " + center1_y + " r = " + r1);
            Console.WriteLine(" The center of the second circle :" + " x :" + center2_x + "  y value : " + center2_y + " r = " + r2);
            double distance = Math.Sqrt(Math.Pow(center1_x - center2_x,2) + Math.Pow(center1_y - center2_y,2));// İki çemberin merkezlerinin birbirleriyle olan mesafesi

            if (distance<= r1 + r2) // Aradaki mesafe yarıçapları toplamından küçük veya eşitse kesişim var.
            {

                Console.WriteLine("There has been a collision.");

            }
            else
            {
                Console.WriteLine("There was no collision ");
            }
        }

        public static void Clinder_Clinder()// Silindir - silindir kesişim kontrolü 
        {
            Random random = new Random();
            int r1 = random.Next(3, 10); // 1. silindirin bilgileri
            int h1 = random.Next(3,10);
            int r2 = random.Next(3, 10); //  2. silindirin bilgileri
            int h2 = random.Next(3, 10);

            Console.WriteLine("1st radius : "  + r1 + "  height :" + h1);
            Console.WriteLine("2nd radius : "  + r2 + "  height :" + h2);

            double distance = Math.Sqrt(Math.Pow(r1 + r2, 2) + Math.Pow(h1 + h2, 2)); // Silindirlerin merkezleri arasındaki uzaklık

            if ( distance<= r1 + r2)// Bu mesafe silindirlerin yarıçaplarının toplamından küçük eşitse kesişim olur.
            {

                Console.WriteLine("There has been a collision."); 


            }
            else
            {
                Console.WriteLine("There was no collision ");
            }



        }

        public static void Sphere_Sphere()// Küre - küre kesişim kontrolü 
        {
            Random random = new Random();
            int x1 = random.Next(0, 10);// 1. kürenin merkez koordinatları ve yarıçapı
            int y1 = random.Next(0, 10);
            int z1 = random.Next(0, 10);
            int r1 = random.Next(3, 10);

            int x2 = random.Next(0, 10);// 2. kürenin merkez koordinatları ve yarıçapı
            int y2 = random.Next(0, 10);
            int z2 = random.Next(0, 10);
            int r2 = random.Next(3, 10);

            Console.WriteLine("1st sphere center coordinate :" + "(" + x1 + "," + y1 + "," + z1 + ") " + " r = " + r1);
            Console.WriteLine("2nd sphere center coordinate :" + "(" + x2 + "," + y2 + "," + z2 + ") " + " r = " + r2);

            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));// İki kürenin merkezleri arasındaki mesafe 

            if (distance <= r1 + r2) // bu mesafe iki kürenin yarıçapları toplamından küçük veya eşitse kesişim olur.
            {

                Console.WriteLine("There has been a collision.");

            }
            else
            {
                Console.WriteLine("There was no collision ");
            }
        
        }

        public static void Sphere_Clinder()// Küre - silindir kesişim kontrolü 
        {
            Random random = new Random();
            int x1 = random.Next(0, 10);// Kürenin merkezinin koordinatları ve yarıçapı
            int y1 = random.Next(0, 10);
            int z1 = random.Next(0, 10);
            int r1 = random.Next(4, 10);

            int x2 = random.Next(0, 10); // Silindirin merkez koordinatları yarıçapı ve yüksekliği 
            int y2 = random.Next(0, 10);
            int z2 = random.Next(0, 10);
            int r2 = random.Next(4, 10);
            int h = random.Next(5, 10);
            Console.WriteLine("Sphere center coordinate : " + "(" + x1 + "," + y1 + "," + z1 + ") " + " r = " + r1);
            Console.WriteLine("Clinder center coordinate : " + "(" + x2 + "," + y2 + "," + z2 + ") " + " r = " + r2+ " h = "+h);

            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));// Cisimlerin merkezlerinin biribirine uzaklığı

            if (distance<=r1+r2 && z2<= (z1+h)/2 && z2 >= (z1 - h) / 2)
            {

                Console.WriteLine("There has been a collision.");

            }
            else
            {
                Console.WriteLine("There was no collision ");

            }
        }

        public static void Sphere_RectPrism() //Küre - dikdörtgen prizma kesişim kontrolü
        {
            Random random = new Random();
            int x1 = random.Next(0, 10);// Kürenin merkezinin koordinatları ve yarıçapı
            int y1 = random.Next(0, 10);
            int z1 = random.Next(0, 10);
            int r1 = random.Next(4, 10);

            int length = random.Next(4, 10); // Dikdörtgen prizmanın bilgileri
            int width = random.Next(4, 10);
            int height = random.Next(4, 10);

            Console.WriteLine(" Sphere center coordinate : " + "(" + x1 + "," + y1 + "," + z1 + ") " + " r = " + r1);
            Console.WriteLine("Rectangular Prism : " + " length : " + length + " width : " + width + " height : " + height);
            // Kürenin prizmaya olan uzaklığı 
            double dıstX = Math.Abs(x1 - length / 2); // Prizmanın x eksindeki uzaklığı 
            double dıstY = Math.Abs(y1 - width / 2);// Prizmanın y eksindeki uzaklığı 
            double dıstZ = Math.Abs(z1 - height / 2);// Prizmanın z eksindeki uzaklığı 

            double distance = Math.Sqrt(Math.Pow(dıstX, 2) + Math.Pow(dıstY, 2) + Math.Pow(dıstZ, 2));// prizmanın yüzeyine olan toplam uzaklık   

            if ( distance <= r1)// eğer uzaklık kürenin yarıçapından küçük veya eşitse, kesim vardır
            {
                Console.WriteLine("There has been a collision.");
            }
            else
            {
                Console.WriteLine("There was no collision ");
            }

        }

        public static void Surface_Sphere()// Yüzey küre kesişim kontrolü 
        {
            Random random = new Random();
            int surface_x = random.Next(0, 10);
            int surface_y = random.Next(0, 10);
            int surface_r = random.Next(5, 10);

            int x_sphere = random.Next(0, 10);// Kürenin merkezinin koordinatları ve yarıçapı
            int y_sphere = random.Next(0, 10);
            int z_sphere = random.Next(0, 10);
            int r_sphere = random.Next(4, 10);

            Console.WriteLine("Surface x coordinate : " + surface_x + " y coordinate : " + surface_y + " r =" + surface_r);
            Console.WriteLine("Sphere center of the coordinate : " + "(" + x_sphere + "," + y_sphere + "," + z_sphere +")"+ " r = " + r_sphere);
            // Küreyle yüzey arasındaki uzaklık 
            double distance = Math.Sqrt(Math.Pow(surface_x - x_sphere, 2) + Math.Pow(surface_y - y_sphere, 2));// Kürenin yüzeyin merkezine olan uzaklığı

            if (distance <= r_sphere + surface_r)//Aralarındaki uzaklık ikisinin yarıçapından küçük veya eşitse kesişim vardır.
            {
                Console.WriteLine("There has been a collision.");
            }
            else
            {
                Console.WriteLine("There was no collision ");
            }

        }

        public static void Surface_RectPrism()// Yüzey - dikdörtgen prizma kesişim kontrolü
        {
            Random random = new Random();
            int surface_x1 = random.Next(0, 10); // Yüzeyin bilgileri
            int surface_x2 = random.Next(0, 10);
            int surface_y1 = random.Next(0, 10);
            int surface_y2 = random.Next(0, 10);

            int prism_x1 = random.Next(0, 10);// Dikdörtgen prizmanın bilgileri 
            int prism_x2 = random.Next(0, 10);
            int prism_y1 = random.Next(0, 10);
            int prism_y2 = random.Next(0, 10);

            Console.WriteLine("x coordinates of the surface : " + "  x1 : " + surface_x1 + " x2:" + surface_x2);
            Console.WriteLine("y coordinates of the surface : " + "  y1 : " + surface_y1 + " y2:" + surface_y2);

            Console.WriteLine("x coordinates of the renctangular prism : " + " x1: " + prism_x1 + " x2 :" + prism_x2);
            Console.WriteLine("y coordinates of the renctangular prism : " + " y1: " + prism_y1 + " y2 :" + prism_y2);


            if (!(surface_x2 < prism_x1 || surface_x1 > prism_x2 || surface_y2 < prism_y1 || surface_y1 > prism_y2)){

                Console.WriteLine("There has been a collision.");
            }
            else
            {
                Console.WriteLine("There was no collision ");
            }

        }


        public static void Surface_Clinder()// Yüzey - silindir kesişim kontrolü
        {
            Random random = new Random();   // Yüzeyi iki boyutlu olarak düşündüm.
            int surface_x1 = random.Next(0, 10); // Yüzeyin bilgileri
            int surface_x2 = random.Next(0, 10);
            int surface_y1 = random.Next(0, 10);
            int surface_y2 = random.Next(0, 10);

            int clinder_x = random.Next(0, 10); // Silindirin merkez koordinatı ve yarıçapı
            int clinder_y = random.Next(0, 10);
            int clinder_r = random.Next(4, 10);

            Console.WriteLine("x coordinates of the surface : " + "  x1 : " + surface_x1 + " x2:" + surface_x2);
            Console.WriteLine("y coordinates of the surface : " + "  y1 : " + surface_y1 + " y2:" + surface_y2);

            Console.WriteLine("Center of the clinder : " + "(" + clinder_x + "," + clinder_y + ")" + "r : " + clinder_r);

            if (clinder_x + clinder_r< surface_x1 || clinder_x - clinder_r > surface_x2 // Yüzey ve silindirin kesişme kontrolü
                || clinder_y + clinder_r < surface_y1 || clinder_y - clinder_r> surface_y2)
            {

                Console.WriteLine("There was no collision .");
            }

            else
            {
                double distance = Math.Sqrt(Math.Pow(clinder_x - (surface_x1 + surface_x2 / 2), 2) + Math.Pow(clinder_y - (surface_y1 + surface_y2 / 2), 2));

                if (distance <= clinder_r)// silindirin merkeziyle yüzeyin merkezinin biribirine olan uzaklığı silindirin yarıçapından küçük veya eşitse kesişim var.
                {
                    Console.WriteLine("There has been a collision");

                }
                else
                {
                    Console.WriteLine("There was no collision.");
                }
            }

        }

        public static void Quadrangular()// Dikdörtgen prizma - dikdörtgen prizma kesişim kontrolü fonksiyonu 
        {
            Random random = new Random();
            int prism1_x1 = random.Next(0, 10); // 1. dikdörtgenler prizmasının bilgileri 
            int prism1_x2 = random.Next(0, 10);
            int prism1_y1 = random.Next(0, 10);
            int prism1_y2 = random.Next(0, 10);
            int prism1_z1 = random.Next(0, 10);
            int prism1_z2 = random.Next(0, 10);

            int prism2_x1 = random.Next(0, 10); // 2. dikdörtgenler prizmasının bilgileri 
            int prism2_x2 = random.Next(0, 10);
            int prism2_y1 = random.Next(0, 10);
            int prism2_y2 = random.Next(0, 10);
            int prism2_z1 = random.Next(0, 10);
            int prism2_z2 = random.Next(0, 10);

            Console.WriteLine("First rectangular prism : " + " x1: " + prism1_x1 + " x2 :" + prism1_x2 + " y1 :" + prism1_y1 + " y2 :" + prism1_y2 + " z1 :" + prism1_z1 + " z2:" + prism1_z2);
            Console.WriteLine("Second rectangular prism : " + " x1: " + prism2_x1 + " x2 :" + prism2_x2 + " y1 :" + prism2_y1 + " y2 :" + prism2_y2 + " z1 :" + prism2_z1 + " z2:" + prism2_z2);
        
        
         if((prism1_x1 > prism2_x2 || prism2_x1 > prism1_x2 ||
                prism1_y1 > prism2_y2 || prism2_y1 > prism1_y2 ||
                prism1_z1 > prism2_z2 || prism2_z1 > prism1_z2))
            {

                Console.WriteLine("There was no collision.");
            }
            else
            {
                Console.WriteLine("There has been a collision");
            }
        
        
        }
    }
    
    
    
    
    class Program
    {
        static void Main(string[] args)
        {

            int choice;
            string answer;

            do   // Kullanıcı istediğinde menüye tekrar dönebilsen diye do- while döngüsü kullandım.
            {  

                Console.WriteLine("1 => For the point ");   // Çarpışmaları düzenli olması adına menü şeklinde yazdım.
                Console.WriteLine("2 => For the rectangle ");
                Console.WriteLine("3 => For the circle ");
                Console.WriteLine("4 => For the clinder ");
                Console.WriteLine("5 => For the sphere ");
                Console.WriteLine("6 => For the surface");
                Console.WriteLine("7 => For the quadrangular ");
                choice = Convert.ToInt32(Console.ReadLine());// Kullanıcının seçtiği işleme gitmesini sağlar .
                switch (choice)
                {

                    case 1: 
                        Console.WriteLine("1 => For the point-rectangle ");
                        Console.WriteLine("2 => For the point- rectangle prism ");
                        Console.WriteLine("3 => For the point- circle ");
                        Console.WriteLine("4 => For the point- sphere ");
                        Console.WriteLine("5 => For the point- clinder ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)  // Menü içinde menü olduğu için if else kullandım.
                        { 
                            Collision_test.Point_Rectangle();
                            Console.ReadLine();

                        }
                        else if (choice == 2)
                        {

                            Collision_test.Point_RectanglePrism();
                            Console.ReadLine();


                        }
                        else if (choice == 3)
                        {
                            Collision_test.Point_Circle();
                            Console.ReadLine();



                        }
                        else if (choice == 4)
                        {
                            Collision_test.Point_Sphere();
                            Console.ReadLine();



                        }
                        else if (choice == 5)
                        {

                            Collision_test.Point_Clinder();
                            Console.ReadLine();


                        }
                        break;

                    case 2:
                        Console.WriteLine("1 => For the rectangle-rectangle ");
                        Console.WriteLine("2 => For the rectangle- circle ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Collision_test.Rect_Rect();
                            Console.ReadLine();

                        }
                        if (choice == 2)
                        {
                            Collision_test.Rect_Circle();
                            Console.ReadLine();

                        }
                        
                        break;

                    case 3:
                        Console.WriteLine(" circle-circle ");

                        Collision_test.Circle_Circle();
                        Console.Read();
                        choice = Convert.ToInt32(Console.ReadLine());
                       
                        break;


                    case 4:
                        Console.WriteLine(" clinder-clinder ");
                        Collision_test.Clinder_Clinder();
                        Console.Read();
                        choice = Convert.ToInt32(Console.Read());
                        
                        break;

                    case 5:
                        Console.WriteLine("1 => For the sphere-sphere ");
                        Console.WriteLine("2 => For the sphere- clinder ");
                        Console.WriteLine("3 => For the sphere-rectangle prism ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Collision_test.Sphere_Sphere();
                            Console.ReadLine();

                        }
                        if (choice == 2)
                        {
                            Collision_test.Sphere_Clinder();
                            Console.ReadLine();

                        }
                        if (choice == 3)
                        {
                            Collision_test.Sphere_RectPrism();
                            Console.ReadLine();

                        }
                       

                        break;

                    case 6:
                        Console.WriteLine("1 => For the surface- sphere");
                        Console.WriteLine("2 => For the surface- rectangle prism");
                        Console.WriteLine("3 => For the surface- clinder");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Collision_test.Surface_Sphere();
                            Console.ReadLine();

                        }
                        if (choice == 2)
                        {
                            Collision_test.Surface_RectPrism();
                            Console.ReadLine();

                        }
                        if (choice == 3)
                        {
                            Collision_test.Surface_Clinder();
                            Console.ReadLine();

                        }
                       

                        break;

                    case 7:
                        Console.WriteLine(" quadrangular-quadrangular ");
                        Collision_test.Quadrangular();
                        Console.Read();
                        choice = Convert.ToInt32(Console.Read());
                        

                        break;

                    default :

                        Console.WriteLine("Please enter a number between 1-7...");// Menüdeki seçeneklerden başka bir şey tuşlarsa bu yazı çıkar.
                        Console.ReadLine();

                        break;





                }   Console.WriteLine("Would you like to see the menu ? (y/n)");
                answer = Console.ReadLine();

            
            }
            while (answer.ToLower() == "y" || answer.ToLower() =="yes" );// Cevap evet olduğu sürece menü tekrar edicek


          

        }
    }
}
