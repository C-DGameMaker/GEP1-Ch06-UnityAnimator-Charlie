using UnityEngine;
using UnityEngine.InputSystem;

public class CubeSpinnerActive : MonoBehaviour
{
    public Animator animController;
    void Start()
    {
        animController = GetComponent<Animator>();
    }

   public void ToggleSpin(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            animController.SetBool("isRotating", !animController.GetBool("isRotating"));

        }
    }
}
