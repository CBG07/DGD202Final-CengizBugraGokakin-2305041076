using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    private PlayerInput _input; // InputAction sınıfın bu
    private PlayerInput.PlayerActions _playerActions;

    private PlayerMover _mover;

    private void Awake()
    {
        _input = new PlayerInput(); // input sistemini başlat
        _playerActions = _input.Player; // Player action map'ini al
        _mover = GetComponent<PlayerMover>(); // PlayerMover script'ini al
    }

    private void OnEnable()
    {
        _input.Enable(); // input sistemini aktif et
    }

    private void OnDisable()
    {
        _input.Disable(); // input sistemini pasif et
    }

    private void Update()
    {
        Vector2 moveInput = _playerActions.Move.ReadValue<Vector2>(); // Vector2 input'u oku
        _mover.Move(moveInput); // PlayerMover'a gönder
    }
}
