using UnityEngine;

public class Treasure : MonoBehaviour
{
    [SerializeField]
    GameManager manager;


    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.GetComponent<PlayerStateManager>() != null) 
        {
            manager.EndGame();
        }
    }
}
