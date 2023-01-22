using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
{ 
     newPosition = transform.position;
}
// Update is called once per frame
void Update()
{
    newPosition.z += speed * Time.deltaTime;
    transform.position = newPosition;
}
}
