using System;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{

    private bool isPlayerMoving;
    private Vector3 lastPlayerPosition;

    public static event Action<float> OnPlayerMouvement;

    // Start is called before the first frame update
    void Start()
    {
        isPlayerMoving = false;
        lastPlayerPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != lastPlayerPosition)
        {
            Debug.Log("Player is moving");
            isPlayerMoving = true;
            lastPlayerPosition = transform.position;

            // Fire event with params
            OnPlayerMouvement?.Invoke(lastPlayerPosition.y);
        }
    }
}
