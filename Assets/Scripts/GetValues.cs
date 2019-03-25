using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetValues : MonoBehaviour
{

    [SerializeField] Vector3 rightShoulderVal;
    [SerializeField] Vector3 leftShoulderVal;
    [SerializeField] float rightElbowVal;
    [SerializeField] float leftElbowVal;
    [SerializeField] Vector3 rightHandVal;
    [SerializeField] Vector3 leftHandVal;

    [SerializeField] GameObject [] body = new GameObject [6];

    private void Start ()
    {
        body = GameObject.FindGameObjectsWithTag ("Body");

        foreach(var b in body)
        {
            Debug.Log (b.name);
        }

    }



}
