public class Solution {
    public string Convert(string s, int numRows) {
    if (numRows == 1)
        return s;

    int numcols= 0, total = s.Length;
    while (total>0)
    {
        total -= numRows;
        numcols+= 1;
        for (int i = 0; i < numRows-2; i++)
        {
            if (total > 0)
            {
                total -= 1;
                numcols += 1;

            }
        }
    }

    char[,] arr = new char[numRows, numcols] ;
    int d=1, x = 0;
    int k = 0;
        for (int j = 0; j < numRows; )
        {
            if(x > s.Length -1)
                break;

            arr[j, k] = s[x++];
        if (j == 0)
            d = 1;
        else if (j == numRows - 1)
        {
            d = -1;
            k++;
        }
        else if (d == -1)
            k++;

        j += d;
           
        }
    
     string res = "";
    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numcols; j++)
        {   if(arr[i, j] !=0)
            res += arr[i, j];
        }
    }
       return res;
}
}