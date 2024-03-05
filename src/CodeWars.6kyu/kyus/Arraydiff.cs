using System.Linq;

namespace CodeWars._6kyu.kyus;

public static class Arraydiff
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        var listInt = a.Where(x => b.All(y => y != x)).ToList();
        int[] arrayInt = new int[listInt.Count];
        for (var i = 0; i < listInt.Count; i++)
        {
            arrayInt[i] = listInt[i];
        }
        return arrayInt;
    }
    public static int[] ArrayDiffBetter(int[] a, int[] b)
    {
        return a.Where(n => !b.Contains(n)).ToArray();
    }
}
