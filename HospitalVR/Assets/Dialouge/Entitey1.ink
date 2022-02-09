*[Hello?]
-> Question

==Question==
*[Where am I?]
-> TheMan
*[is anyone there?]
->TheMan

*[A hospital room?]
->TheMan

==TheMan==
Its been a long time since iv seen you 
*[Do I know you?] 
->YouAreHere

*[Hello, who are you?]
->YouAreHere

==YouAreHere==
You don't remember me do you?
*[No] 
->Confusion

==Confusion==
what do you remember?
*[...]
->Nothing

*[Who are you?] 
->NoTime

*[where am I?]
->NoTime

==NoTime==
You're going to have to make a choice soon 
*[what do you mean?]
->Sorry

*[why won't you answer me?]
->Sorry



==Nothing== 
Thats ok, you'll remember soon. 
*[Why can't I remember]
->Answer  

==Sorry== 
 It's offly dark outside isnt it? 
*[I guess so yeah?]
Why are you asking these questions? 
-> Angry

*[Stop ignoring me] -> Angry 


==Angry== 
One last question, Why are there no flowers or cards in this room? 
*[What are you implying]
->Explanation

*[Why does that matter?] 
->Explanation

*[I dont know] 
->Explanation


==Explanation== 
Seems a little strange someone in a hospital would have no flowrs.
*[why are you here?]
->Nice 

*[is that supposed to be an insult?] 
-> Angry2 


==Nice== 
Im here because there are no flowrs
->Answer


==Angry2== 
No, but you feel hurt don't you?
-> Answer

==Answer==
You have to make a choice soon 
-> DONE



