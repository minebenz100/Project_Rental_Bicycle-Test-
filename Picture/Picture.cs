using System;
using System.Drawing;
//dotnet add package System.Drawing.Common ด้วย

class Picture
{
    private const int OutputImageSize = 500;
    //private static string OutputImageFilePath = "output.bmp";

    public static void Print_Picture(string name,string surename,string student_ID,char location,int index_Bike,double time_borrow,double time_Return,double Price)
    {

        string OutputImageFilePath = String.Format("output_{0}_{1}.bmp",name,time_Return);

        string Head = ("Rental_Bicycle");
        string Name1 = String.Format("Firstname : {0}",name);
        string Name2 = String.Format("Surename : {0}",surename);
        string ID = String.Format("Student ID : {0}",student_ID);
        string Location = String.Format("Location : {0}",location);
        string Number_Bicycle = String.Format("NumberBicycle : {0}",index_Bike);
        string Borrow = String.Format("Borrowtime : {0}",time_borrow);
        string Return = String.Format("Returntime : {0}",time_Return);
        string Borrowed_price = String.Format("Price : {0} Bath",Price);
        string End = ("Thank you for using");

        Font fontH = new Font("Arial", 20);
        Font fontI = new Font("Arial", 16);
        Font fontE = new Font("Arial", 12);
        SolidBrush ellipseBrush = new SolidBrush(Color.White);
        SolidBrush textBrush = new SolidBrush(Color.Black);
        Bitmap outputImage = new Bitmap("Picture/MDT.bmp");
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
            (OutputImageSize - textSize.Height - 50 ) / 4
        );
        graphics.DrawString(
            ID,
            fontI,
            textBrush,
            130,
            170
        );
        graphics.DrawString(
            Location,
            fontI,
            textBrush,
            130,
            210
        );
        graphics.DrawString(
            Number_Bicycle,
            fontI,
            textBrush,
            130,
            250
        );
        graphics.DrawString(
            Borrow,
            fontI,
            textBrush,
            130,
            290
        );
        graphics.DrawString(
            Return,
            fontI,
            textBrush,
            130,
            330
        );
        graphics.DrawString(
            Borrowed_price,
            fontI,
            textBrush,
            130,
            370
        );
        SizeF textSize3 = graphics.MeasureString(END2,fontI);
        graphics.DrawString(
            END2,
            fontI,
            textBrush,
            55,
            120
        );
        SizeF textSize4 = graphics.MeasureString(END2,fontI);
        graphics.DrawString(
            END2,
            fontI,
            textBrush,
            55,
            60
        );
        graphics.DrawString(
            Info,
            fontE,
            textBrush,
            225,
            140
        );
        SizeF textSize5 = graphics.MeasureString(END2,fontI);
        graphics.DrawString(
            END2,
            fontI,
            textBrush,
            55,
            400
        );
        graphics.DrawString(
            End,
            fontE,
            textBrush,
            180,
            420
        );
        graphics.DrawString(
            KMUTT,
            fontE,
            textBrush,
            190,
            440
        );
        outputImage.Save(OutputImageFilePath);
        graphics.Dispose();
    }
}
