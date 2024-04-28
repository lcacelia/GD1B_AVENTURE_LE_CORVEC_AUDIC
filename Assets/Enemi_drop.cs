using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject dropItem;
    public float dropChance = 0.5f;
    private bool hasDropped = false;

    private void OnDestroy()
    {
        if (!hasDropped)
        {
            float randomValue = Random.value;

            if (randomValue <= dropChance)
            {
                // Cr�e la potion
                GameObject potion = Instantiate(dropItem, transform.position, Quaternion.identity);

                // Active la potion
                potion.SetActive(true);

                hasDropped = true;
            }
        }
    }
}