*[Hello?]
-> Question

==Question==
*[Where am I?]
-> TheMan
*[Is anyone there?]
->TheMan

*[A hospital room?]
->TheMan

==TheMan==
Its been a long time since i've seen you 
*[Do I know you?] 
->YouAreHere

*[Hello, who are you?]
->YouAreHere

==YouAreHere==
You don't remember me do you?
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

*[I can't remember anything]
-> Nothing

==NoTime==
You're going to have to make a choice soon 
*[What do you mean?]
->Sorry

*[Why won't you answer me?]
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
*[Why are you here?]
->Nice 

*[Is that supposed to be an insult?] 
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


//Entitey2

Who are you?
    * [Im dreaming arn't I?] 
    -> Dream
    * [HELP] 
        Someone get in here and help me!
        ->Scared 
    * An owl?
    -> Calm 
    
    == Dream ==
     No Dream 
     * [This is just a nightmare] -> Scared  
     * [Then what is it?] -> Explanation1
  
  
    == Scared == 
     They all left, No one is here for you
     * Someone has to be here 
     -> Anger 
     * Why? 
     -> Explanation1
    
   
    
    == Calm ==
       ....
   * [Why are you here?] 
    There Must be a reason 
    -> Explanation1 
   * [What do you want with me?]
    What did I do? 
    -> Anger
    
    

    == Explanation1 == 
     This is not the first time you've been in a room like this
     * What?
        ... -> Explanation1
     * Was I sick? 
        -> Explanation2
    
    
    
    == Anger ==
    You cant hide from what you've done 
    * [I dont Understand] 
        What did I do? 
        -> Anger2
    * [I dont know what I did] 
        I cant even remember my name 
        -> Anger2 
        
        
        == Explanation2 ==
        No, She was sick 
    * [Who?]
        Why can't you just tell me?
        -> Anger2 
    * [I remember Somthing] 
        Her laugh 
        -> Explanation3 
        
        
        == Anger2 ==
        You need to remember
    * [remember what?]
        If you know why im here just tell me?
        -> Sad
    * [Why?]
        Why do you care if I remember?
        -> Sad
        
        
        == Explanation3 ==
        Her laugh was so sweet
        -> Sad
        
        
        == Sad == 
       She Misses you 
    * [Daughter]
        I Have a daughter
        -> Sad
    * Where is she? 
        Where are you? -> DONE
        
        
        //Entiety3
        
        My daughter where is she? 
    *I need to get to her 
    -> Void
    * [Let me out] 
        Someone, get me out of here I need to see her
    -> Void
    * What are you? 
    -> Void
    
    == Void ==
    Deal, Deal, Deal 
    * [What?]
        What kind of deal? 
        -> Deal
    * [I donn't have time for this]
        Im going to see my Daughter
        -> Agressive 
    * [I just want to see my daughter] 
        Shes needs someone 
        -> Daughter 
        
        
        == Deal ==
        Daughter Sick, Your life, save hers 
    * She can get better
    -> lie
    * [She cant die]
        I won't let her 
        -> lie
    * [you're lying]
        Shes cant be sick, shes fine. 
    ->lie    
        
        
        == Agressive ==
        daughter dead 
    * [What?] 
        She cant be dead
    -> lie
    * [You're lying] 
        You have no idea what you're talking about
    -> Agressive2
    * [BullShit]
        You're lying, how would you know
    ->Agressive2
        
        == Daughter ==
        Leave not possible 
    * Why? 
    -> Truth
    * It has to be 
    -> lie
    * What do you want with me? 
    -> Truth 
    
    
    == lie ==
        Come back to me, save her 
    * Theres another way 
    -> Mad
    * You're lying
    -> Mad
    * [Ok]
        If I die, youll save her? 
        -> lie2
    
    == Agressive2 == 
        Cancer eating her away 
    * Why are you doing this to me?
    -> Truth
    * Just let me see her
    -> lie2
    * I dont care, let me see her 
    -> Mad
    
    == Truth == 
     Cheated, Come back, Have you again 
    *Why would I do that?
    -> Truth2
    * [No]
        My daughter needs me
        ->Truth2
        
        
        == Mad == 
        ONLY WAY, COME BACK, SHE DIE
    * If I die you will save her? 
    -> lie2
    * I dont belive you
    -> Truth2
        
        
        == lie2 == 
        Your life, save her 
    * Ok
    -> DONE
    * No 
    ->Mad
        
        
        == Truth2 == 
    She will not live, Cancer, she is pale, come back to me 
    * [I remember] 
        Brain cancer but it spread fast
    ->Truth2
    * Bring me to her
    -> DONE
    * I cant see her like that again
    ->DONE
    
    
    

    
    
    
    
        
    
        
    
    
    
    
        

