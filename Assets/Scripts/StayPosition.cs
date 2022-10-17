using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayPosition : MonoBehaviour
{
    public Vector3 startObjectPosition;
    public Transform updateObjectPosition;
    public GameObject objectModel;
    // Start is called before the first frame update
    void Start()
    {
        objectModel = GameObject.FindGameObjectWithTag("Player");
        startObjectPosition = objectModel.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        updateObjectPosition.position = startObjectPosition;
    }
}
