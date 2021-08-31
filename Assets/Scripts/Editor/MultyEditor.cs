using UnityEditor;
using UnityEngine;

public class MultyEditor : Editor
{
    [MenuItem("Snake Setup/Create Apple x10")]
    static void CreateApple10()
    {
        var apple = new GameObject("Apples");


        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                var ap = Instantiate(Resources.Load("Apple") as GameObject);
                ap.transform.SetParent(apple.transform);
                ap.name = "Apple_"+y.ToString();
                ap.transform.position = new Vector3(x ,y ,0);
            }
        }
    }
}
