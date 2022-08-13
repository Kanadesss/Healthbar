using UnityEngine;

public class PlayerHealth : MonoBehaviour {
  [SerializeField] private float _maxHealth;
  [SerializeField] private HealthBar _healthBar;
  [SerializeField] private float _damageValue;
  [SerializeField] private float _healValue;

  private float _currentHealth;

  void Start() {
    _healthBar.SetMaxHealth(_maxHealth);
    _currentHealth = _maxHealth;
  }

  public void HealthDamage() {
    if(_currentHealth - _damageValue > 0) {

      _currentHealth -= _damageValue;
    } else {
      _currentHealth = 0;
    }
    _healthBar.SetHealth(_currentHealth);
  }

  public void HealthHeal() {
    if(_currentHealth + _healValue < _maxHealth) {

      _currentHealth += _healValue;
    } else {
      _currentHealth = _maxHealth;
    }
    _healthBar.SetHealth(_currentHealth);
  }
}
