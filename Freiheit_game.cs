using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TextController : MonoBehaviour {

public Text text;

private enum States {title, room, window, door, toilet, noise, beating, death, hallway, left_hall, right_hall, locked_door, guard_wait_right_hall, guard_wait_left_hall,
		door_outside, street, road, alley, crowd, id_checkpoint, go_right_id_check, go_left_id_check, unarmed_move_forward, encounter_unarmed,
					homeless_unarmed, pipe_weapon, homless_armed_1, homeless_armed_2, encounter_armed, attack, respect, join, dont_join, mission_1, 
					kill_sleeping_1, kill_sleeping_2, mission_2, back_in_streets, seen_2_much, wander, newspaper, id_check_spotted_left, try_2_run, 
					take_help_offer, sewer_left, sewer_right, sewer_swim, sewer_shimmy, sewer_gates, sewer_king, sewer_escape, forest, live_off_land, 
					travel, checkpoint_id_2, other_direction_endgame, dronestrike 
					};
private States MyState;
	// Use this for initialization
	
	
	
	
	void Start () {
		
		if (Input.GetKeyDown(KeyCode.Space)) { 
			MyState = States.room;	
			}		
	}
	
	// Update is called once per frame
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
		else if (MyState == States.left_hall)				{state_left_hall ();} 
		else if (MyState == States.right_hall)				{state_right_hall ();} 
		else if (MyState == States.locked_door)				{state_locked_door ();} 
		else if (MyState == States.guard_wait_right_hall)	{state_guard_wait_right_hall ();} 
		else if (MyState == States.guard_wait_left_hall)	{state_guard_wait_left_hall ();}
		else if (MyState == States.door_outside)			{state_door_outside ();} 
		else if (MyState == States.street)					{state_street ();} 
		else if (MyState == States.road)					{state_road ();} 
		else if (MyState == States.alley)					{state_alley ();} 
		else if (MyState == States.crowd)					{state_crowd ();}
		else if (MyState == States.id_checkpoint)			{state_id_checkpoint ();} 
		else if (MyState == States.go_right_id_check)		{state_go_right_id_check ();} 
		else if (MyState == States.go_left_id_check)		{state_go_left_id_check ();} 
		else if (MyState == States.unarmed_move_forward)	{state_unarmed_move_forward ();} 
		else if (MyState == States.encounter_unarmed)		{state_encounter_unarmed();}
		else if (MyState == States.homeless_unarmed)		{state_homeless_unarmed ();} 
		else if (MyState == States.pipe_weapon)				{state_pipe_weapon ();} 
		else if (MyState == States.homless_armed_1)			{state_homless_armed_1 ();} 
		else if (MyState == States.homeless_armed_2)		{state_homeless_armed_2 ();} 
		else if (MyState == States.encounter_armed)			{state_encounter_armed();}
		else if (MyState == States.attack)					{state_attack ();} 
		else if (MyState == States.respect)					{state_respect ();} 
		else if (MyState == States.join)					{state_join ();} 
		else if (MyState == States.dont_join)				{state_dont_join ();} 
		else if (MyState == States.mission_1)				{state_mission_1 ();}
		else if (MyState == States.kill_sleeping_1)			{state_kill_sleeping_1 ();} 
		else if (MyState == States.kill_sleeping_2)			{state_kill_sleeping_2 ();} 
		else if (MyState == States.mission_2)				{state_mission_2 ();} 
		else if (MyState == States.back_in_streets)			{state_back_in_streets ();} 
		else if (MyState == States.seen_2_much)				{state_seen_2_much ();}
		else if (MyState == States.wander)					{state_wander ();} 
		else if (MyState == States.newspaper)				{state_newspaper ();} 
		else if (MyState == States.id_check_spotted_left)	{state_id_check_spotted_left ();} 
		else if (MyState == States.try_2_run)				{state_try_2_run ();} 
		else if (MyState == States.take_help_offer)			{state_take_help_offer ();}
		else if (MyState == States.sewer_left)				{state_sewer_left ();} 
		else if (MyState == States.sewer_right)				{state_sewer_right ();} 
		else if (MyState == States.sewer_swim)				{state_sewer_swim ();}
		else if (MyState == States.sewer_shimmy)			{state_sewer_shimmy ();} 
		else if (MyState == States.sewer_gates)				{state_sewer_gates ();} 
		else if (MyState == States.sewer_king)				{state_sewer_king ();} 
		else if (MyState == States.sewer_escape)			{state_sewer_escape ();}
		else if (MyState == States.forest)					{state_forest ();} 
		else if (MyState == States.live_off_land)			{state_live_off_land ();}
		else if (MyState == States.travel)					{state_travel ();} 
		else if (MyState == States.checkpoint_id_2)			{state_checkpoint_id_2 ();} 
		else if (MyState == States.other_direction_endgame)	{state_other_direction_endgame ();} 
		else if (MyState == States.dronestrike)				{state_dronestrike ();} 
		
	} 
	
	void state_title (){ 
		text.text = "\n \n 'F R E I H E I T' - Please press [SPACEBAR] to begin your journey. \n \n" + "Copyright © 2018 by Cody James Ryan " +
				"All rights reserved. No part of this publication may be reproduced, distributed, or transmitted in any form or by any means, " + 
				"including photocopying, recording, or other electronic or mechanical methods, without the prior written permission of the " +
				"publisher, except in the case of brief quotations embodied in critical reviews and certain other noncommercial " +
				"uses permitted by copyright law. For permission requests, write to the publisher, addressed " + 
				"“Attention: Permissions Coordinator,” at the email below. \n \n " + "PlVSVLTRA969@GMAIL.COM"; 
				if (Input.GetKeyDown(KeyCode.Space)) {MyState = States.room;}
				}
	void state_room () { 
		text.text="Dawn breaks on a new day and you awaken in a groggy stupor, the sun is filling the small cold room you find yourself in. " +
				"Your head hurts and you don't remember how you arrived here. As you shake off the sleep, you hear voices in the distance talking. " + 
				"As you look around the room: There's the simple cot you were sleeping on, a small toilet in the corner of the room, " + 
				"and a door and a small slit window. Otherwise the cold room is empty and drafty. You continue hearing voices beyond the door. \n\n" +
				"Press [T] to look at the toilet, [W] to look at the window slit, [D] to approach the door";    
		 if (Input.GetKeyDown(KeyCode.W)) {MyState = States.window;}
		 if (Input.GetKeyDown(KeyCode.D)) {MyState = States.door;}
		 if (Input.GetKeyDown(KeyCode.T)) {MyState = States.toilet;}
		}
	void state_window () { 
		text.text="You try to peer out the small slit to see the outside world but you're met with only blinding light from the outside, " +
		 			"it's too bright to see. \n \n Press [R] to return to roaming your room.";    
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		}
	void state_door () {
		text.text="You approach the cold steel door. You hear voices murmuring from somewhere on the other side of the door, but you cannot make out what they are saying. " +
					"You notice there's blood on both the floor and the door. \n \n Press [M] to make some noise to attract attention, or press [R] to return to investigating the room";    
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.noise;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		}
	void state_toilet () {
		text.text="You walk up to the toilet in the room, it's surprisingly clean! The toilet paper is dry and scratchy however, and you notice it is very thin. You sit down for a moment to contemplate your situation. " +
					"''Life is a cruel and unsusal place for putting me here.'' You think to yourself as you sit on your clean toilet. You further ponder. \n \n Press [R] to return to investigating the room, your legs are " +
					"getting tired anyways. Press nothing to continue to sit on the shitter and consider";  
			if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		}
	void state_noise () {
		text.text="You begin screaming and howling as if you were a wounded dog. Banging and pounding on the door with all your might, you're certain that this display will attract some attention and you can finally demand some " + 
					"answers around here. You've been waiting patiently for who know's how long now! Long enough that's for certain. *BANG BANG* you pound on the door as your audible wails continue \n \n " + 
					"Press [SPACEBAR] to pound on the door like it owed you money"; 
		if (Input.GetKeyDown(KeyCode.Space)) {MyState = States.beating;}
		}
	
	
	void state_beating () {
		text.text="4 men in tactical body armor rush into the room with night sticks and, as you begin to demand to know just what is going on here, they begin swinging wildly and the clubs begin connecting with " + 
			"various parts of your body, you feel and hear your bones crunching and fracturing beneath their consecutive blows. You notice a moment where you're able to slip out from their beatings and sprint out the open door, " +
			"it seems as if the guards take a moment to notice that you've slipped out in the blind fury of their swings. \n \n Press [X] to wait for the guards to realize you've slipped out, and try and fight them " + 
			"or Press [SPACEBAR] to hurry down the hallway";  
		if (Input.GetKeyDown(KeyCode.Space)) {MyState = States.hallway;}
		if (Input.GetKeyDown(KeyCode.X)) {MyState = States.death;}
		}
	void state_death () {
		text.text="Nobody is really sure why you thought this would be a good idea, but you put your fists up and prepare for combat. Suddenly the 4 men realize you've crawled out from the beating and they rush you " + 
					"and begin pummling you with a renewed vigor. Your trying your best to pick up your teeth from the ground between blows but then a particularly nasty swing cracks your eye socket and you lose vision. " +
					"The sound of night sticks falling on bruised flesh and broken bone are the last sounds you hear as you black out and never regain consiousness. \n \n TRAGIC! Play again? Press [Y] to return to " +
					"the cell and try a different thread of fate"; 
	if (Input.GetKeyDown(KeyCode.P)) {MyState = States.room;}
		}
	
	
	void state_hallway () {
		text.text="You manage to escape into the hallway, looking around you, 
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}
	
	
	void state_ () {
		text.text=
			
			
			
		if (Input.GetKeyDown(KeyCode.M)) {MyState = States.room;}
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
		
	}


	






























}
