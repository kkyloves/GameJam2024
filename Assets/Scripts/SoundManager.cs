using DG.Tweening;
using UnityEngine;

namespace Script.Managers
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance;
        
        [SerializeField] private AudioSource m_walkingSFX;
        
        private int m_buySeedsSFXCounter;
        private int m_shootSFXCounter;
        private int m_hitSFXCounter;
        private int m_rocketTakeoffSFXCounter;
        private int m_explosionSFXCounter;


        private void Awake()
        {
            Instance = this;
        }

        public void PlayWalkSFX()
        {
            if (!m_walkingSFX.isPlaying)
            {
                m_walkingSFX.DOFade(0.5f, 0f).OnComplete( () => 
                {
                    m_walkingSFX.Play();
                });
            }
        }


        public void StopWalkSFX()
        {
            if (m_walkingSFX.isPlaying)
            {
                m_walkingSFX.DOFade(0f, 0.3f).SetUpdate(true).OnComplete( () => 
                {
                    m_walkingSFX.Pause();
                });
            }
        }
        
        public void PlayPlantSpawnSFX()
        {
            // m_spawnPlantSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            // {
            //     m_spawnPlantSFX.Play();
            // });
        }
    }
}
