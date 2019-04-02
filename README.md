# JosephusProblem

The story goes there was once a war, and during on the its battles people were trapped by attackers in a cave. They devised a plan to avoid capture by standing in a circle, and killing each third person until only one person remained. Supposedly. And the last perseon standing was supposed to commit suicide. But in real life he decided to just surrender. Apparently that person's name was Josephus. 

So it goes.

This purpose of this exercise was to write a method called `LastPersonStanding` that, for a given `numberOfPeople` and a `killingInterval`, determines the position of the person who would remain standing. For example, if there are 10 people, and they kill every third person:
`numberOfPeople = 10`, `killingInterval = 3`

 Then the "Josephus Position" is #4.
 
 The sequence would go like this:
 ```
 1st round: 1 2 (3) 4 5 (6) 7 8 (9) 10
 2nd round:                            1 (2) 4 5 (7) 8 10
 3rd round:                                                (1) 4 5 (8) 10
 4th round:                                                               4 (5) 10
 5th round:                                                                        4 (10)
 ```
 
