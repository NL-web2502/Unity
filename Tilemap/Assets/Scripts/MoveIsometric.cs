using UnityEngine;
using UnityEngine.Tilemaps;  

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Transform _player;
    public float moveSpeed = 5f; 

    private Tilemap _map;
    private Camera _camera;
    private Vector3 targetPosition;

    private void Start()
    {
       _map = GetComponent <Tilemap>(); 
        _camera = Camera.main;
        targetPosition = _player.position;
    }

    private void Update()
    { 
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickWorldPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
            clickWorldPosition.z = 0f; 
            targetPosition = clickWorldPosition;
        }
        
        
         if (_player.position != targetPosition)
        {
            _player.position = Vector3.MoveTowards(_player.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}