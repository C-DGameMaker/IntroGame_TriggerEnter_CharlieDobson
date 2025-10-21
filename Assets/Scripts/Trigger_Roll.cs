using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Trigger_Roll : MonoBehaviour
{
    public GameObject myBall;
    public float timer = 0;

    static Vector3 start;
    static Vector3 end;
    
    private void OnTriggerEnter(Collider other)
    {
        myBall.SetActive(true);

        start = new Vector3(1, 1.5f, -7);
        end = new Vector3(-1, 1.5f, -7);
        myBall.transform.position = start;
    }

    private void OnTriggerExit(Collider other)
    {
        myBall.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        
        timer += Time.deltaTime;
        float t = timer;
        t = Mathf.Clamp01(t);

        myBall.transform.position = Vector3.Lerp(start, end, t);

        if (t >= 1f)
        {
            timer = 0f;
            (start, end) = (end, start);
        }
    }
}
