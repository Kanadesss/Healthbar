using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarContoller : MonoBehaviour {
  [SerializeField] private Slider _slider;
  [SerializeField] private float _fillSpeed;

  void Update() {

  }

  public void SetMaxHealth(float maxHealth) {
    _slider.maxValue = maxHealth;
    _slider.value = maxHealth;
  }

  public void SetHealth(float health) {
    float speed = _fillSpeed;
    _slider.value = Mathf.SmoothDamp(_slider.value, health, ref speed, _fillSpeed * Time.deltaTime);
  }
}
