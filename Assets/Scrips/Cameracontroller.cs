using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] private Transform player;

    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(player.position.x,player.position.y,transform.position.z);
    }
}
