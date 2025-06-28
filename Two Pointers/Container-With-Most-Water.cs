public class Solution {
    public int MaxArea(int[] height)   { 
      int front=0,back = height.Length-1;
      int max = 0 ,area ;

      while(front < back)
      {
          area = (back-front) * Math.Min(height[front],height[back]);
          if(area > max)
              max = area;

          if (height[front] < height[back])
              front++;
          else
              back--;

      }
      return max;
   }
}