using System;
using System.Drawing;

class Picture
{
    private const int OutputImageSize = 500;
    private const string OutputImageFilePath = "output.bmp";


    public static void Print_Picture(string name,string surename,string student_ID,char location,int index_Bike,double time_borrow,double time_Return,double Price)
    {
        //  ข้อมูล
        //Console.WriteLine("|||||||||||||||| Time : {0} ||||||||||||||||||",time_borrow); เทส
        //มันทำงี้ไม่ได้ ถ้าจะทำงี้ต้องเป็น Console.WtireLine เท่านั้น ไอ {0} คิดว่าควรปริ้นแยกกัน ปริ้นตัวแปร กับ ปริ้นค่าคงที่อ่ะ
        string Head = ("Rental_Bicycle");
        string Name1 = ("Firstname : {0}",name);
        string Name2 = ("Surename : {0}",surename);
        string ID = ("Student ID : {0}",student_ID);
        string Location = ("Location : {0}",location);
        string Number_Bicycle = ("NumberBicycle : {0}",index_Bike);
        string Borrow = ("Borrowtime : {0}",time_borrow);
        string Return = ("Returntime : {0}",time_Return);
        string Borrowed_price = ("Price : {0} Bath",Price);
        string End = ("Thank you for using");

        // string Head = ("Rental_Bicycle");
        // string Name1 = ("Firstname : SAWASAKORN");
        // string Name2 = ("Surename : KUMNODSRI");
        // string ID = ("Student ID : 64120501007");
        // string Location = ("Location : A");
        // string Number_Bicycle = ("NumberBicycle : 1");
        // string Borrow = ("Borrowtime : 00.00");
        // string Return = ("Returntime : 01.00");
        // string Borrowed_price = ("Price : 100B");
        // string End = ("Thank you for using");


        Font fontH = new Font("Arial", 20);
        Font fontI = new Font("Arial", 16);
        Font fontE = new Font("Arial", 12);
        SolidBrush ellipseBrush = new SolidBrush(Color.White);
        SolidBrush textBrush = new SolidBrush(Color.Black);
        Bitmap outputImage = new Bitmap("MDT.bmp");
        Pen WhitePen = new Pen(Color.White, 0);
        Pen Orangepen = new Pen(Color.OrangeRed, 4);
        Graphics graphics = Graphics.FromImage(outputImage);
        int x = 0;
        int y = 0;
        graphics.DrawRectangle(WhitePen, x, y, OutputImageSize, OutputImageSize);
        graphics.DrawRectangle(Orangepen, x, y, OutputImageSize, OutputImageSize);
        graphics.DrawString(
            Head,
            fontH,
            textBrush,
            165,
            25
        );
        graphics.DrawString(
            End,
            fontE,
            textBrush,
            340,
            470
        );
        SizeF textSize = graphics.MeasureString(Name1,fontI);
        graphics.DrawString(
            Name1,
            fontI,
            textBrush,
            (OutputImageSize - textSize.Width) / 2,
            (OutputImageSize - textSize.Height  ) / 6
        );
        SizeF textSize1 = graphics.MeasureString(Name2,fontI);
        graphics.DrawString(
            Name2,
            fontI,
            textBrush,
            (OutputImageSize - textSize.Width ) / 2,
            (OutputImageSize - textSize.Height - 30 ) / 4
        );
        graphics.DrawString(
            ID,
            fontI,
            textBrush,
            130,
            150
        );
        graphics.DrawString(
            Location,
            fontI,
            textBrush,
            130,
            190
        );
        graphics.DrawString(
            Number_Bicycle,
            fontI,
            textBrush,
            130,
            230
        );
        graphics.DrawString(
            Borrow,
            fontI,
            textBrush,
            130,
            270
        );
        graphics.DrawString(
            Return,
            fontI,
            textBrush,
            130,
            310
        );
        graphics.DrawString(
            Borrowed_price,
            fontI,
            textBrush,
            130,
            350
        );
        outputImage.Save(OutputImageFilePath);
        graphics.Dispose();
    }
}