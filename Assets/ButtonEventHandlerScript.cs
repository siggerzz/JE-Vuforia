using UnityEngine;

public class ButtonEventHandlerScript : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = GameObject.FindGameObjectWithTag("clickableCube");
            obj.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
