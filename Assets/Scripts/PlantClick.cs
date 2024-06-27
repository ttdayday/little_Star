using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantClick : MonoBehaviour
{
    [SerializeField] GameObject plantZoomedInView;
    [SerializeField] GameObject initialView;
    [SerializeField] GameObject transitionOverlay;
    [SerializeField] GameObject upwardArrow;
    [SerializeField] GameObject downwardArrow;

    void OnMouseDown()
    {
        StartCoroutine(SwapToZoomedIn());
    }

    private IEnumerator SwapToZoomedIn()
    {
        transitionOverlay.SetActive(true);  // Show dark overlay
        yield return new WaitForSeconds(0.3f);  // Very short delay for the effect

        initialView.SetActive(false);  // Hide initial view
        plantZoomedInView.SetActive(true);  // Show zoomed-in view

        upwardArrow.SetActive(true);  // Show upward button
        downwardArrow.SetActive(true);  // Show downward button

        transitionOverlay.SetActive(false);  // Hide dark overlay
    }
}
