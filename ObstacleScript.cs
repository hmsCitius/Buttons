using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{

    [SerializeField] private GameObject DestroyIskeleton;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Instantiate(DestroyIskeleton, new Vector3(other.gameObject.transform.position.x,
                other.gameObject.transform.position.y,
                other.gameObject.transform.position.z), Quaternion.identity);
        }
    }





}
