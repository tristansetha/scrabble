# _Scrabble_

#### _02/14/2019_
## Author
 _**Mark Strickland: markstrickland562@hotmail.com**_

 _**Tristan Setha:tristansetha@gmail.com**_

## Description
**_This is a simple game of scrabble._**

## Specifications 
|   Behavior                          | Input Example | Output Example |
| ------------------------------------|:-------------:| :-------------:|
| User enters in an English alphabetic string  | Apple | n/a               |
| String must not have non-alpha characters | Epic0du3 |Invalid string |
| If any character is A, E, I, O, U, L, N, R, S, T, add 1 to the score for each character. | Apple | add 3 to score |
| If any character is D, G, add 2 to the score for each character. | Dog | add 4 to score |
| If any character is B, C, M, P, add 3 to the score for each character | Mop | add 6 to score |
| If any character is F, H, V, W, Y add 4 to the score for each character | Half | add 8 to score |
| If any character is K add 5 to the score for each character | Kite | add 5 to score |
| If any character is J or X add 8 to the score for each character | Jaguar | add 8 to score |
| If any character is Q or Z add 10 to the score for each character | Queen | add 10 to score |
| Total score is returned to user | Apple | score = 9 |


## Instructions
```
mcs Scrabble.cs Models/ScrabbleScorer.cs; 
mono Scrabble.exe
```

## Technologies Used
* _Mono_
* _C#_
* _ATOM_
* _Git_


## License

**

Copyright (c) 2019 **_Mark Strickland_** **_Tristan Setha_**
