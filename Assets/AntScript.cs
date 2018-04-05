using MixedRealityToolkit.UX.BoundingBoxes;
using UnityEngine;

public class AntScript : MonoBehaviour
{
    Animator anim;
    bool _isRunning = false;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Run()
    {
        anim.SetTrigger("Run");
        gameObject.AddComponent<Rigidbody>();
        _isRunning = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (_isRunning)
        {
            Debug.Log("ant is rotating");
            gameObject.transform.Rotate(new Vector3(0.0f, Random.Range(-120.0f, 120.0f), 0.0f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_isRunning)
        {
            Debug.Log("ant is running");
            // rotate at random but keep the same general direction?
            transform.localPosition += transform.forward * Time.deltaTime * .5f;
        }
    }
}
