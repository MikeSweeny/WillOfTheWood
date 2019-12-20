using UnityEngine;

public class Sword : IWeapon
{
    CharacterBase character;
    private float roll;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            character.TakeDamage(AttackRoll());
        }
    }
    public float AttackRoll()
    {
        roll = Random.Range(stats.GetAttackMinDamage(),stats.GetAttackMaxDamage());
        return roll;
    }
}
