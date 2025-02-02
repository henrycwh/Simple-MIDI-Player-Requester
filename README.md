# Simple MIDI Requester & Player

## Overview

**Simple MIDI Requester & Player** is a lightweight and efficient MIDI music player designed to stream and play MIDI files in real time. It communicates with a **Music Generation Server** via **HTTP requests**, fetching MIDI stream data and playing it instantly on a **Windows application**. This application can also be monitored using **OBS (Open Broadcaster Software)** to stream live music to online platforms.

This project is ideal for developers and musicians interested in real-time music streaming, MIDI processing, and live broadcasting. Whether you're a content creator, music enthusiast, or developer looking to experiment with MIDI-based applications, this project serves as an excellent foundation.

---

## Features

✅ **Real-Time Music Streaming** - Fetches MIDI data from a remote server and plays it instantly.  
✅ **Windows Application Support** - Runs smoothly on Windows and integrates with OBS for live streaming.  
✅ **MIDI Request via HTTP** - Communicates with a remote music generation server to request MIDI files dynamically.  
✅ **OBS Integration** - Enables music streaming by capturing the player’s output window.  
✅ **Low Latency Playback** - Optimized for minimal delay, ensuring seamless real-time performance.  
✅ **User-Friendly Interface** - Simple UI for controlling playback, volume, and streaming settings.  
✅ **Customizable API Endpoints** - Configure the MIDI request server URL easily.  

---

## Technology Stack

### **Languages & Frameworks:**
- C# (.NET Framework or .NET Core)
- Windows Forms / WPF (Windows Presentation Foundation)
- HTTP Client for API communication
- MIDI Processing Libraries (e.g., `NAudio` for MIDI playback)

### **Networking & Streaming:**
- HTTP Requests to fetch MIDI data
- OBS Studio for capturing and streaming
- WebSockets (future enhancement for real-time server push notifications)

### **MIDI & Audio Processing:**
- Real-time MIDI parsing and playback
- Integration with virtual MIDI synthesizers
- Adjustable latency settings for optimized playback

---

## How It Works

1. **Client requests a MIDI file** - The Windows app sends an HTTP request to the Music Generation Server.
2. **Server responds with a MIDI stream** - The MIDI file is retrieved and processed.
3. **App plays the MIDI file in real-time** - Using a built-in MIDI player or external synthesizer.
4. **OBS captures the app’s output** - Users can stream the live performance to platforms like YouTube or Twitch.

### **Workflow Diagram**
```
+---------------------+        HTTP Request       +-------------------------+
| Windows MIDI Player| -----------------------> | Music Generation Server |
+---------------------+        MIDI Stream       +-------------------------+
           |                                                 
           v                                                 
  Audio Output Captured by OBS -> Streamed to Twitch/YouTube
```

---

## Installation & Setup

### **1. Clone the Repository**
```sh
git clone https://github.com/yourusername/SimpleMIDIPlayer.git
cd SimpleMIDIPlayer
```

### **2. Build the Project**
Open the project in **Visual Studio** and build the solution.

### **3. Configure the MIDI Server**
Modify the configuration file (`config.json` or app settings) to set the **MIDI request URL**:
```json
{
  "ServerURL": "http://your-music-server.com/api/get-midi"
}
```

### **4. Run the Application**
1. Launch the **MIDI Requester & Player**.
2. Input a song request (or use a default setting).
3. The application will fetch and play the MIDI stream.
4. Optionally, configure OBS to capture the window for live streaming.

---

## Future Improvements

🚀 **WebSocket Support** - Enable real-time MIDI push notifications from the server.  
🚀 **Cross-Platform Compatibility** - Extend support for macOS and Linux clients.  
🚀 **Advanced Synthesizer Options** - Integrate with external sound banks for better playback quality.  
🚀 **Playlist & Queueing System** - Allow users to queue multiple MIDI files dynamically.  
🚀 **OBS Auto-Configuration** - Automate OBS setup for seamless live streaming.  

---

## Contribution

Contributions are welcome! If you would like to improve the project, please **fork the repository**, create a **feature branch**, and submit a **pull request**.

---

## License

This project is licensed under the **MIT License**. Feel free to modify and distribute it.

---

## Contact

📧 **Email:** [yourname@example.com](mailto:yourname@example.com)  
🌐 **GitHub:** [yourusername](https://github.com/yourusername)
