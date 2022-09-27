using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    bool hasPackage;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            print("Package picked up !");
            Destroy(other.gameObject, 0.5f);
            spriteRenderer.color = hasPackageColor;
            hasPackage = true;

        }
        if (other.tag == "Customer" && hasPackage)
        {
            print("Package delivered !");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
    // Start is called before the first frame update

}
