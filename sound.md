# Steps 

- GITHUB:	Fork the game from github
- UNITY:	import game
- UNITY:	import Fmod from hub and import it to the project
- UNITY:	Setup fmod properly
- .gitgnore:	add assets/fmod*
- FMOD:	create a new project with the needed sounds
- DAW:	create a rising event sound (when bird is ascending by pressing space bar)
- DAW:	create a happy background music
- DAW:	export wave files to unitys project folder
- FMOD: 	import sounds from DAW export
- UNITY:	remove/disable unity default sound to enable fmod one

- UNITY:	add in main scene the FMOD Attenuation Object (bird/player)
- UNITY:	add in AudioManager script to handle events
- UNITY:	add FMOD Events instance for use in AudioManager
- UNITY:	add FMOD Event instance for flying sound
