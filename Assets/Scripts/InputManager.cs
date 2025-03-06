using UnityEngine;

public class InputManager : MonoBehaviour
{

    public static InputManager Instance;

    public bool MoveUp { get; private set; }
    public bool MoveDown { get; private set; }
    public bool MoveRight { get; private set; }
    public bool MoveLeft { get; private set; }

    public float HorizontalLook { get; private set; }
    public float VerticalLook { get; private set; }

    public bool IsRotating {get; private set; }
    public bool IsShooting {get; private set; }

    private void Awake()
    {
        Instance = this; // setup singleton
    }


    void Update()
    {
        // movement inputs

        MoveUp = Input.GetKey(KeyCode.W);
        MoveDown = Input.GetKey(KeyCode.S);
        MoveRight = Input.GetKey(KeyCode.D);
        MoveLeft = Input.GetKey(KeyCode.A);


        // Mouse movement inputs

        HorizontalLook = Input.GetAxis("Mouse X");
        VerticalLook = Input.GetAxis("Mouse Y");

        IsRotating = Input.GetMouseButton(1); // right mouse button
        IsShooting = Input.GetMouseButtonDown(0); // left mouse button
    }
}
