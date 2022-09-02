using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Variables/Game Objects/Player Data")]
public class PlayerData : ScriptableObject
{
    public int health;
    public int damage;
    public float movementSpeed;
    public float ammoSpeed;
    public float ammoSpinSpeed;
    public float ammoLife;
    public float reloadTime;
    public float bounceDistance;
}
