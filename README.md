# Pathfinding Bot Simulator
This simulator will run your pathfinding algorithms in a controlled environment. This provides a target for your bots to reach, and tracks statistics such as steps taken and the total cost of your bath (based on the weighting of the tiles you pass through).
Your bots will operate blind. This means that the simulator will only provide your bots with the information of the 8 tiles surrounding your bot. Your bot cannot see the target until it is within the 8 tile radius. As such, your bots are as much a searching algorithm as they are a pathfinding algorithm.

Your bots do not need to interface with any code, thr simulator will communicate with your algorithms via the console. Your bot must output information to the console via the following communication protocol.
## Communication Protocol
&gt;&gt; Messages sent to the console from the simulator (```Console.ReadLine()```) <br>
&lt;&lt; Messages sent from your algotithm to the console (```Console.WriteLine()```) <br>
\# Message to the user to be dispayed on screen during the simulation (used for debugging) <br>
// Comments for this documentation to aid you. Do not include in your communications <br>

// To start, the console will test that communication is working by sending an initial message <br>
&gt;&gt; Reading? <br>
&lt;&lt; My Bots Name // Here, as your reply, send the name of your bot to be shared on screen <br>
&gt;&gt; 64 // Once the simulator has tested that communication works, it will send through the size of the board. The board will always be square <br>
&gt;&gt; Start // The simulator will then send a start command to show the simulation has started <br>

// The next section works in a loop until the bot reaches the target <br>
&gt;&gt; X,12,121,87,X,X,12,97 // The simulator will send a string to show information about the 8 squares around the bot's current position. The string shows the square from the space directly above the bot, working clockwise around the bot. A number denotes a traversable space and the spaces weight, an X shows a blocked space that the bot cannot traverse through, a forward slash denotes an out of bounds space. <br>
&lt;&lt; Right // The bot can then send either Right, Left, Up or Down <br>
&lt;&lt; # You can send any messages to be shown on screen here. Messages here dont have to follow any format as long as they start with a #. Please note the console will not wrap long messages so keep them short <br>
&lt;&lt; # You can send as many messages as you want <br>
&lt;&lt; Over // Once you have sent your direction (Up, Down, Left, Right), and any messages you want to send, send the command Over to denote the the end of communication for your turn <br>
&gt;&gt; Confirm // Once you have sent your direction, the bot will either send Confirm (if the move is valid) or Invalid (if the move is invalid) <br>

// Once you reach the target, the simulator will send an end message <br>
&gt;&gt; End <br>
