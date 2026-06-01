using UnityEngine;

public class Sensor : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

        Controller controller = other.GetComponent<Controller>();

        if (controller != null)
        {
            controller.Soar();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
}
