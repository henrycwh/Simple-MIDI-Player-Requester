using Melanchall.DryWetMidi.Interaction;
using Melanchall.DryWetMidi.MusicTheory;
using System.Media;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using NAudio.Midi;
using NAudio.Wave;


namespace midi_palyer_simple_edition
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Generate_midi_Click(object sender, EventArgs e)
        {
            new AI_Midi_Receptor().Start_Download();
        }


        private void Play_midi_Click(object sender, EventArgs e)
        {
            new AI_Midi_Receptor().Play_Music();

        }


    }

}