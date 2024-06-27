using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOut : MonoBehaviour
{
    [SerializeField] GameObject plantZoomedInView;
    [SerializeField] GameObject initialView;
    [SerializeField] GameObject transitionOverlay;
    [SerializeField] GameObject upwardArrow;
    [SerializeField] GameObject downwardArrow;

    public void OnZoomOutButtonClick()
    {
        StartCoroutine(SwapToInitialView());
    }

    private IEnumerator SwapToInitialView()
    {
        transitionOverlay.SetActive(true);  // Show dark overlay
        yield return new WaitForSeconds(0.3f);  // Very short delay for the effect

        plantZoomedInView.SetActive(false);  // Hide zoomed-in view
        initialView.SetActive(true);  // Show initial view

        upwardArrow.SetActive(false);  // Hide upward button
        downwardArrow.SetActive(false);  // Hide downward button

        transitionOverlay.SetActive(false);  // Hide dark overlay
    }
}
