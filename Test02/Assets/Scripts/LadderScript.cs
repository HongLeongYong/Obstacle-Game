using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderScript : MonoBehaviour
{
    bool insideLadder;
    public float ladderHeight = 3.3f;
    public PlayerMovement playerMovement;
    
    
    // Start is called before the first frame update
    void Start()
    {
        insideLadder = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ladder")
        {
            playerMovement.enabled = false;
            insideLadder = !insideLadder;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ladder")
        {
            playerMovement.enabled = true;
            insideLadder = !insideLadder;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (insideLadder && Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.up / ladderHeight;
        }
    }
}
