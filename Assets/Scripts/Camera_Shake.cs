using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Shake : MonoBehaviour
{
    public float shakeAmount = 0.1f;
    public float shakeDuration = 0.5f;

    // Start is called before the first frame update
    private Vector3 originalPos;
    void Start()
    {
        originalPos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator ShakeCamera()
    {
        float elapsed = 0.0f;

        Vector3 originalCamPos = transform.position;

        while (elapsed < shakeDuration)
        {
            elapsed += Time.deltaTime;

            float percentComplete = elapsed / shakeDuration;

            float damper = 0.50f - Mathf.Clamp(2.0f * percentComplete - 0.50f, 0.0f, 0.50f);

            float x = Random.value * 1.0f - 0.50f;
            float y = Random.value * 1.0f - 0.50f;

            x *= shakeAmount * damper;
            y *= shakeAmount * damper;

            transform.position = new Vector3(originalCamPos.x + x, originalCamPos.y + y, originalCamPos.z);

            yield return null;
        }
        transform.position = originalCamPos;
    }

}
