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

    void Update()
    {
        Debug.Log(moveInput.ReadValue<Vector2>());

        Vector3 rotation;
        float threshold = 0.2f;

        rotation = new Vector3(moveInput.ReadValue<Vector2>().y*threshold, 0 ,moveInput.ReadValue<Vector2>().x*threshold);

        this.transform.Rotate(rotation);
    }
}
