using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmaeraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject thingToFollow;
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
