using MixedRealityToolkit.UX.BoundingBoxes;
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
        Destroy(ant.gameObject.GetComponent<BoundingBoxRig>());

        float space = 5.0f;
        for (int i = 0; i < num; i++)
        {
            var rot = ant.gameObject.transform.rotation * Quaternion.Euler(0.0f, Random.Range(-20.0f, 20.0f), 0.0f);
            var pos = ant.gameObject.transform.position + new Vector3(-space * 0.5f + i * space * 0.1f, 0, 0);
            var newAnt = Instantiate(ant.gameObject, pos, rot, ant.gameObject.transform.parent);
            yield return null;
        }
    }
}
