using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VisualCryptoTest
{
    class VisCrypt
    {
        public Bitmap[] GenerateImage(Bitmap input)
        {
            Bitmap[] image = new Bitmap[2];
            input = ConvertToBalckWhite(input);
            Random rand = new Random();

            for (int i = 0; i < image.Length; i++)
                image[i] = new Bitmap(2*input.Width, 2*input.Height);

            Color c;
            for (int x = 0; x < input.Width; x++)
            {
                for (int y = 0; y < input.Height; y++)
                {
                    c = input.GetPixel(x, y);
                    int l = rand.Next(6);
                    if (c.Name == Color.Empty.Name)
                    {
                        for (int i = 0; i < image.Length; i++)
                        {
                            switch(l)
                            {
                                case 0: {
                                        image[i].SetPixel(2 * x, 2 * y, Color.Black);
                                        image[i].SetPixel(2 * x + 1, 2 * y, Color.Empty);
                                        image[i].SetPixel(2 * x, 2 * y + 1, Color.Black);
                                        image[i].SetPixel(2 * x + 1, 2 * y + 1, Color.Empty);
                                    };break;
                                case 1: {
                                        image[i].SetPixel(2 * x, 2 * y, Color.Empty);
                                        image[i].SetPixel(2 * x + 1, 2 * y, Color.Black);
                                        image[i].SetPixel(2 * x, 2 * y + 1, Color.Empty);
                                        image[i].SetPixel(2 * x + 1, 2 * y + 1, Color.Black);
                                    }; break;
                                case 2: {
                                        image[i].SetPixel(2 * x, 2 * y, Color.Black);
                                        image[i].SetPixel(2 * x + 1, 2 * y, Color.Black);
                                        image[i].SetPixel(2 * x, 2 * y + 1, Color.Empty);
                                        image[i].SetPixel(2 * x + 1, 2 * y + 1, Color.Empty);
                                    }; break;
                                case 3: {
                                        image[i].SetPixel(2 * x, 2 * y, Color.Empty);
                                        image[i].SetPixel(2 * x + 1, 2 * y, Color.Empty);
                                        image[i].SetPixel(2 * x, 2 * y + 1, Color.Black);
                                        image[i].SetPixel(2 * x + 1, 2 * y + 1, Color.Black);
                                    }; break;
                                case 4: {
                                        image[i].SetPixel(2 * x, 2 * y, Color.Black);
                                        image[i].SetPixel(2 * x + 1, 2 * y, Color.Empty);
                                        image[i].SetPixel(2 * x, 2 * y + 1, Color.Empty);
                                        image[i].SetPixel(2 * x + 1, 2 * y + 1, Color.Black);
                                    }; break;
                                case 5: {
                                        image[i].SetPixel(2 * x, 2 * y, Color.Empty);
                                        image[i].SetPixel(2 * x + 1, 2 * y, Color.Black);
                                        image[i].SetPixel(2 * x, 2 * y + 1, Color.Black);
                                        image[i].SetPixel(2 * x + 1, 2 * y + 1, Color.Empty);
                                    }; break;
                            }
                        }
                    }
                    else
                    {
                        switch (l)
                        {
                            case 0: {
                                    image[0].SetPixel(2 * x, 2 * y, Color.Black);
                                    image[0].SetPixel(2 * x + 1, 2 * y, Color.Empty);
                                    image[0].SetPixel(2 * x, 2 * y + 1, Color.Black);
                                    image[0].SetPixel(2 * x + 1, 2 * y + 1, Color.Empty);

                                    image[1].SetPixel(2 * x, 2 * y, Color.Empty);
                                    image[1].SetPixel(2 * x + 1, 2 * y, Color.Black);
                                    image[1].SetPixel(2 * x, 2 * y + 1, Color.Empty);
                                    image[1].SetPixel(2 * x + 1, 2 * y + 1, Color.Black);
                                }; break;
                            case 1: {
                                    image[1].SetPixel(2 * x, 2 * y, Color.Black);
                                    image[1].SetPixel(2 * x + 1, 2 * y, Color.Empty);
                                    image[1].SetPixel(2 * x, 2 * y + 1, Color.Black);
                                    image[1].SetPixel(2 * x + 1, 2 * y + 1, Color.Empty);

                                    image[0].SetPixel(2 * x, 2 * y, Color.Empty);
                                    image[0].SetPixel(2 * x + 1, 2 * y, Color.Black);
                                    image[0].SetPixel(2 * x, 2 * y + 1, Color.Empty);
                                    image[0].SetPixel(2 * x + 1, 2 * y + 1, Color.Black);
                                }; break;
                            case 2: {
                                    image[0].SetPixel(2 * x, 2 * y, Color.Black);
                                    image[0].SetPixel(2 * x + 1, 2 * y, Color.Black);
                                    image[0].SetPixel(2 * x, 2 * y + 1, Color.Empty);
                                    image[0].SetPixel(2 * x + 1, 2 * y + 1, Color.Empty);

                                    image[1].SetPixel(2 * x, 2 * y, Color.Empty);
                                    image[1].SetPixel(2 * x + 1, 2 * y, Color.Empty);
                                    image[1].SetPixel(2 * x, 2 * y + 1, Color.Black);
                                    image[1].SetPixel(2 * x + 1, 2 * y + 1, Color.Black);
                                }; break;
                            case 3: {
                                    image[1].SetPixel(2 * x, 2 * y, Color.Black);
                                    image[1].SetPixel(2 * x + 1, 2 * y, Color.Black);
                                    image[1].SetPixel(2 * x, 2 * y + 1, Color.Empty);
                                    image[1].SetPixel(2 * x + 1, 2 * y + 1, Color.Empty);

                                    image[0].SetPixel(2 * x, 2 * y, Color.Empty);
                                    image[0].SetPixel(2 * x + 1, 2 * y, Color.Empty);
                                    image[0].SetPixel(2 * x, 2 * y + 1, Color.Black);
                                    image[0].SetPixel(2 * x + 1, 2 * y + 1, Color.Black);
                                }; break;
                            case 4: {
                                    image[0].SetPixel(2 * x, 2 * y, Color.Black);
                                    image[0].SetPixel(2 * x + 1, 2 * y, Color.Empty);
                                    image[0].SetPixel(2 * x, 2 * y + 1, Color.Empty);
                                    image[0].SetPixel(2 * x + 1, 2 * y + 1, Color.Black);

                                    image[1].SetPixel(2 * x, 2 * y, Color.Empty);
                                    image[1].SetPixel(2 * x + 1, 2 * y, Color.Black);
                                    image[1].SetPixel(2 * x, 2 * y + 1, Color.Black);
                                    image[1].SetPixel(2 * x + 1, 2 * y + 1, Color.Empty);
                                }; break;
                            case 5: {
                                    image[1].SetPixel(2 * x, 2 * y, Color.Black);
                                    image[1].SetPixel(2 * x + 1, 2 * y, Color.Empty);
                                    image[1].SetPixel(2 * x, 2 * y + 1, Color.Empty);
                                    image[1].SetPixel(2 * x + 1, 2 * y + 1, Color.Black);

                                    image[0].SetPixel(2 * x, 2 * y, Color.Empty);
                                    image[0].SetPixel(2 * x + 1, 2 * y, Color.Black);
                                    image[0].SetPixel(2 * x, 2 * y + 1, Color.Black);
                                    image[0].SetPixel(2 * x + 1, 2 * y + 1, Color.Empty);
                                }; break;
                        }
                    }
                }
            }

            return image;
        }
        public Bitmap MergeImages(Bitmap[] u)
        {
            int width = u[0].Width / 2, height = u[1].Height / 2;
            Bitmap output = new Bitmap(width, height);
            Bitmap merged = new Bitmap(u[0].Width, u[1].Height);
            Color c1, c2;
            for (int x = 0; x < u[1].Width; x++)
            {
                for (int y = 0; y < u[1].Height; y++)
                {
                    c1 = u[0].GetPixel(x, y);
                    c2 = u[1].GetPixel(x, y);
                    if(c1.Name==c2.Name)
                    {
                        merged.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        merged.SetPixel(x, y, Color.Black);
                    }
                }
            }
            output = new Bitmap(merged, width, height);
            return output;
        }
        private Bitmap ConvertToBalckWhite(Bitmap source)
        {
            int sourceWidth = source.Width;
            int sourceHeight = source.Height;

            Bitmap result = new Bitmap(sourceWidth, sourceHeight);
            double mid = 255d * (1d / 2d);
            for (int x = 0; x < sourceWidth; x++)
            {
                for (int y = 0; y < sourceHeight; y++)
                {
                    Color c = source.GetPixel(x, y);
                    c = (Average(c.R, c.G, c.B) > mid) ? Color.Empty : Color.Black;
                    result.SetPixel(x, y, c);
                }
            }
            return result;
        }
        private double Average(int R, int G, int B)
        {
            return (double)((R + G + B) / 3);
        }
    }
}
