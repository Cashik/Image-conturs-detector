using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageEditor
{
    public static class Matrix
    {
        public static double[,] Laplacian3x3
        {
            get
            {
                return new double[,]
                { { -1, -1, -1,  },
                  { -1,  8, -1,  },
                  { -1, -1, -1,  }, };
            }
        }

        public static double[,] Laplacian5x5
        {
            get
            {
                return new double[,]
                { { -1, -1, -1, -1, -1, },
                  { -1, -1, -1, -1, -1, },
                  { -1, -1, 24, -1, -1, },
                  { -1, -1, -1, -1, -1, },
                  { -1, -1, -1, -1, -1  }, };
            }
        }


        public static double[,] Gaussian3x3
        {
            get
            {
                return new double[,]
                { { 1, 2, 1, },
                  { 2, 4, 2, },
                  { 1, 2, 1, }, };
            }
        }


        public static double[,] Sobel3x3Horizontal
        {
            get
            {
                return new double[,]
                { { -1,  0,  1, },
                  { -2,  0,  2, },
                  { -1,  0,  1, }, };
            }
        }

        public static double[,] Sobel3x3Vertical
        {
            get
            {
                return new double[,]
                { {  1,  2,  1, },
                  {  0,  0,  0, },
                  { -1, -2, -1, }, };
            }
        }
        public static double[,] Sobel5x5Horizontal
        {
            get
            {
                return new double[,]
                { { -1, -2, 0, 2,1 },
                  { -4, -8, 0, 8,4 },
                  { -6, -12, 0, 12,6 },
                  { -4, -8, 0, 8,4 },
                  { -1, -2, 0, 2,1 }, };
            }
        }
        public static double[,] Sobel5х5Vertical
        {
            get
            {
                return new double[,]
                { { 1, 4, 6, 4, 1 },
                  { 2, 8, 12, 8, 2 },
                  { 0, 0, 0, 0, 0 },
                  { -2,-8,-12,-8,-2},
                  { -1,-4,-6,-4,-1}, };
            }
        }
        public static double[,] Prewitt3x3Horizontal
        {
            get
            {
                return new double[,]
                { { -1,  0,  1, },
                  { -1,  0,  1, },
                  { -1,  0,  1, }, };
            }
        }

        public static double[,] Prewitt3x3Vertical
        {
            get
            {
                return new double[,]
                { {  1,  1,  1, },
                  {  0,  0,  0, },
                  { -1, -1, -1, }, };
            }
        }


        public static double[,] Kirsch3x3Horizontal
        {
            get
            {
                return new double[,]
                { {  5,  5,  5, },
                  { -3,  0, -3, },
                  { -3, -3, -3, }, };
            }
        }

        public static double[,] Kirsch3x3Vertical
        {
            get
            {
                return new double[,]
                { {  5, -3, -3, },
                  {  5,  0, -3, },
                  {  5, -3, -3, }, };
            }
        }
    }
}
