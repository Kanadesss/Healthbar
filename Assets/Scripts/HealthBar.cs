using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
  [SerializeField] private Slider _slider;
  [Range(1, 10)][SerializeField]private float _fillSpeed;

  private float _healthTarget;
  private float _signDifference;
  private float _healthDifference;
  private bool _isHealthSet;

  void Start () {
    _isHealthSet = true;
  }

  void Update() {
    if(!_isHealthSet) {
      SetIntermediateHealth(_fillSpeed * Time.deltaTime);
    }
  }

  public void SetMaxHealth(float maxHealth) {
    _slider.maxValue = maxHealth;
    _slider.value = maxHealth;
  }

  public void SetHealth(float health) {
    _isHealthSet = false;
    _healthTarget = health;
    _healthDifference = _slider.value - _healthTarget;
    _signDifference = _healthDifference < 0 ? -1 : 1;
  }

  private void SetIntermediateHealth(float fillSpeed) {
    _slider.value -= _signDifference * fillSpeed;
    if(Mathf.Abs(_slider.value - _healthTarget) <= 0.2f) {
      _slider.value = _healthTarget;
      _isHealthSet = true;
    }
  }
}
