using DG.Tweening;
using UnityEngine;

namespace Script.Managers
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance;
        
        [SerializeField] private AudioSource m_walkingSFX;
        [SerializeField] private AudioSource m_catFootStepSFX;
        [SerializeField] private AudioSource m_catMeowSFX;
        // lvl1 bedroom
        [SerializeField] private AudioSource m_openCurtainSFX;
        [SerializeField] private AudioSource m_alarmSFX;
        [SerializeField] private AudioSource m_doorWindSFX;
        // lvl2 bathroom
        [SerializeField] private AudioSource m_showerSFX;
        [SerializeField] private AudioSource m_brushingTeethSFX;
        // lvl3 kitchen
        [SerializeField] private AudioSource m_refOpeningSFX;
        [SerializeField] private AudioSource m_drinkingSFX;
        [SerializeField] private AudioSource m_eatingCerealSFX;
        [SerializeField] private AudioSource m_movingChairSFX;
        [SerializeField] private AudioSource m_cleaningDishesSFX;
        // lvl4 livingroom
        [SerializeField] private AudioSource m_chimneyFireSFX;
        [SerializeField] private AudioSource m_radioOnSFX;
        [SerializeField] private AudioSource m_seatingInSofaSFX;

        [SerializeField] private AudioSource m_nextLevelSFX;
        [SerializeField] private AudioSource m_catJumpSFX;


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
        
        public void PlayCatFootStepSFX()
        {
            if (!m_catFootStepSFX.isPlaying)
            {
                m_catFootStepSFX.DOFade(0.5f, 0f).OnComplete( () => 
                {
                    m_catFootStepSFX.Play();
                });
            }
        }
        
        public void StopCatFootStepSFX()
        {
            if (m_catFootStepSFX.isPlaying)
            {
                m_catFootStepSFX.DOFade(0f, 0.3f).SetUpdate(true).OnComplete( () => 
                {
                    m_catFootStepSFX.Pause();
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
        
        public void PlayMeowSFX()
        {
            m_catMeowSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_catMeowSFX.Play();
            });
        }

        public void PlayOpenCurtainSFX()
        {
            m_openCurtainSFX.DOFade(0.1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_openCurtainSFX.Play();
            });
        }

        public void PlayAlarmClockSFX()
        {
            m_alarmSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_alarmSFX.Play();
            });
        }
        
        public void StopAlarmClockSFX()
        {
            m_alarmSFX.DOFade(0f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_alarmSFX.Pause();
            });
        }

        public void PlayDoorWindSFX()
        {
            m_doorWindSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_doorWindSFX.Play();
            });
        }

        public void PlayShowerSFX()
        {
            m_showerSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_showerSFX.Play();
            });
        }
        
        public void StopShowerSFX()
        {
            m_showerSFX.DOFade(0f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_showerSFX.Pause();
            });
        }

        public void PlayBrushingTeethSFX()
        {
            m_brushingTeethSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_brushingTeethSFX.Play();
            });
        }
        
        public void StopToothbrushSFX()
        {
            m_brushingTeethSFX.DOFade(0f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_brushingTeethSFX.Pause();
            });
        }

        public void PlayRefOpeningSFX()
        {
            m_refOpeningSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_refOpeningSFX.Play();
            });
        }

        public void PlayDrinkingSFX()
        {
            m_drinkingSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_drinkingSFX.Play();
            });
        }

        public void PlayEatingCerealSFX()
        {
            m_eatingCerealSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_eatingCerealSFX.Play();
            });
        }
        
        public void StopEatingCerealSFX()
        {
            m_eatingCerealSFX.DOFade(0f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_eatingCerealSFX.Pause();
            });
        }

        public void PlayMovingChairSFX()
        {
            m_movingChairSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_movingChairSFX.Play();
            });
        }

        public void PlayCleaningDishesSFX()
        {
            m_cleaningDishesSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_cleaningDishesSFX.Play();
            });
        }

        public void PlayChimneyFireSFX()
        {
            m_chimneyFireSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_chimneyFireSFX.Play();
            });
        }

        public void PlayRadioOnSFX()
        {
            m_radioOnSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_radioOnSFX.Play();
            });
        }

        public void PlaySeatingInSofaSFX()
        {
            m_seatingInSofaSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_seatingInSofaSFX.Play();
            });
        }

        public void PlayNextLevelSFX()
        {
            m_nextLevelSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_nextLevelSFX.Play();
            });
        }

        public void PlayCatJumpSFX()
        {
            m_catJumpSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_catJumpSFX.Play();
            });
        }
    }
}
