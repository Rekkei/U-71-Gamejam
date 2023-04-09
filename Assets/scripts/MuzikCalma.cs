using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MuzikCalma : MonoBehaviour
{
    public Slider volumeSlider;
    public Button playButton;
    public Button pauseButton;

    public GameObject checkOn;
    public GameObject checkOff;

    public List<AudioClip> musicList;
    public AudioSource audioSource;
    private int currentTrackIndex = 0;

    private void Start()
    {
        // Müzik ses seviyesi ve müzik açýk/kapalý tercihlerini yükle
        //if (PlayerPrefs.HasKey("musicVolume"))
        //{
        //    volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        //}
        //if (PlayerPrefs.HasKey("musicOn"))
        //{
        //    bool musicOn = PlayerPrefs.GetInt("musicOn") == 1;
        //    if (musicOn)
        //    {
        //        PlayMusic();
        //    }
        //    else
        //    {
        //        PauseMusic();
        //    }
        //}

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musicList[0]; // Varsayýlan olarak ilk müziði çal
        audioSource.Play();

        volumeSlider.onValueChanged.AddListener(delegate { OnVolumeChanged(); });
        playButton.onClick.AddListener(delegate { PlayMusic(); });
        pauseButton.onClick.AddListener(delegate { PauseMusic(); });

        StartCoroutine(PlayNextTrack());
    }


    private void OnVolumeChanged()
    {
        audioSource.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }


    private void PlayMusic()
    {
        checkOff.SetActive(false);
        checkOn.SetActive(true);
        audioSource.Play();
        //PlayerPrefs.SetInt("musicOn", 1);
    }

    private void PauseMusic()
    {
        checkOff.SetActive(true);
        checkOn.SetActive(false);
        audioSource.Pause();
        //PlayerPrefs.SetInt("musicOn", 0);
    }

    private IEnumerator PlayNextTrack()
    {
        while (true)
        {
            yield return new WaitForSeconds(audioSource.clip.length); // Þu anki müzik tamamlanmadan önce bekle

            currentTrackIndex++;
            if (currentTrackIndex >= musicList.Count)
            {
                currentTrackIndex = 0;
            }

            audioSource.clip = musicList[currentTrackIndex];
            audioSource.Play();
        }
    }

}

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    //    public static MuzikCalma instance;

    //    public Slider volumeSlider;
    //    public Button musicButton;
    //    public Button soundButton;
    //    public Text songTitle;

    //    private bool isMusicPlaying = false;
    //    private int currentSongIndex = 0;
    //    private float savedVolume;

    //    private AudioSource audioSource;
    //    private AudioClip[] songs;

    //    private void Awake()
    //    {
    //        if (instance == null)
    //        {
    //            instance = this;
    //            DontDestroyOnLoad(gameObject);
    //        }
    //        else
    //        {
    //            Destroy(gameObject);
    //        }
    //    }

    //    private void Start()
    //    {
    //        audioSource = GetComponent<AudioSource>();
    //        songs = Resources.LoadAll<AudioClip>("Music");

    //        if (PlayerPrefs.HasKey("Volume"))
    //        {
    //            float volume = PlayerPrefs.GetFloat("Volume");
    //            volumeSlider.value = volume;
    //            AudioListener.volume = volume;
    //            savedVolume = volume;
    //        }
    //        else
    //        {
    //            AudioListener.volume = 1f;
    //            savedVolume = 1f;
    //        }

    //        if (PlayerPrefs.HasKey("IsMusicPlaying"))
    //        {
    //            bool isPlaying = PlayerPrefs.GetInt("IsMusicPlaying") == 1;
    //            isMusicPlaying = isPlaying;
    //            if (isPlaying)
    //            {
    //                PlayMusic();
    //            }
    //            else
    //            {
    //                StopMusic();
    //            }
    //        }
    //        else
    //        {
    //            isMusicPlaying = true;
    //            PlayMusic();
    //        }
    //    }

    //    private void Update()
    //    {
    //        if (Input.GetKeyDown(KeyCode.Escape))
    //        {
    //            SceneManager.LoadScene("MainMenu");
    //        }
    //    }

    //    public void PlayMusic()
    //    {
    //        if (!isMusicPlaying)
    //        {
    //            isMusicPlaying = true;
    //            audioSource.clip = songs[currentSongIndex];
    //            audioSource.Play();
    //            songTitle.text = audioSource.clip.name;
    //            musicButton.GetComponentInChildren<Text>().text = "Müziði Kapat";
    //        }
    //    }

    //    public void StopMusic()
    //    {
    //        if (isMusicPlaying)
    //        {
    //            isMusicPlaying = false;
    //            audioSource.Stop();
    //            musicButton.GetComponentInChildren<Text>().text = "Müziði Aç";
    //        }
    //    }

    //    public void NextSong()
    //    {
    //        currentSongIndex = (currentSongIndex + 1) % songs.Length;
    //        audioSource.clip = songs[currentSongIndex];
    //        audioSource.Play();
    //        songTitle.text = audioSource.clip.name;
    //    }

    //    public void PrevSong()
    //    {
    //        currentSongIndex--;
    //        if (currentSongIndex < 0)
    //        {
    //            currentSongIndex = songs.Length - 1;
    //        }
    //        audioSource.clip = songs[currentSongIndex];
    //        audioSource.Play();
    //        songTitle.text = audioSource.clip.name;
    //    }

    //    public void ChangeVolume(float volume)
    //    {
    //        AudioListener.volume = volume;
    //        savedVolume = volume;
    //        PlayerPrefs.SetFloat("Volume", volume);
    //    }

    //    public void SesAcKapat(bool acikMi)
    //    {
    //        if (acikMi)
    //        {
    //            AudioListener.volume = savedVolume;
    //        }
    //        else
    //        {
    //            AudioListener.volume = 0f;
    //        }
    //    }
    //}

    //private static MuzikCalma instance;
    //public GameObject checkOn;
    //public GameObject checkOff;

    //private float musicVolume = 1.0f;

    //public static MuzikCalma Instance
    //{
    //    get
    //    {
    //        if (instance == null)
    //        {
    //            instance = FindObjectOfType<MuzikCalma>();
    //            DontDestroyOnLoad(instance.gameObject);
    //        }
    //        return instance;
    //    }
    //}

    //public bool isMusicEnabled = true; // Müzik açýk mý kapalý mý?

    //private AudioSource audioSource; // Müzik çalma için kullanýlacak AudioSource bileþeni

    //public AudioClip[] musicList; // Çalýnacak müziklerin listesi

    //private int currentTrackIndex = 0; // Þu an çalýnan müziðin dizindeki index'i

    //public Slider musicVolumeSlider;

    //void Start()
    //{
    //    bool musicOn = PlayerPrefs.GetInt("MusicOn") == 1;
    //    audioSource.mute = !musicOn;
    //    musicToggle.isOn = musicOn;

    //    if (PlayerPrefs.HasKey("MusicVolume"))
    //    {
    //        musicVolume = PlayerPrefs.GetFloat("MusicVolume");
    //    }

    //    audioSource = GetComponent<AudioSource>();
    //    audioSource.loop = true;
    //    PlayMusic();

    //    musicVolumeSlider.value = audioSource.volume;
    //    musicVolumeSlider.onValueChanged.AddListener(SetMusicVolume);
    //}

    //void Update()
    //{
    //    if (!audioSource.isPlaying && isMusicEnabled)
    //    {
    //        // Müzik bitmiþ ve müzik açýk durumda, bir sonraki müziði çal
    //        currentTrackIndex = (currentTrackIndex + 1) % musicList.Length;
    //        audioSource.clip = musicList[currentTrackIndex];
    //        audioSource.Play();
    //    }
    //}

    //public void ToggleMusic(bool isOn)
    //{
    //    audioSource.mute = !isOn;
    //    PlayerPrefs.SetInt("MusicOn", isOn ? 1 : 0);
    //}

    //// Müzik çalma ve durdurma iþlemleri
    //public void PlayMusic()
    //{
    //    // Müzik açýk ise
    //    if (isMusicEnabled)
    //    {
    //        audioSource.clip = musicList[currentTrackIndex];
    //        audioSource.Play();
    //    }
    //}

    //public void StopMusic()
    //{
    //    audioSource.Stop();
    //}

    //// Müzik açma/kapama iþlemleri
    //public void EnableMusic()
    //{
    //    isMusicEnabled = true;
    //    PlayMusic();
    //    checkOff.SetActive(false);
    //    checkOn.SetActive(true);
    //}

    //public void DisableMusic()
    //{
    //    isMusicEnabled = false;
    //    StopMusic();
    //    checkOff.SetActive(true);
    //    checkOn.SetActive(false);
    //}

    //public void SetMusicVolume(float volume)
    //{
    //    audioSource.volume = volume;
    //    musicVolume = volume;
    //    PlayerPrefs.SetFloat("MusicVolume", volume);
    //}
