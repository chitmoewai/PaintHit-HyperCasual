using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour
{
    public static float rotationSpeed = 75f;

    public static Color oneColor = Color.green;
    public GameObject ballPrefab;

    private float speed =100;

    private void Start()
    {
        MakeNewCircle();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            HitBall();
        }
    }

    private void HitBall()
    {
        GameObject gameObject = Instantiate(ballPrefab, new Vector3(0, 0, -8f), Quaternion.identity);
        gameObject.GetComponent<MeshRenderer>().material.color = oneColor;
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed, ForceMode.Impulse);
    }
    void MakeNewCircle()
    {
        GameObject gameObject2 = Instantiate(Resources.Load("round" + Random.Range(1, 4))) as GameObject;
        gameObject2.transform.position = new Vector3(0, 20, 23);
        gameObject2.name = "Circle";
    }
}
