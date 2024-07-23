using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Stack
{
    public class LargestRectangleInHistogram
    {
        public static int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;

            for(int i=0; i<heights.Length; i++)
            {
                int left = i - 1;
                int right = i + 1;
                int currHeight = heights[i];
                int sum = currHeight;
                bool stopLeft = false;
                bool stopRight = false;

                while(left >= -1 && right <= heights.Length)
                {
                    if (left > -1 && heights[left] >= currHeight) 
                    {
                        sum += currHeight;
                    }
                    else
                    {
                        stopLeft = true;
                    }

                    if (right < heights.Length && heights[right] >= currHeight)
                    {
                        sum += currHeight;
                    }
                    else
                    {
                        stopRight = true;
                    }

                    if (left < 0 && right >= heights.Length)
                        break;
                    
                    if(left >= 0 && !stopLeft)
                        left--;

                    if (right < heights.Length && !stopRight)
                        right++;

                    if (stopLeft && stopRight)
                        break;
                }

                maxArea = Math.Max(sum, maxArea);
            }

            return maxArea;
        }
    }
}
