using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TextController : MonoBehaviour {

public Text text;

private enum States {title, room, window, door, toilet, convo, noise, hallway, left_hall, right_hall, locked_door, guard_wait_right_hall, guard_wait_left_hall,
					door_outside, street, road, alley, crowd, id_Checkpoint, go_right_id_Check, go_left_id_check, unarmed_move_forward, encounter_unarmed,
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
		if (MyState == States.title)	{state_title ();}
		else if (MyState == States.room)	{state_room ();} 
		else if (MyState == States.window)	{state_window ();}
		else if (MyState == States.door)	{state_room ();} 
		else if (MyState == States.toilet)	{state_room ();} 
		else if (MyState == States.convo)	{state_room ();} 
		else if (MyState == States.noise)	{state_room ();} 
		else if (MyState == States.hallway)	{state_room ();}
		else if (MyState == States.left_hall)	{state_room ();} 
		else if (MyState == States.right_hall)	{state_room ();} 
		else if (MyState == States.locked_door)	{state_room ();} 
		else if (MyState == States.guard_wait_right_hall)	{state_room ();} 
		else if (MyState == States.guard_wait_left_hall)	{state_room ();}
		else if (MyState == States.door_outside)	{state_room ();} 
		else if (MyState == States.street)	{state_room ();} 
		else if (MyState == States.road)	{state_room ();} 
		else if (MyState == States.alley)	{state_room ();} 
		else if (MyState == States.crowd)	{state_room ();}
		else if (MyState == States.id_Checkpoint)	{state_room ();} 
		else if (MyState == States.go_right_id_Check)	{state_room ();} 
		else if (MyState == States.go_left_id_check)	{state_room ();} 
		else if (MyState == States.unarmed_move_forward)	{state_room ();} 
		else if (MyState == States.encounter_unarmed)	{state_room ();}
		else if (MyState == States.homeless_unarmed)	{state_room ();} 
		else if (MyState == States.pipe_weapon)	{state_room ();} 
		else if (MyState == States.homless_armed_1)	{state_room ();} 
		else if (MyState == States.homeless_armed_2)	{state_room ();} 
		else if (MyState == States.encounter_armed)	{state_room ();}
		else if (MyState == States.attack)	{state_room ();} 
		else if (MyState == States.respect)	{state_room ();} 
		else if (MyState == States.join)	{state_room ();} 
		else if (MyState == States.dont_join)	{state_room ();} 
		else if (MyState == States.mission_1)	{state_room ();}
		else if (MyState == States.kill_sleeping_1)	{state_room ();} 
		else if (MyState == States.kill_sleeping_2)	{state_room ();} 
		else if (MyState == States.mission_2)	{state_room ();} 
		else if (MyState == States.back_in_streets)	{state_room ();} 
		else if (MyState == States.seen_2_much)	{state_room ();}
		else if (MyState == States.wander)	{state_room ();} 
		else if (MyState == States.newspaper)	{state_room ();} 
		else if (MyState == States.id_check_spotted_left)	{state_room ();} 
		else if (MyState == States.try_2_run)	{state_room ();} 
		else if (MyState == States.take_help_offer)	{state_room ();}
		else if (MyState == States.sewer_left)	{state_room ();} 
		else if (MyState == States.sewer_right)	{state_room ();} 
		else if (MyState == States.sewer_swim)	{state_room ();}
		else if (MyState == States.sewer_shimmy)	{state_room ();} 
		else if (MyState == States.sewer_gates)	{state_room ();} 
		else if (MyState == States.sewer_king)	{state_room ();} 
		else if (MyState == States.sewer_escape)	{state_room ();}
		else if (MyState == States.forest)	{state_room ();} 
		else if (MyState == States.live_off_land)	{state_room ();}
		else if (MyState == States.travel)	{state_room ();} 
		else if (MyState == States.checkpoint_id_2)	{state_room ();} 
		else if (MyState == States.other_direction_endgame)	{state_room ();} 
		else if (MyState == States.dronestrike)	{state_room ();} 
		
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
		}
	
	void state_window () { 
		text.text="You try to peer out the small slit to see the outside world but you're met with only blinding light from the outside, " +
		 			"it's too bright to see. \n \n Press [R] to return to roaming your room.";    
		
		if (Input.GetKeyDown(KeyCode.R)) {MyState = States.room;}
	}


		if state_door () {  
		


































































}
