using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animal_controller : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    private Vector3 outbound = new Vector3 (0, 0, -10);
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        //control the animal and set bound, if one animal reach the boundary, game over
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(transform.position.z < outbound.z)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
