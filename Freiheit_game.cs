using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TextController : MonoBehaviour {

public Text text;


//STATES USED THROUGHOUT THE GAME  


private enum States {title, room, window, door, toilet, noise, beating, death, hallway, left_hall, right_hall, guard_wait_right_hall,
					door_outside,street, road, alley, crowd, id_checkpoint, go_right_id_check, go_left_id_check, unarmed_move_forward, encounter_unarmed,
					homeless_unarmed, pipe_weapon, homeless_armed_1, homeless_armed_2, encounter_armed, attack, respect, join, dont_join, mission_1, 
					kill_sleeping_1, kill_sleeping_2, mission_2, back_in_streets, seen_2_much, wander, newspaper, id_check_spotted_left, try_2_run, 
					take_help_offer, sewer_left, sewer_right, sewer_swim, sewer_shimmy, sewer_gates, sewer_king, sewer_escape, forest, live_off_land, 
					travel, checkpoint_id_2, other_direction_endgame, dronestrike 
					};


private States MyState;
	// Use this for initialization
	
	
	
	
	void Start () {
		
		if (Input.GetKeyDown(KeyCode.Space)) {MyState = States.room;}		
	}
	
	
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//IF / ELSE IF STATEMENTS REGUARDING GAMESTATES / "ROOMS" 
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	
	void Update () {
		if (MyState == States.title)						{state_title ();}
		else if (MyState == States.room)					{state_room ();} 
		else if (MyState == States.window)					{state_window ();}
		else if (MyState == States.door)					{state_door ();} 
		else if (MyState == States.toilet)					{state_toilet ();} 
		else if (MyState == States.noise)					{state_noise ();}
		else if (MyState == States.beating)					{state_beating ();}
		else if (MyState == States.death)					{state_death ();} 
		else if (MyState == States.hallway)					{state_hallway ();}
		else if (MyState == States.right_hall)					{state_right_hall ();} 
		else if (MyState == States.left_hall)					{state_left_hall ();} 
		else if (MyState == States.guard_wait_right_hall)			{state_guard_wait_right_hall ();} 
		else if (MyState == States.door_outside)				{state_door_outside ();} 
		else if (MyState == States.street)					{state_street ();} 
		else if (MyState == States.road)					{state_road();} 
		else if (MyState == States.crowd)					{state_crowd();}
		else if (MyState == States.alley)					{state_alley();} 
		else if (MyState == States.id_checkpoint)				{state_id_checkpoint ();} 
		else if (MyState == States.go_right_id_check)				{state_go_right_id_check ();} 
		else if (MyState == States.go_left_id_check)				{state_go_left_id_check ();} 
		else if (MyState == States.unarmed_move_forward)			{state_unarmed_move_forward ();} 
		else if (MyState == States.encounter_unarmed)				{state_encounter_unarmed();}
		else if (MyState == States.homeless_unarmed)				{state_homeless_unarmed ();} 
		else if (MyState == States.pipe_weapon)					{state_pipe_weapon ();} 
		else if (MyState == States.homeless_armed_1)				{state_homeless_armed_1 ();} 
		else if (MyState == States.homeless_armed_2)				{state_homeless_armed_2 ();} 
		else if (MyState == States.encounter_armed)				{state_encounter_armed();}
		else if (MyState == States.attack)					{state_attack();} 
		else if (MyState == States.respect)					{state_respect();} 
		else if (MyState == States.join)					{state_join();} 
		else if (MyState == States.dont_join)					{state_dont_join();} 
		else if (MyState == States.mission_1)					{state_mission_1();}
		else if (MyState == States.kill_sleeping_1)				{state_kill_sleeping_1();} 
		else if (MyState == States.kill_sleeping_2)				{state_kill_sleeping_2();} 
		else if (MyState == States.mission_2)					{state_mission_2();} 
		else if (MyState == States.back_in_streets)				{state_back_in_streets ();} 
		else if (MyState == States.seen_2_much)					{state_seen_2_much ();}
		else if (MyState == States.wander)					{state_wander ();} 
		else if (MyState == States.newspaper)					{state_newspaper ();} 
		else if (MyState == States.id_check_spotted_left)			{state_id_check_spotted_left ();} 
		else if (MyState == States.try_2_run)					{state_try_2_run ();} 
		else if (MyState == States.take_help_offer)				{state_take_help_offer ();}
		else if (MyState == States.sewer_left)					{state_sewer_left ();} 
		else if (MyState == States.sewer_right)					{state_sewer_right ();} 
		else if (MyState == States.sewer_swim)					{state_sewer_swim ();}
		else if (MyState == States.sewer_shimmy)				{state_sewer_shimmy ();} 
		else if (MyState == States.sewer_gates)					{state_sewer_gates ();} 
		else if (MyState == States.sewer_king)					{state_sewer_king ();} 
		else if (MyState == States.sewer_escape)				{state_sewer_escape ();}
		else if (MyState == States.forest)					{state_forest ();} 
		else if (MyState == States.live_off_land)				{state_live_off_land ();}
		else if (MyState == States.travel)					{state_travel ();} 
		else if (MyState == States.checkpoint_id_2)				{state_checkpoint_id_2 ();} 
		else if (MyState == States.other_direction_endgame)			{state_other_direction_endgame ();} 
		else if (MyState == States.dronestrike)					{state_dronestrike ();} 

		
	} 
	
	
	private void Update()
	{
		// check for escape key
		if(Input.GetKeyDown(KeyCode.Escape){Application.Quit();}
			// quit the application
	}

	
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// TITLE CARD
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------		
	void state_title (){ 
		text.text = "\n \n 'F R E I H E I T' - Please press [SPACEBAR] to begin your journey. \n \n \n \n" + "------------------ \nCopyright © 2018 by Cody James Ryan " +
					"All rights reserved. No part of this publication may be reproduced, distributed, or transmitted in any form or by any means, " + 
					"including photocopying, recording, or other electronic or mechanical methods, without the prior written permission of the " +
					"publisher, except in the case of brief quotations embodied in critical reviews and certain other noncommercial " +
					"uses permitted by copyright law. For permission requests, write to the publisher, addressed " + 
					"“Attention: Permissions Coordinator,” at the email below. \n \n " + "PlVSVLTRA969@GMAIL.COM \n ------------------"; 
				if (Input.GetKeyDown(KeyCode.Space)) {MyState = States.room;}  //beginning room
				}
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// FIRST ACT / BEGINNING BUILDING SCENE
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	
	
	
	void state_room () { 
		text.text="Dawn breaks on a new day and you awaken in a groggy stupor, the sun is filling the small cold room you find yourself in. " +
					"Your head hurts and you don't remember how you arrived here. As you shake off the sleep, you hear voices in the distance talking. " + 
					"As you look around the room: There's the simple cot you were sleeping on, a small toilet in the corner of the room, " + 
					"and a door and a small slit window. Otherwise the cold room is empty and drafty. You continue hearing voices beyond the door. \n ------------------ \n\n" +
					"------------------Press------------------ \n [T] to look at the toilet \n [W] to look at the window slit \n [D] to approach the door";    
		 if (Input.GetKeyDown(KeyCode.W)) {MyState = States.window;}
		 if (Input.GetKeyDown(KeyCode.D)) {MyState = States.door;}
		 if (Input.GetKeyDown(KeyCode.T)) {MyState = States.toilet;}
		}
	void state_window () { 
		text.text="You try to peer out the small slit to see the outside world but you're met with only blinding light from the outside, it's too bright to see. As you listen however, you can hear the distinct sounds of " +
					"a crowd of people bustling about, you imagine you're in some sort of busy city. \n ------------------ \n \n ------------------Press------------------ \n [R] to return to roaming your room.";    
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		}
	void state_door () {
		text.text="You approach the cold steel door. You hear voices murmuring from somewhere on the other side of the door, but you cannot make out what they are saying. " +
					"You notice there's blood on both the floor and the door. You think to yourself, maybe drawing some attention to yourself is a good idea. \n ------------------ \n \n ------------------Press------------------ \n [M] to make some noise to attract attention" +
					"\n [R] to return to investigating the room";    
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.noise;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		}
	void state_toilet () {
		text.text="You walk up to the toilet in the room, it's surprisingly clean! The toilet paper is dry and coarse however, and you notice it is very thin. You sit down for a moment to contemplate your situation. " +
					"''Life is a cruel and unsusal place for putting me here.'' You think to yourself as you sit on your clean toilet. You further ponder.\n ------------------ \n \n ------------------Press------------------ \n " +
					"[R] to return to investigating the room, your legs are getting tired anyways. \n  \n Press nothing to continue to sit on the shitter and consider";  
			if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		}
	void state_noise () {
		text.text="You begin screaming and howling as if you were a wounded dog. Banging and pounding on the door with all your might, you're certain that this display will attract some attention and you can finally demand some " + 
					"answers around here. You've been waiting patiently for who know's how long now! Long enough that's for certain. *BANG BANG* you pound on the door as your audible wails continue \n ------------------ \n \n " + 
					"------------------Press------------------ \n [SPACEBAR] to pound on the door like it owed you money"; 
		if (Input.GetKeyDown(KeyCode.Space)) {MyState = States.beating;}
		}
	void state_beating () {
		text.text="4 men in tactical body armor rush into the room with night sticks and, as you begin to demand to know just what is going on here, they begin swinging wildly and the clubs begin connecting with " + 
					"various parts of your body, you feel and hear your bones crunching and fracturing beneath their consecutive blows. You notice a moment where you're able to slip out from their beatings and sprint out the open door, " +
					"it seems as if the guards take a moment to notice that you've slipped out in the blind fury of their swings. \n ------------------ \n \n ------------------Press------------------ \n [X] to wait for the guards to realize " +
					"you've slipped out, and try and fight them \n [SPACEBAR] to hurry down the hallway";  
		if (Input.GetKeyDown(KeyCode.Space)) {MyState = States.hallway;}
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.death;}
		}
	void state_death () {
		text.text="Nobody is really sure why you thought this would be a good idea, but you put your fists up and prepare for combat. Suddenly the 4 men realize you've crawled out from the beating and they rush you " + 
					"and begin pummling you with a renewed vigor. Your trying your best to pick up your teeth from the ground between blows but then a particularly nasty swing cracks your eye socket and you lose vision. " +
					"The sound of night sticks falling on bruised flesh and broken bone are the last sounds you hear as you black out and never regain consiousness. \n ------------------ \n \n TRAGIC! Play again? " +
					"\n \n ------------------Press------------------ \n [Y] to return to the cell and try a different thread of fate"; 
		if (Input.GetKeyDown(KeyCode.Y)) {MyState = States.room;}
		}
	void state_hallway () {
		text.text="You manage to escape into the hallway, unnoticed for the moment. Looking around you, there is a hallway to both the left and the right of you, and both ends of the hallway have a door. You don't " + 
					"have much time! Quickly! Decide a path. \n ------------------ \n \n ------------------Press------------------ \n [X] to fight the men, \n [L] for the LEFT hallway, \n [R] for the RIGHT hallway";
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.death;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.left_hall;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.right_hall;}
		}
	void state_right_hall () {
		text.text="As you journey down the right hallway, you are met with a closed steel door. As you explore the interior of the building there is no noticable artwork, or decoration, or anything! " +
					"It's as drab as a prison! You reach for the steel door in front of you and try the handle, only to discover that the door is locked! Both your time and your options seems to be limited. " + 
					"you'll need to reach a decision quickly!!\n ------------------ \n \n ------------------Press------------------ \n [X] to go back and try to fight the guards, because 'fuck it.' \n  " +
					"[U] to try to lockpick the door quickly. \n [L] to dash down the left hall and attempt the other door"; 
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.death;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.guard_wait_right_hall;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.left_hall;} 
		}
	
	void state_guard_wait_right_hall () {
		text.text=" Ah! Of course the answer is so clear! You'll lockpick the door! You pat your prisoners garb only to realize you don't have a lockpick set, and you never did.As you contemplate the moment, you consider that in fact, " +  
					"even if you had a lockpicking kit, you wouldn't have the slightest clue on how to use it to unlock this door. You're in some trouble now. You take a moment to try and wriggle your finger in the keyhole before realizing " + 
					"this was getting you nowhere. Distracted, you never noticed the 4 men covered in tactical gear rushing you with night sticks drawn and bloodlust filling the eyes behind the masks. Within moments you're beaten to death. " +
					"\n ------------------ \n \n ------------------Press------------------ \n [Y] to return to the cell and try a different thread of fate";
		if (Input.GetKeyDown(KeyCode.Y)) {MyState = States.room;}
		}
	void state_left_hall () {
		text.text=" As you journey down the left hallway, you are met with a closed steel door. As you rush towards the door you stop and take a second to appreciate the architecture " +
					" You consider your options. You could try to fight the men who were previously beating on you, you could try the door, or you could contemplate your situation a little longer. " +
					" \n ------------------ \n \n ------------------Press------------------ \n [X] to fight the men pursuing you \n [D] to try the door \n Press nothing to contemplate longer my lad, no rush.";
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.death;}
		if (Input.GetKeyDown(KeyCode.D)) {MyState = States.door_outside;} 
		}
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//SECOND ACT / OUTSIDE DECISIONS / GANG SIDEQUEST
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	
	
	void state_door_outside () {
		text.text=" You rush forward and attempt the door and find it was not only unlocked, but also not closed completely and you tumble forward and through the door stumbling into what appears to be a busy street in the middle of a bustling city " + 
					"uncertain of what to do next, and hearing the guards behind you making a commotion, presumably because they've realized your escape, you know your time is limited. Your two immediate options appear to be " + 
					" a busy street full of cars and pedestrians, or a seedy alleyway that's not as populated \n ------------------ \n \n ------------------Press------------------ \n [S] to take the streeet \n [A] to enter the alleyway"; 
		if (Input.GetKeyDown(KeyCode.S)) {MyState = States.street;}
		if (Input.GetKeyDown(KeyCode.A)) {MyState = States.alley;} 
		}
	void state_street () {
		text.text=" You rush down the street and into the crowd, the stench of the city begins to fill your nose as you immerse yourself further. You consider crossing the street, it looks like there's less people over there anyways. " +
				"You could also continue to push on forward through this thick and smelly crowd of people, a loud roaring WHOOOSH interrupts your thoughts for a moment as a swarm of drones buzz not too far above everybodies heads, as you observe them they " +
				"appear to be scanning the crowds! You decide you ought to maybe hurry a little faster once again.  \n ------------------ \n \n ------------------Press------------------ \n [R] to cross the road \n [C] to  continue wriggling through the crowd."; 		
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.road;}
		if (Input.GetKeyDown(KeyCode.C)) {MyState = States.crowd;} 
		}
//developers note: This is my first game and really my first hands-on attempts at learning C# / continuing my education in C# and I just want to note that this is tedious as fuck, or at least more work than I imagined initially when I planned it out and 
//frankly with as lengthy as I made it, it's still going to be incredibly difficult to convey some kind of narrative, so sorry in advance if this sucks. 
	void state_road () {
		text.text=" You cannot stand the wretched crowd of people any longer and rush forward into the road. Perhaps on another day your luck would have been better, but you happen to have forgotten to look both ways before crossing on this particular " + 
					"day. It wasn't painful for long, relatively speaking. Dinosaurs ruled the earth for 150 Millon years, but you were only in agony for an incredibly breif 17 days as the local medical facility attempted to revive you, only to discover " +
					"in the end that you couldn't afford further medical treatment, and thus were denied further care.\n ------------------ PLAY AGAIN? \n \n ------------------Press------------------ \n [Y] to return to the cell and try a different thread of fate"; 		
		if (Input.GetKeyDown(KeyCode.Y)) {MyState = States.room;}
		}
	void state_crowd() {
		text.text=" You push your way through the crowd, determined! Certainly the whole city cannot be one large writhing mass of overcrowded city blocks? As you make your way through the people, a couple shady indivduals try to offer you various " + 
					"wares and trinkets out of the pockets of their jackets. One man offers you a jeweled fish, another offers to sell you what he claims is the city's original blueprints, but upon further inspection it appears to be a doodle done by " + 
					"a child no older than 11 years old. You have a hard time understanding the city's strange ways and stranger populace. \n ------------------ \n \n ------------------Press------------------ \n [Spacebar] to continue  \n  " +
					"or press no keys to browse the merchants wares a little longer. That was probably the nicest jeweled fish you've ever seen."; 
			if (Input.GetKeyDown(KeyCode.Space)) {MyState = States.id_checkpoint;}
		}
	void state_alley () {
		text.text=" You rush down the dark and seedy alleyway in hopes of evading the pursuit. As you enter you notice the men who were following you have obviously lost your trail, and you can take your time and be a bit more leisurely moving forward " +
					"You notice in the alley way, you could stop to inspect what appears to be a homeless man sitting inside of a cardboard box with the words HOME scrawled on the side in poor handwriting, and a pipe laying on the ground catches your eye " +
					" \n ------------------ \n \n ------------------Press------------------ \n [H] to investgate the Homeless man \n [P] to investigate the pipe \n [F] to move forward and ignore these obvious distractions ";
		if (Input.GetKeyDown(KeyCode.H)) {MyState = States.homeless_unarmed;}
		if (Input.GetKeyDown(KeyCode.P)) {MyState = States.pipe_weapon;}
		if (Input.GetKeyDown(KeyCode.F)) {MyState = States.unarmed_move_forward;} 
		}
	void state_homeless_unarmed () {
		text.text=" You approach the man in the cardboard box, and he begins whispering something to you but you can't quite make out what it is, so you move in closer to listen to him and you ask him politely to repeat himself, and upon your request " +
					"The man immediately begins spitting large wads of phlegm at you, the first one hitting you directly in the face. You reel in disgust and back away from the homeless man. \n ------------------ \n " +
					"\n ------------------Press------------------ \n [P] to investigate the pipe \n [F] to move forward \n Take no action to hang out and observe the bum for a while in his natural habitat! ";
		if (Input.GetKeyDown(KeyCode.P)) {MyState = States.pipe_weapon;}
		if (Input.GetKeyDown(KeyCode.F)) {MyState = States.unarmed_move_forward;}
		}
	void state_pipe_weapon () {
		text.text=" You approach the pipe on the ground and pick it up, it's covered in more rust than you had previously expected but, it's rather heavy and you think it could make for a particularly useful weapon, at least for a couple dozen swings " +
		"\n ------------------ \n \n ------------------Press------------------ \n [H] to attack the homeless man \n [M] to move forward down the alley"; 
		if (Input.GetKeyDown(KeyCode.H)) {MyState = States.homeless_armed_1;}
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.encounter_armed;}		
		}
		void state_homeless_armed_1 () {
		text.text=" You approach the homeless man, hand tightly gripping your newfound pipe. It's not the nicest pipe in the world, but goddamnit it's YOUR pipe. The more you look at the homeless man, the more you are filled with disgust and contempt " +
					"You know what must be done..   \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
		}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
	
	void state_STATEHERE () {
		text.text=" XXXTEXTXXX \n ------------------ \n \n ------------------Press------------------ \n BUTTON \n BUTTON \n BUTTON " +
			"the left hall and attempt the other door"; 
		
		
		
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.U)) {MyState = States.;}
		if (Input.GetKeyDown(KeyCode.L)) {MyState = States.;} 
		
	}
	
}	
