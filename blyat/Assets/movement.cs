using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] Transform playerCamera;
    [SerializeField][Range(0.0f, 0.5f)] float mouseSmoothLine = 0.03f;
    [SerializeField] bool cursorlock = true;
    [SerializeField] float mouseSensivity = 3.5f;
    [SerializeField] float speed = 6.0f;
    [SerializeField][Range(0.0f, 0.5f)] float moveSmoothLine = 0.03f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    public float jumpheight = 6.0f;
    float velocityY;
    bool Isgrounded;

    float cameraCap;
    Vector2 currentMouseDelta;
    Vector2 currentMouseDeltaVelocity;

    CharacterController controller;
    Vector2 currentDir;
    Vector2 currentDirVelocity;
    Vector3 Velocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        if (cursorlock)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;

        }

    }
    void Update()
    {
    }









}


