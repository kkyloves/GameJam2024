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

        [SerializeField] private AudioSource m_aDayToRememberSFX;
        [SerializeField] private AudioSource m_idleImWorthlessSFX;
        [SerializeField] private AudioSource m_idleLifeSucksSFX;
        [SerializeField] private AudioSource m_idleWhateverSFX;
        [SerializeField] private AudioSource m_uponClickingBathtubSFX;
        [SerializeField] private AudioSource m_uponClickingDishesSFX;
        [SerializeField] private AudioSource m_uponEnteringBathroomSFX;
        [SerializeField] private AudioSource m_uponEnteringKitchenSFX;
        [SerializeField] private AudioSource m_uponOpeningRefSFX;
        [SerializeField] private AudioSource m_uponOpeningWindowSFX;
        [SerializeField] private AudioSource m_uponWakingUpCatSFX;

        [SerializeField] private AudioSource m_gameStartDontWakeMeUpSFX;
        [SerializeField] private AudioSource m_gameStartGetOutSFX;
        [SerializeField] private AudioSource m_gameStartShutUpAlreadySFX;

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
            m_drinkingSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_drinkingSFX.Play();
            });
        }
        
        public void StopDrinkingWaterSFX()
        {
            Debug.Log("drinking water");

            m_drinkingSFX.DOFade(0f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_drinkingSFX.Pause();
            });
        }

        public void PlayEatingCerealSFX()
        {
            m_eatingCerealSFX.DOFade(0.5f, 0f).SetUpdate(true).OnComplete( () => 
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
            m_movingChairSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_movingChairSFX.Play();
            });
        }

        public void PlayCleaningDishesSFX()
        {
            m_cleaningDishesSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_cleaningDishesSFX.Play();
            });
        }

        public void PlayChimneyFireSFX()
        {
            m_chimneyFireSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_chimneyFireSFX.Play();
            });
        }

        public void PlayRadioOnSFX()
        {
            m_radioOnSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_radioOnSFX.Play();
            });
        }

        public void PlaySeatingInSofaSFX()
        {
            m_seatingInSofaSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_seatingInSofaSFX.Play();
            });
        }

        public void PlayNextLevelSFX()
        {
            m_nextLevelSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_nextLevelSFX.Play();
            });
        }

        public void PlayCatJumpSFX()
        {
            m_catJumpSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_catJumpSFX.Play();
            });
        }

        public void PlayADayToRememberSFX()
        {
            m_aDayToRememberSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_aDayToRememberSFX.Play();
            });
        }
        public void PlayIdleImWOrthlessSFX()
        {
            m_idleImWorthlessSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_idleImWorthlessSFX.Play();
            });
        }
        public void PlayIdleLifeSucksSFX()
        {
            m_idleLifeSucksSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_idleLifeSucksSFX.Play();
            });
        }
        public void PlayIdleWhateverSFX()
        {
            m_idleWhateverSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_idleWhateverSFX.Play();
            });
        }
        public void PlayUponClickingBathtubSFX()
        {
            m_uponClickingBathtubSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_uponClickingBathtubSFX.Play();
            });
        }
        public void PlayUponClickingDishesSFX()
        {
            m_uponClickingDishesSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_uponClickingDishesSFX.Play();
            });
        }
        public void PlayUponEnteringBathroomSFX()
        {
            m_uponEnteringBathroomSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_uponEnteringBathroomSFX.Play();
            });
        }
        public void PlayUponEnteringKitchenSFX()
        {
            m_uponEnteringKitchenSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_uponEnteringKitchenSFX.Play();
            });
        }
        public void PlayUponOpeningRefSFX()
        {
            m_uponOpeningRefSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_uponOpeningRefSFX.Play();
            });
        }
        public void PlayUponOpeningWindowSFX()
        {
            m_uponOpeningWindowSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_uponOpeningWindowSFX.Play();
            });
        }
        public void PlayUponWakingUpCatSFX()
        {
            m_uponWakingUpCatSFX.DOFade(1f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_uponWakingUpCatSFX.Play();
            });
        }

        public void PlayGameStartDontWakeMeUpSFX()
        {
            m_gameStartDontWakeMeUpSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_gameStartDontWakeMeUpSFX.Play();
            });
        }
        public void PlayGameStartGetOutSFX()
        {
            m_gameStartGetOutSFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_gameStartGetOutSFX.Play();
            });
        }
        public void PlayGameStartShutUpAlreadySFX()
        {
            m_gameStartShutUpAlreadySFX.DOFade(0.3f, 0f).SetUpdate(true).OnComplete( () => 
            {
                m_gameStartShutUpAlreadySFX.Play();
            });
        }
    }
}
