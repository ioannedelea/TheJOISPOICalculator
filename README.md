## Description
"The JOISPOI Calculator" is a miniproject written in C# for streamer JOISPOI. It converts the players bit flags (used by spec_player command) to decimal for tv_listen_voice_indices and tv_listen_voice_indices_h cmd. The tv_listen_voice_indices and tv_listen_voice_indices_h cmds lets you selectively chose voice comms from FaceIT demos.

## How to use

1. First download and install [The JOISPOI Calculator](https://github.com/ioannedelea/TheJOISPOICalculator/releases/download/v0.1-beta/JOISPOICalculatorSetup.msi) from the releases page</li>
Run the app
2. Just play a faceIT demo using playdemo command
3. Search through spectated players using the command in CS2 console: spec_player x where x is a number.
4. Once you find a player you want to enable comms for, just right click on the console text spec_player x and press copy (you don't need to paste it into The JOISPOI Calculator. It will automatically pick it up from clipboard). 
5. Do this for every player you want comms enabled for.
6. Go back to The JOISPOI Calculator and click "Gimme the commands" button 
7. That will copy the necessary commands in the clipboard. All you need to do is paste them in the CS2 console.

