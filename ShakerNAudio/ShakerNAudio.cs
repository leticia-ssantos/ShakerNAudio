using System;
using NAudio.CoreAudioApi;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShakerNAudio
{
    public partial class ShakerNAudio : Form
    {

        private readonly SineWaveProvider sineProvider;
        private IWavePlayer player;
        private bool playing = false;

        public ShakerNAudio()
        {
            InitializeComponent();
            ListOutputDevices();
            sineProvider = new SineWaveProvider();
        }

        private void ShakerNAudio_Load(object sender, EventArgs e)
        {
            trackBarFrequency.Value = 120;
            trackBarGain.Value = 100;
        }

        private void trackBarFrequency_Scroll(object sender, EventArgs e)
        {
            sineProvider.Frequency = trackBarFrequency.Value;
            textBoxFrequency.Text = trackBarFrequency.Value.ToString();
        }

        private void trackBarGain_Scroll(object sender, EventArgs e)
        {
            sineProvider.Volume = ((float)trackBarGain.Value) / 100;
            textBoxGain.Text = trackBarGain.Value.ToString();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            playing = !playing;
            buttonStart.Text = playing ? "Stop" : "Play";
            if (playing)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }

        private void Play()
        {
            if (player == null)
            {
                var waveOutEvent = new WaveOutEvent();
                waveOutEvent.NumberOfBuffers = 2;
                waveOutEvent.DesiredLatency = 100;
                waveOutEvent.DeviceNumber = GetDesiredOutputDeviceId();
                player = waveOutEvent;
                player.Init(new SampleToWaveProvider(sineProvider));
            }
            player.Play();
        }

        private void Stop()
        {
            if (player == null)
                return;
            player.Dispose();
            player = null;
        }

        public void ListOutputDevices()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);

            foreach (MMDevice device in devices)
            {
                comboBoxDevices.Items.Add(device.FriendlyName);
            }

            enumerator.Dispose();
        }

        int GetDesiredOutputDeviceId()
        {
            if(comboBoxDevices.SelectedItem != null)
            {
                return comboBoxDevices.SelectedIndex;
            }
            return -1;
        }
    }
}
