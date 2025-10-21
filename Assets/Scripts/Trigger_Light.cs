using UnityEngine;

public class Trigger_Light : MonoBehaviour
{

    public Light colorLight;
    public GameObject myBall;

    private void Start()
    {
        colorLight.enabled = false;
        myBall.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        colorLight.enabled = true;
        myBall.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        colorLight.enabled = false;
        myBall.SetActive(false);
    }
}
