using UnityEngine;
using UnityEngine.InputSystem;

public class MegaManAnimatorScript : MonoBehaviour
{
    public Animator animController;
    public Vector2 moveInput;
    void Start()
    {
        animController = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        animController.SetFloat("moveInputX", moveInput.x);
    }
}
