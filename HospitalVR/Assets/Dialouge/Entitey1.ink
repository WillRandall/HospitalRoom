
VAR entity = 0
~ changeEntity(1)



*[...Hello?]
~ changeEntity(1)
-> Question

==Question==

*[Where am I?]
-> TheMan
*[Is anyone there...?]
->TheMan

*[...A hospital room?]
->TheMan

==TheMan==
It's been a long time since I've seen you.
*[Do I know you?] 
->YouAreHere

*[Hello. Who are you?]
->YouAreHere

==YouAreHere==
You don't remember me, do you?
*[No] 
->Confusion

==Confusion==
What do you remember?
*[Who are you?] 
->NoTime

*[Where am I?]
->NoTime

*[...]
->Nothing

==NoTime==
You're going to have to make a choice soon.
*[What do you mean?]
->Sorry

*[Why won't you answer me?]
->Sorry

==Nothing== 
That's alright. You'll remember soon.
*[Why can't I remember...?]
->Answer  

==Sorry== 
 It's awfully dark outside, isn't it?
*[I guess so, yeah?]
Why are you asking these questions? 
-> Angry

*[Stop ignoring me!] -> Angry 

==Angry== 
One last question: why are there no flowers or cards in this room? 
*[What are you implying?]
->Explanation

*[Why does that matter?] 
->Explanation

*[I don't know.] 
->Explanation

==Explanation== 
Seems a little strange that someone in a hospital would have no flowers.
*[Why are you here?]
->Nice 

*[Is that supposed to be an insult?] 
-> Angry2 

==Nice== 
I'm here because there are no flowers.
->Answer

==Angry2== 
No, but you feel hurt, don't you?
-> Answer

==Answer==
You have to make a choice soon.


//Entitey2

Who are you?
~ changeEntity(2)
    * [I'm dreaming, aren't I?]
    -> Dream
    * [HELP] 
        Someone get in here and help me!
        ->Scared 
    * An owl...?
    -> Calm 
    
    == Dream ==
     No Dream 
     * [This is just a nightmare...] -> Scared  
     * [Then what is it?] -> Explanation1
  
  
    == Scared == 
     They all left. No one is here for you.
     * Someone has to be here 
     -> Anger 
     * Why? 
     -> Explanation1
    
   
    
    == Calm ==
       ....
   * [Why are you here?] 
    There must be a reason.
    -> Explanation1 
   * [What do you want with me?]
    What did I do? 
    -> Anger
    
    

    == Explanation1 == 
     This is not the first time you've been in a room like this.
     * What?
        ... -> Explanation1
     * Was I sick? 
        -> Explanation2
    
    
    
    == Anger ==
    You can't hide from what you've done.
    * [I don't understand...] 
        What did I do? 
        -> Anger2
    * [I don't know what I did...] 
        I can't even remember my name...!
        -> Anger2 
        
        
        == Explanation2 ==
        No. She was sick.
    * [Who?]
        Why can't you just tell me?
        -> Anger2 
    * [I remember something...] 
        Her laugh 
        -> Explanation3 
        
        
        == Anger2 ==
        You need to remember.
    * [Remember what?]
        If you know why I'm here, why not just tell me?!
        -> Sad
    * [Why?]
        Why do you care if I remember?
        -> Sad
        
        
        == Explanation3 ==
        Her laugh was so sweet...
        -> Sad
        
        
        == Sad == 
       She misses you.
    * [Daughter]
        I...have a daughter...?
        -> Sad
    * Where is she? 
        ...Where are you? 
        -> E3
        
        
        //Entiety3
        == E3 ==
	~ changeEntity(3)
        My daughter. Where is she?
    *I need to get to her.
    -> Void
    * [Let me out!] 
        Someone, please! Get me out of here! I need to see her!
    -> Void
    * What are you? 
    -> Void
    
    == Void ==
    DEAL, DEAL, DEAL 
    * [What?]
        ...What kind of deal?
        -> Deal
    * [I don't have time for this!]
        I'm going to see my daughter.
        -> Agressive 
    * [I just want to see my daughter.] 
        She needs someone!
        -> Daughter 
        
        
        == Deal ==
        DAUGHTER SICK. YOUR LIFE - SAVE HERS 
    * She can get better
    -> lie
    * [She can't die.]
        I won't let her...
        -> lie
    * [You're lying.]
        She can't be sick... She's fine. 
    ->lie    
        
        
        == Agressive ==
        DAUGHTER DEAD 
    * [What?] 
        She can't be dead!
    -> lie
    * [You're lying.] 
        You have no idea what you're talking about.
    -> Agressive2
    * [Bullshit.]
        You're lying. How would you know?
    ->Agressive2
        
        == Daughter ==
        LEAVE NOT POSSIBLE
    * Why? 
    -> Truth
    * It has to be... 
    -> lie
    * What do you want with me? 
    -> Truth 
    
    
    == lie ==
        COME BACK TO ME. SAVE HER 
    * There's another way!
    -> Mad
    * You're lying!
    -> Mad
    * [Ok]
        If I die...then you'll save her?
        -> lie2
    
    == Agressive2 == 
        CANCER - EATING HER AWAY 
    * Why are you doing this to me?!
    -> Truth
    * Just let me see her!
    -> lie2
    * I don't care! Let me see her!
    -> Mad
    
    == Truth == 
     CHEATED. COME BACK - HAVE YOU AGAIN
    *Why would I do that?
    -> Truth2
    * [No]
        My daughter needs me.
        ->Truth2
        
        
        == Mad == 
        ONLY WAY, COME BACK, SHE DIE
    * If I die...then you will save her? 
    -> lie2
    * I don't belive you...
    -> Truth2
        
        
        == lie2 == 
        YOUR LIFE - SAVE HER 
    * ...Okay.
    -> DONE
    * No...
    ->Mad
        
        
        == Truth2 == 
    SHE WILL NOT LIVE - CANCER; SHE IS PALE 
    * [I remember...] 
        ...Brain cancer... It spread fast...

    ->Truth2
    * Bring me to her.
    -> DONE
    * I can't see her like that again...
    ->DONE


=== function changeEntity(newEntity) ===
~ entity = newEntity
~ return entity 

=== function ent() ===
~ return entity

    === function lower(ref x) ===
 	~ x = x - 1

 === function raise(ref x) ===
 	~ x = x + 1

    
    
    
    
        
    
        
    
    
    
    
        

