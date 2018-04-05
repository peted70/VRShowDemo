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
        _isRunning = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (_isRunning)
        {
            gameObject.transform.Rotate(new Vector3(0.0f, Random.Range(-45.0f, 45.0f), 0.0f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_isRunning)
        {
            // rotate at random but keep the same general direction?
            transform.localPosition += transform.forward * Time.deltaTime * 6f;
        }
    }
}
