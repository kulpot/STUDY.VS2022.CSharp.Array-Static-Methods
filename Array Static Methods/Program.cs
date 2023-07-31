using System;

//ref link:https://www.youtube.com/watch?v=zBcnpo3aJgg&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=10
//

/*      Static method Arrays
 * -------------------------------------
 *              Functions 
 * -------------------------------------     
 * ARRAY(static)            LINQ
 * -------------------------------------                 
 * Sort()                   OrderBy()
 * ForEach()                First()
 * IndexOf()        
 * Clear()
 * Copy()
 * CreateInstance()         new int[]
 * Exists()                 Any()
 * Find()                   First()
 * FindLast()               Last()
 * FindAll()                Where()
 * FindIndex()
 * FindLastIndex()
 * Resize()
 * Reverse()                Reverse()
 * 
 * 
 */

// CreateInstance() ---- reflection/dynamic runtime knowledge

class MainClass
{
    static void Main()
    {
        int[] ints = new int[] { 5, 2, 8, 9, 1, 0, 4 };
        //Array.Sort(ints);
        var sorted = ints.OrderBy(i => i);
        //foreach (int i in ints)
        foreach(int i in sorted)
            Console.WriteLine(i);
    }
}