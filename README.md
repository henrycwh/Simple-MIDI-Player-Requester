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

## **Installation & Setup Guide**

### **1. Open the Solution File in Visual Studio**
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/SimpleMIDIPlayer.git
   cd SimpleMIDIPlayer
   ```
2. Open **Visual Studio 2022**.
3. Navigate to the project folder and open the `.sln` file (Solution File).

---

### **2. Configure the MIDI Server**
Modify the `config.json` file to set your **MIDI request server URL**.

- **Location**: The `config.json` file is located in the project directory.
- **Modify the `download_url` parameter** to match your **music generation server**'s HTTP request URL.

#### **Example (`config.json`):**
```json
{
  "download_url": "http://your-music-server.com/api/get-midi"
}
```
> 🚀 **Ensure your server is running and accessible before proceeding.**

---

### **3. Build the Project**
Once the configuration is set up:
- Open **Visual Studio**.
- Go to **Build → Build Solution (Ctrl + Shift + B)**.
- Ensure there are no errors before proceeding.

---

### **4. Running the Application**
1. **Launch the MIDI Player Application** from Visual Studio or by running the compiled `.exe`.
2. **Generate MIDI Files**:
   - Click the **"Generate"** button.
   - **Wait for 1-2 minutes** to allow the MIDI files to be downloaded and processed.
3. **Play MIDI Files**:
   - After waiting, click the **"Play"** button.
   - **Do not press "Play" too soon**—if no MIDI files exist in the target folder, playback may fail.
4. (Optional) **Configure OBS for Live Streaming**:
   - Set up **OBS Studio** to capture the application window if you plan to stream.

---

## **Troubleshooting**
### **Common Issues & Solutions**
| Issue | Solution |
|--------|----------|
| No MIDI files found in `midi_data` | Ensure that you waited 1-2 minutes after clicking "Generate" before pressing "Play". Check if the `download_url` is correct. |
| Application crashes on startup | Ensure that the required dependencies (.NET 6.0 SDK) are installed. Run the app from Visual Studio for error logging. |
| MIDI playback doesn't work | Verify that MIDI files are present in `midi_data`. Try restarting the application. |
| Server connection error | Ensure your MIDI server is running and accessible from the configured `download_url`. |

---

## **📌 Notes**
- **Ensure your MIDI server is responsive** before generating files.
- **If no MIDI files are generated**, check the `midi_data` folder for errors.
- **For debugging**, use Visual Studio's **Output Console** to monitor HTTP requests.

🚀 Now you’re ready to use the **Simple MIDI Player**! 🎵

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
