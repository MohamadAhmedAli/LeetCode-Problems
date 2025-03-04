public class Solution {
    public uint reverseBits(uint n) {
    uint res = 0;
    for(int i = 0; i< 32; i++ )
    {
        if (((1 << i) & n) != 0)
        {
            res |= (uint)(1 << (32-i-1));
        }

    }
    return res;
}
}