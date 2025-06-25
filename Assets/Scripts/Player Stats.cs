using UnityEngine;

public class PlayerStats : Bandit
{
    public GameObject squareObject;
    private SpriteRenderer squareRenderer;

    public int hp;
    public int Damage;
    void Start()
    {
        if (squareObject != null)
        {
            squareRenderer = squareObject.GetComponent<SpriteRenderer>();
            squareRenderer.enabled = false;
        }

        hp = 100;
        Damage = 5;
    }

    void Update()
    {
            if (Hp < 1)
            {
                if (!m_isDead)
                    m_animator.SetTrigger("Death");

                m_isDead = !m_isDead;
            }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (squareRenderer != null)
            {
                squareRenderer.enabled = true; 
            }
        }
    }
}
