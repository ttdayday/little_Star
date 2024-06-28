using System.Collections;
using UnityEngine;

public class PlantClickClocks : MonoBehaviour
{
    [SerializeField] GameObject plantZoomedInView;
    [SerializeField] GameObject transitionOverlay;
    [SerializeField] GameObject flowerClockSprite;  // New sprite to swap to

    private SpriteRenderer spriteRenderer;
    

    void OnMouseDown()
    {
        StartCoroutine(SwapStatus());
    }

    private IEnumerator SwapStatus()
    {
        transitionOverlay.SetActive(true);  // Show dark overlay
        yield return new WaitForSeconds(0.3f);  // Very short delay for the effect

       flowerClockSprite.SetActive(true);  // Show zoomed-in view
        plantZoomedInView.SetActive(false);


        transitionOverlay.SetActive(false);  // Hide dark overlay
    }
}