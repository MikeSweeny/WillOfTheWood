using UnityEngine;

public class Sword : IWeapon
{
    CharacterBase character;
    private float roll;

    private void Start()
    {
        stats = new SwordStats();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.root.tag != gameObject.transform.root.tag)
        {
            character = other.gameObject.GetComponent<CharacterBase>();
            character.TakeDamage(AttackRoll());
        }
    }
    public float AttackRoll()
    {
        roll = (float)Random.Range(stats.GetAttackMinDamage(),stats.GetAttackMaxDamage());
        return roll;
    }
}
