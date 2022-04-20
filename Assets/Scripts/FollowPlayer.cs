using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    [SerializeField] private Transform playerTransform;

    private void Update() {
        transform.position = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z);
    }
}