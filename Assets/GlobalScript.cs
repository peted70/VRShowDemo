using System.Collections;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
    public void MakeAllAntsRun()
    {
        var ants = FindObjectsOfType<AntScript>();
        foreach (var ant in ants)
        {
            ant.Run();
        }
    }

    public void Clone()
    {
        StartCoroutine(Clone(10));
    }

    public IEnumerator Clone(int num = 10)
    {
        var ant = FindObjectOfType<AntScript>();
        for (int i = 0; i < num; i++)
        {
            var newAnt = GameObject.Instantiate(ant.gameObject, new Vector3(0, 0, 0), Quaternion.identity);
            yield return null;
        }
    }
}
