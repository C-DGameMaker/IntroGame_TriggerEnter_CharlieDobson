using System.Runtime.CompilerServices;
using UnityEngine;

public class Trigger_Roll : MonoBehaviour
{
    public GameObject myBall;
    void Start()
    {
        myBall.SetActive(false); 
    }
    private void OnTriggerEnter(Collider other)
    {
        myBall.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        myBall.SetActive(false);
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    float timer = 0;

    //    timer += Time.deltaTime;
    //    float t = timer;
    //    Vector3 start = new Vector3(1, 1.5f, -7);
    //    Vector3 end = new Vector3(-1, 1.5f, -7);

    //    myBall.transform.position = Vector3.Lerp(start, end, t);

    //    if(t >= 100f)
    //    {
    //        timer = 0f;
    //        (start, end) = (end, start);
    //    }
    //}
}
