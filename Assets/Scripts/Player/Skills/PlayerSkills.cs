using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerSkills : MonoBehaviour
{
    protected float damage;
    protected abstract void BasicAttack();
}
