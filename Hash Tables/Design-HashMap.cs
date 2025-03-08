public class MyHashMap
{
    int[] arr = new int[(int)Math.Pow(10, 6)+1];
    public MyHashMap()
    {

    }

    public void Put(int key, int value)
    {
        arr[key] = value+1;
    }

    public int Get(int key)
    {
        return arr[key]-1;
    }

    public void Remove(int key)
    {
        arr[key] = 0;
    }
}