using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] private GameObject[] points;

    private int currentpointIndex = 0;

    [SerializeField] private float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
        if (Vector2.Distance(points[currentpointIndex].transform.position,transform.position)< .1f)
        {
            currentpointIndex++;
            if(currentpointIndex >= points.Length)
            {
                currentpointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, points[currentpointIndex].transform.position, Time.deltaTime * speed);
    }
}
