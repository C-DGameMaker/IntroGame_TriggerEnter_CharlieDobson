using UnityEngine;

public class Ball_Roll : MonoBehaviour
{
    public GameObject myBall;

    static Vector3 start = new Vector3(1, 1.5f, -7);
    static Vector3 end = new Vector3(-1, 1.5f, -7);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float timer = 0;

        timer += Time.deltaTime;
        float t = timer;
       

        myBall.transform.position = Vector3.Lerp(start, end, t);

        //if (t >= 10f)
        //{
        //    timer = 0f;
        //    (start, end) = (end, start);
        //}
    }
}
