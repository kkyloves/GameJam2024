using DG.Tweening;
using UnityEngine;

namespace Script.Managers
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance;
        
        [SerializeField] private AudioSource m_walkingSFX;
        [SerializeField] private AudioSource m_alarmSFX;
        [SerializeField] private AudioSource m_doorWindSFX;
        [SerializeField] private AudioSource m_catFootStepSFX;
        [SerializeField] private AudioSource m_catMeowSFX;


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

        public void PlayAlarmClockSFX()
        {
            m_alarmSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_alarmSFX.Play();
            });
        }

        public void PlayDoorWindSFX()
        {
            m_doorWindSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_doorWindSFX.Play();
            });
        }
        
        public void PlayCatFootStepSFX()
        {
            m_catFootStepSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_catFootStepSFX.Play();
            });
        }

        public void PlayMeowSFX()
        {
            m_catMeowSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_catMeowSFX.Play();
            });
        }
    }
}
