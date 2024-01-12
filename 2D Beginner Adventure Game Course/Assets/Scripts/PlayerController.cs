using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Karakter hareketi için oluþturuldu.
    [SerializeField]
    private InputAction MoveAction;
    [SerializeField]
    private Rigidbody2D playerRB2D;
    private Vector2 playerMove;

    //Karaktere ait hareket ivmesi için oluþturuldu.
    private float horizontalValue = 0f;
    private float verticalValue = 0f;



    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
        
        playerRB2D = GetComponent<Rigidbody2D>();

        //optimizasyon için fps sabitleme
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    private void FixedUpdate()
    {
        Vector2 characterPosition = (Vector2)playerRB2D.position + playerMove * 3.5f * Time.deltaTime;

        //https://docs.unity3d.com/ScriptReference/Rigidbody2D.MovePosition.html 
        playerRB2D.MovePosition(characterPosition);
    }

    private void PlayerMove()
    {
        playerMove = MoveAction.ReadValue<Vector2>();
    }
}
