// using System;
// using System.Drawing;

// class Picture
// {
//     private const int OutputImageSize = 500;
//     private const string OutputImageFilePath = "output.bmp";
//     public void OutputPicture()
//     {
//         //  ข้อมูล
//         string Head = ("Rental_Bicycle");
//         string info = ("Thank you for using");

//         Font font = new Font("Arial", 20);
//         SolidBrush ellipseBrush = new SolidBrush(Color.White);
//         SolidBrush textBrush = new SolidBrush(Color.Black);
//         Bitmap outputImage = new Bitmap(OutputImageSize,OutputImageSize);
//         Pen WhitePen = new Pen(Color.White, 1000);
//         Pen Redpen = new Pen(Color.Red, 5);
//         Graphics graphics = Graphics.FromImage(outputImage);
//         int x = 0;
//         int y = 0;
//         int width = 500;
//         int height = 500;
//         graphics.DrawRectangle(WhitePen, x, y, width, height);
//         graphics.DrawRectangle(Redpen, x, y, width, height);
//         SizeF textSize = graphics.MeasureString(info, font);
//         graphics.DrawString(
//             Head,
//             font,
//             textBrush,
//             165,
//             25
//         );
//         graphics.DrawString(
//             info,
//             font,
//             textBrush,
//             250,
//             460
//         );
//         outputImage.Save(OutputImageFilePath);
//         graphics.Dispose();
//     }
// }