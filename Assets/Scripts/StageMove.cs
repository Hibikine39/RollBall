using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private InputAction moveInput;
    void Start()
    {
        moveInput = InputSystem.actions.FindAction("Move");
    }

    public float threshold = 1.0f;
    void Update()
    {
        Debug.Log(moveInput.ReadValue<Vector2>());

        Vector3 rotation;

        rotation = new Vector3(moveInput.ReadValue<Vector2>().y*threshold, 0 ,moveInput.ReadValue<Vector2>().x*threshold);

        Quaternion tilt = Quaternion.Euler(rotation.x, 0f, rotation.z);
        this.gameObject.GetComponent<Rigidbody>().MoveRotation(this.gameObject.GetComponent<Rigidbody>().transform.rotation * tilt);
    }
}
