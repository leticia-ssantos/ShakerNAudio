using System;
using NAudio.CoreAudioApi;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace ShakerNAudio
{
    public partial class ShakerNAudio : Form
    {
        private readonly SineWaveProvider sineProvider;
        private readonly PanningSampleProvider panProvider;
        private IWavePlayer player;
        private bool playing = false;
        private float chA, chB;
        private float volume, ch;

        public ShakerNAudio()
        {
            InitializeComponent();
            ListOutputDevices();
            sineProvider = new SineWaveProvider();
            panProvider = new PanningSampleProvider(sineProvider);
        }

        private void ShakerNAudio_Load(object sender, EventArgs e)
        {
            panProvider.Pan = 0;
            trackBarFrequency.Value = 120;
            trackBarGain.Value = 15;
        }

        private void trackBarFrequency_Scroll(object sender, EventArgs e)
        {
            sineProvider.Frequency = trackBarFrequency.Value;
            textBoxFrequency.Text = trackBarFrequency.Value.ToString();
        }

        private void trackBarGain_Scroll(object sender, EventArgs e)
        {
            volume = ((float)trackBarGain.Value) / 100;
            textBoxGain.Text = trackBarGain.Value.ToString();
            sineProvider.Volume = ch * volume;
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
                player.Init(new SampleToWaveProvider(panProvider));
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

        private void trackBarPanChA_ValueChanged(object sender, EventArgs e)
        {
            chA = ((float)trackBarPanChA.Value / 100);
            UpdateProviders();
        }

        private void trackBarPanChB_ValueChanged(object sender, EventArgs e)
        {
            chB = ((float)trackBarPanChB.Value / 100);
            UpdateProviders();
        }

        private void UpdateProviders()
        {
            if (chB == 0)
            {
                panProvider.Pan = 1;
            }
            else if (chA == 0)
            {
                panProvider.Pan = -1;
            }
            else
            {
                panProvider.Pan = chA - chB;
            }

            if (chA > chB)
            {
                ch = chA;
            }
            else
            {
                ch = chB;
            }
            sineProvider.Volume = ch * volume;
        }
    }
}
