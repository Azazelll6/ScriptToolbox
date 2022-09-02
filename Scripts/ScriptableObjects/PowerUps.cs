using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "PowerUps", menuName = "Variables/Game Objects/Power Ups")]
public class PowerUps : ScriptableObject
{
    public string powFunction;
    public float duration;
    public float moveSpeedBoost;
    public float fireRateBoost;
    public float heal;
    public float healthBoost;
    public float damageBoost;
    public float reloadBoost;
    public float knockBack;
    public float ammoSpeedBoost;
    public bool pierce;
}
