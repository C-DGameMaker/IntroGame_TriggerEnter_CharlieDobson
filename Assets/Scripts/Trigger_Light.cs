using UnityEngine;

public class Trigger_Light : MonoBehaviour
{

    public Light colorLight;
    public GameObject myBall;
    public GameObject myLight;

    private void Start()
    {
        colorLight.enabled = false;
        myBall.SetActive(false);
        myLight.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        colorLight.enabled = true;
        myLight.SetActive(true);
        myBall.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        colorLight.color = Random.ColorHSV();

    }
    private void OnTriggerExit(Collider other)
    {
        colorLight.enabled = false;
        myBall.SetActive(false);
        myLight.SetActive(false);
    }
}
