using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class ImageSmoother
    {
        public static int[][] ImageSmoothers(int[][] img)
        {
            int[][] copy = new int[img.Length][];
            for (int i = 0; i < img.Length; i++)
            {
                copy[i] = new int[img[i].Length];
                Array.Copy(img[i], copy[i], img[i].Length);
            }

            for (int i=0; i<img.Length; i++)
            {
                for(int j=0; j < img[0].Length; j++)
                {
                    var count = 1;
                    var avg = img[i][j];

                    if (IsInBounds(i-1, j, img))
                    {
                        avg += img[i-1][j];
                        count++;
                    }
                    if(IsInBounds(i+1, j, img))
                    {
                        avg += img[i + 1][j];
                        count++;
                    }
                    if(IsInBounds(i, j-1, img))
                    {
                        avg += img[i][j-1];
                        count++;
                    }
                    if(IsInBounds(i, j+1, img))
                    {
                        avg += img[i][j+1];
                        count++;
                    }
                    if(IsInBounds(i-1, j-1, img))
                    {
                        avg += img[i-1][j-1];
                        count++;
                    }
                    if (IsInBounds(i-1, j+1, img))
                    {
                        avg += img[i-1][j+1];
                        count++;
                    }
                    if (IsInBounds(i+1, j-1, img))
                    {
                        avg += img[i+1][j-1];
                        count++;
                    }
                    if(IsInBounds(i+1, j+1, img))
                    {
                        avg += img[i+1][j+1];
                        count++;
                    }

                    copy[i][j] = (int)Math.Floor(avg / (double)count);
                }
            }

            return copy;
        }

        public static bool IsInBounds(int i, int j, int[][] img)
        {
            int colLen = img.Length;
            int rowLen = img[0].Length;

            if(i > colLen-1 || i<0 || j > rowLen-1 || j<0)
                return false;

            return true;

        }
    }
}
